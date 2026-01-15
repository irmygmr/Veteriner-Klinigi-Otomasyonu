using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace VeterinerKlinigiOtomasyonu
{
    public partial class OdemeBilgileriForm : Form
    {
        string baglantiAdresi = SqlBaglanti.Adres;

        public OdemeBilgileriForm()
        {
            InitializeComponent();
            this.Load += OdemeBilgileriForm_Load;
            // Hücre renklendirme olayı
            this.viewGecmis.RowCellStyle += ViewGecmis_RowCellStyle;
        }

        // Dinamik olarak bulacağımız ID kolon adı
        string kasaIdKolonu = "ID"; 

        private void OdemeBilgileriForm_Load(object sender, EventArgs e)
        {
            // VeritabaniYapilandir(); // HATALI KOD KALDIRILDI
            VerileriYukle();
        }

        void VerileriYukle()
        {
            try
            {
                string aktifKullanici = LoginForm.AktifKullaniciAdi;
                if (string.IsNullOrEmpty(aktifKullanici)) return;

                using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                {
                    baglanti.Open();

                    // 0. Önce Kasa tablosunun Identity (PK) kolonunu bulalım
                    SqlCommand cmdIdFind = new SqlCommand("SELECT name FROM sys.identity_columns WHERE object_id = OBJECT_ID('Kasa')", baglanti);
                    object resultId = cmdIdFind.ExecuteScalar();
                    if (resultId != null)
                    {
                        kasaIdKolonu = resultId.ToString();
                    }

                    // 1. Kullanıcının Ad Soyadını al
                    SqlCommand kmtUser = new SqlCommand("SELECT Ad, Soyad FROM Kullanicilar WHERE KullaniciAdi=@p1", baglanti);
                    kmtUser.Parameters.AddWithValue("@p1", aktifKullanici);
                    
                    string tamAd = "";
                    using (SqlDataReader dr = kmtUser.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            tamAd = dr["Ad"].ToString() + " " + dr["Soyad"].ToString();
                        }
                    }

                    if (string.IsNullOrEmpty(tamAd)) return;

                    // 2. Kullanıcının Hayvanlarının ID'lerini bul
                    string hayvanIdsQuery = "SELECT HayvanId FROM Hayvanlar WHERE Sahibi=@p1";
                    
                    // 3. Kasa Geçmişini getir (Bu hayvanlara ait işlemler)
                    // Dinamik kolon ismini kullanıyoruz.
                    string query = @"SELECT " + kasaIdKolonu + @" as KasaId,
                                            IslemTipi,
                                            Tarih, 
                                            CASE WHEN IslemTipi = 'Borc' OR IslemTipi = 'Borç' THEN 'Hizmet Bedeli' ELSE 'Ödeme' END as Islem, 
                                            Aciklama,
                                            Tutar, 
                                            CASE WHEN IslemTipi = 'Borc' OR IslemTipi = 'Borç' THEN 'Ödenmedi' ELSE 'Ödendi' END as Durum 
                                     FROM Kasa 
                                     WHERE MusteriId IN (" + hayvanIdsQuery + @") 
                                     ORDER BY Tarih DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, baglanti);
                    da.SelectCommand.Parameters.AddWithValue("@p1", tamAd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    gridGecmis.DataSource = dt;

                    // 4. Borç Durumu Hesaplama (Tablo üzerinden)
                    decimal toplamBorc = 0;
                    decimal toplamOdenen = 0;

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            // Veritabanındaki ham 'IslemTipi' değerine bakalım.
                            string rawTip = dr["IslemTipi"] != DBNull.Value ? dr["IslemTipi"].ToString() : "";
                            decimal tutar = 0;

                            if (dr["Tutar"] != DBNull.Value)
                            {
                                tutar = Convert.ToDecimal(dr["Tutar"]);
                            }

                            // Büyük/Küçük harf duyarlılığını kaldırmak için ToLower() kullanıyoruz.
                            string tipLower = rawTip.ToLower(new System.Globalization.CultureInfo("tr-TR"));

                            // İçinde 'borc' veya 'borç' geçiyorsa borç kabul et
                            if (tipLower.Contains("borc") || tipLower.Contains("borç"))
                            {
                                toplamBorc += tutar;
                            }
                            // SADECE 'tahsilat' veya 'ödeme' (veya 'odeme') geçiyorsa ödeme kabul et
                            else if (tipLower.Contains("tahsilat") || tipLower.Contains("ödeme") || tipLower.Contains("odeme"))
                            {
                                toplamOdenen += tutar;
                            }
                            else
                            {
                                // Bilinmeyen işlem tipi
                            }
                        }
                    }

                    // Kullanıcı İsteği: Ödenenlerle farkı hesaplama, sadece toplam borcu göster.
                    decimal guncelBorc = toplamBorc;

                    BorcDurumuGuncelle(guncelBorc, toplamBorc, toplamOdenen);
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıyı bilgilendir
                MessageBox.Show("Bilgiler yüklenirken hata: " + ex.Message);
                BorcDurumuGuncelle(0, 0, 0); 
            }
        }

        void BorcDurumuGuncelle(decimal borc, decimal toplamBorc, decimal toplamOdenen)
        {
            if (borc > 0)
            {
                // Borç Var
                lblBorcDurumu.Text = string.Format("GÜNCEL BORÇ:\r\n{0:C2}", borc);
                lblBorcDurumu.Appearance.BackColor = Color.Red; // "Kırmızı"
            }
            else
            {
                // Borç Yok
                lblBorcDurumu.Text = "BORCUNUZ YOK";
                lblBorcDurumu.Appearance.BackColor = Color.Green; // "Yeşil / Yok"
            }
        }

        public void repoBtnOde_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            // Butona basıldığında çalışacak kod
            DataRow dr = viewGecmis.GetDataRow(viewGecmis.FocusedRowHandle);
            if (dr != null)
            {
                string islem = dr["Islem"].ToString();
                // Sadece 'Hizmet Bedeli' (Borç) olanları ödeyebiliriz
                if (islem != "Hizmet Bedeli")
                {
                    MessageBox.Show("Bu işlem zaten ödenmiş veya ödeme işlemi.");
                    return;
                }

                if (DialogResult.Yes == MessageBox.Show("Bu borcu ödediğinizi onaylıyor musunuz?", "Ödeme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    try
                    {
                        // KasaId'yi dinamik olarak sorgudan alias ile 'KasaId' diye çekmiştik, o yüzden burada güvenle kullanabiliriz.
                        int rowId = Convert.ToInt32(dr["KasaId"]);
                        using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                        {
                            baglanti.Open();
                            // KasaIdKolonu değişkenini burada da kullanabilmemiz lazım ama 
                            // methodlar arası scope sorunu olmasın diye dinamik bulduğumuz kolonu burada tekrar kullanma şansımız yok (VerileriYukle içinde bulduk).
                            // Ancak sorguda "SELECT ... as KasaId" dediğimiz için DataTable'da sütun adı hep "KasaId" olacak.
                            // AMA UPDATE sorgusunda gerçek kolon ismine ihtiyacımız var!
                            // O yüzden kasaIdKolonu değişkenini sınıf seviyesinde tanımlamalıyız.
                            // Kodun başında sınıf seviyesine taşıdım.
                            
                            string updateQuery = "UPDATE Kasa SET IslemTipi='Tahsilat', Aciklama=Aciklama + ' (Ödendi)' WHERE " + kasaIdKolonu + "=@p1";
                            
                            SqlCommand cmd = new SqlCommand(updateQuery, baglanti);
                            cmd.Parameters.AddWithValue("@p1", rowId);
                            cmd.ExecuteNonQuery();
                        }
                        
                        // Listeyi yenile
                        VerileriYukle();
                        MessageBox.Show("Ödeme işlemi kaydedildi.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ödeme sırasında hata: " + ex.Message);
                    }
                }
            }
        }
        private void ViewGecmis_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            // Sadece 'Ödeme Yap' kolonu için işlem yap
            if (e.Column.FieldName == "colOde" || e.Column.Caption == "Ödeme Yap")
            {
                // Satırdaki veriyi al
                DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
                
                // NOT: Kullanıcı 'Islem' kolonunu tasarımdan sildiği için GetRowCellDisplayText çalışmayabilir.
                // Bu yüzden doğrudan DataRow üzerinden okuyoruz. Veri kaynağında bu bilgi hala var.
                DataRow dr = view.GetDataRow(e.RowHandle);
                if (dr != null)
                {
                    string islem = dr["Islem"].ToString();

                    // Eğer "Hizmet Bedeli" (yani ödenmemiş borç) ise
                    if (islem == "Hizmet Bedeli")
                    {
                        e.Appearance.BackColor = Color.OrangeRed;
                        e.Appearance.ForeColor = Color.White;
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                    }
                }
            }
        }
        private void gridGecmis_Click(object sender, EventArgs e)
        {
            // Grid tıklandığında yapılacak işlemler (boş bırakıldı)
        }

    }
}
