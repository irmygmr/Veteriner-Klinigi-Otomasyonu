using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace VeterinerKlinigiOtomasyonu
{
    public partial class KasaForm : XtraForm
    {
        string baglantiAdresi = SqlBaglanti.Adres;
        int seciliKayitId = 0; // Güncelleme ve Silme için
        string pkKolonAdi = "KasaId"; // Varsayılan, dinamik olarak değişebilir

        public KasaForm()
        {
            InitializeComponent();
            this.Load += KasaForm_Load;
            
            // Event Handlers
            radioIslemTipi.SelectedIndexChanged += RadioIslemTipi_SelectedIndexChanged;
            
            // Hesaplama
            txtAdet.TextChanged += Hesaplamalar_TextChanged;
            txtBirimFiyat.TextChanged += Hesaplamalar_TextChanged;

            // Grid Selection
            gridViewGelir.FocusedRowChanged += GridView_FocusedRowChanged;
            gridViewGider.FocusedRowChanged += GridView_FocusedRowChanged;
        }

        private void KasaForm_Load(object sender, EventArgs e)
        {
            VeritabaniKontrol();
            ListeleMusterilerForLookup();
            ListeleGelir();
            ListeleGider();
            HesaplaOzet();
            Temizle();
        }

        void VeritabaniKontrol()
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                {
                    baglanti.Open();

                    // 1. Mevcut Identity/PK Kolonunu Bul
                    SqlCommand cmdFindIdentity = new SqlCommand("SELECT name FROM sys.identity_columns WHERE object_id = OBJECT_ID('Kasa')", baglanti);
                    object identityCol = cmdFindIdentity.ExecuteScalar();

                    if (identityCol != null && identityCol != DBNull.Value)
                    {
                        // Zaten bir identity kolonu var (Muhtemelen 'Id' veya user'ın oluşturduğu başka bir şey)
                        pkKolonAdi = identityCol.ToString();
                    }
                    else
                    {
                        // Identity kolonu yok, KasaId eklemeyi dene
                        // Önce KasaId var mı diye bak (Identity olmayabilir ama kolon olabilir)
                        SqlCommand cmdCheckId = new SqlCommand("SELECT COL_LENGTH('Kasa', 'KasaId')", baglanti);
                        object idExists = cmdCheckId.ExecuteScalar();

                        if (idExists == null || idExists == DBNull.Value)
                        {
                             try 
                             {
                                 SqlCommand cmdAddId = new SqlCommand("ALTER TABLE Kasa ADD KasaId INT IDENTITY(1,1) PRIMARY KEY", baglanti);
                                 cmdAddId.ExecuteNonQuery();
                                 pkKolonAdi = "KasaId";
                             }
                             catch (Exception exAdd)
                             {
                                 MessageBox.Show("Veritabanı Kimlik Kolonu Oluşturulamadı: " + exAdd.Message + "\nLütfen veritabanınızı kontrol edin.");
                             }
                        }
                        else
                        {
                            pkKolonAdi = "KasaId";
                        }
                    }

                    // 2. Diğer kolonlar (Aciklama, Adet, BirimFiyat)
                    string[] kolonlar = { "Aciklama NVARCHAR(MAX)", "Adet INT DEFAULT 1", "BirimFiyat DECIMAL(18,2) DEFAULT 0" };
                    foreach (string kolonTanim in kolonlar)
                    {
                        string kolonAd = kolonTanim.Split(' ')[0];
                        SqlCommand cmdCheck = new SqlCommand("SELECT COL_LENGTH('Kasa', '" + kolonAd + "')", baglanti);
                        if (cmdCheck.ExecuteScalar() == null)
                        {
                            SqlCommand cmdAdd = new SqlCommand("ALTER TABLE Kasa ADD " + kolonTanim, baglanti);
                            cmdAdd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Veritabanı Kontrol Hatası: " + ex.Message);
            }
        }

        void ListeleGelir()
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                {
                    // Dinamik PK kullanımı
                    string query = @"
                        SELECT 
                            k." + pkKolonAdi + @" as [KayitId],
                            k.Tarih, 
                            h.Ad as [MusteriAdi], 
                            k.MusteriId,
                            k.IslemTipi, 
                            k.Aciklama, 
                            k.Adet, 
                            k.BirimFiyat, 
                            k.Tutar,
                            CASE 
                                WHEN k.IslemTipi = 'Tahsilat' THEN 'Ödendi' 
                                ELSE 'Borç' 
                            END as [OdemeDurumu]
                        FROM Kasa k 
                        LEFT JOIN Hayvanlar h ON k.MusteriId = h.HayvanId 
                        WHERE k.IslemTipi IN ('Tahsilat', 'Borc') 
                        ORDER BY k.Tarih DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gridControlGelir.DataSource = dt;
                    
                    // Grid sütun ayarları (KayitId hidden olabilir veya gösterilebilir)
                    gridViewGelir.PopulateColumns();
                    if(gridViewGelir.Columns["KayitId"] != null) gridViewGelir.Columns["KayitId"].Visible = false;
                    if(gridViewGelir.Columns["MusteriId"] != null) gridViewGelir.Columns["MusteriId"].Visible = false;
                }
            }
            catch (Exception ex) { MessageBox.Show("Gelir Listesi Hatası: " + ex.Message); }
        }

        void ListeleGider()
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                {
                    string query = @"
                        SELECT 
                            k." + pkKolonAdi + @" as [KayitId],
                            k.Tarih, 
                            k.IslemTipi, 
                            k.Aciklama, 
                            k.Adet, 
                            k.BirimFiyat, 
                            k.Tutar 
                        FROM Kasa k 
                        WHERE k.IslemTipi = 'Gider' 
                        ORDER BY k.Tarih DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gridControlGider.DataSource = dt;
                    
                    gridViewGider.PopulateColumns();
                    if(gridViewGider.Columns["KayitId"] != null) gridViewGider.Columns["KayitId"].Visible = false;
                }
            }
            catch (Exception ex) { MessageBox.Show("Gider Listesi Hatası: " + ex.Message); }
        }

        void ListeleMusterilerForLookup()
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT HayvanId, Ad, Sahibi FROM Hayvanlar", baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    lookUpMusteri.Properties.DataSource = dt;
                    lookUpMusteri.Properties.ValueMember = "HayvanId";
                    lookUpMusteri.Properties.DisplayMember = "Ad";
                    lookUpMusteri.Properties.PopulateColumns();
                    if(lookUpMusteri.Properties.Columns["HayvanId"] != null)
                        lookUpMusteri.Properties.Columns["HayvanId"].Visible = false;
                }
            }
            catch { }
        }

        private void RadioIslemTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                if (radioIslemTipi.SelectedIndex == -1) return;
                string secilen = radioIslemTipi.Properties.Items[radioIslemTipi.SelectedIndex].Value.ToString();
                
                if (secilen == "Gider")
                {
                    lookUpMusteri.Enabled = false;
                    lookUpMusteri.EditValue = null;
                }
                else
                {
                    lookUpMusteri.Enabled = true;
                }
            } catch {}
        }

        private void Hesaplamalar_TextChanged(object sender, EventArgs e)
        {
            decimal adet = 0, fiyat = 0;
            decimal.TryParse(txtAdet.Text, out adet);
            decimal.TryParse(txtBirimFiyat.Text, out fiyat);
            
            if (adet == 0 && !string.IsNullOrEmpty(txtBirimFiyat.Text)) adet = 1;

            txtOdemeTutar.Text = (adet * fiyat).ToString();
        }

        void Temizle()
        {
            seciliKayitId = 0;
            txtAciklama.Text = "";
            txtAdet.Text = "";
            txtBirimFiyat.Text = "";
            txtOdemeTutar.Text = "";
            lookUpMusteri.EditValue = null;
            radioIslemTipi.SelectedIndex = 0;
            
            // Buton durumları
            btnEkle.Enabled = true;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }

        private void GridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.GetFocusedRow() == null) return;

            try
            {
                // 'KayitId' alias'ını kullandığımız için buradan okuyoruz
                object idVal = view.GetRowCellValue(view.FocusedRowHandle, "KayitId");
                if (idVal != DBNull.Value && idVal != null)
                {
                    seciliKayitId = Convert.ToInt32(idVal);

                    // Formu doldur
                    object valAciklama = view.GetRowCellValue(view.FocusedRowHandle, "Aciklama");
                    txtAciklama.Text = (valAciklama != null) ? valAciklama.ToString() : "";
                    
                    object adetVal = view.GetRowCellValue(view.FocusedRowHandle, "Adet");
                    txtAdet.Text = (adetVal != DBNull.Value && adetVal != null) ? adetVal.ToString() : "1";

                    object fiyatVal = view.GetRowCellValue(view.FocusedRowHandle, "BirimFiyat");
                    txtBirimFiyat.Text = (fiyatVal != DBNull.Value && fiyatVal != null) ? fiyatVal.ToString() : "0";

                    // Islem Tipi
                    object tipVal = view.GetRowCellValue(view.FocusedRowHandle, "IslemTipi");
                    string tip = (tipVal != null) ? tipVal.ToString() : "Tahsilat";

                    if (tip == "Tahsilat") radioIslemTipi.SelectedIndex = 0;
                    else if (tip == "Borc") radioIslemTipi.SelectedIndex = 1;
                    else radioIslemTipi.SelectedIndex = 2; // Gider

                    // Musteri (Varsa)
                    if (view.Columns["MusteriId"] != null)
                    {
                        object mId = view.GetRowCellValue(view.FocusedRowHandle, "MusteriId");
                        if (mId != DBNull.Value) lookUpMusteri.EditValue = mId;
                        else lookUpMusteri.EditValue = null;
                    }

                    // Güncelleme Moduna Geç
                    btnEkle.Enabled = false;
                    btnGuncelle.Enabled = true;
                    btnSil.Enabled = true;
                }
            }
            catch { }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kaydet(false);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Kaydet(true);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (seciliKayitId == 0) return;
            if (MessageBox.Show("Bu kaydı silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            try
            {
                using (SqlConnection conn = new SqlConnection(baglantiAdresi))
                {
                    conn.Open();
                    // Dinamik PK ile silme
                    SqlCommand cmd = new SqlCommand("DELETE FROM Kasa WHERE " + pkKolonAdi + "=@id", conn);
                    cmd.Parameters.AddWithValue("@id", seciliKayitId);
                    cmd.ExecuteNonQuery();
                }
                ListeleGelir();
                ListeleGider();
                HesaplaOzet();
                Temizle();
            }
            catch (Exception ex) { MessageBox.Show("Silme Hatası: " + ex.Message); }
        }

        void Kaydet(bool guncelleme)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(baglantiAdresi))
                {
                    conn.Open();
                    
                    // Alanları Al
                    string tip = "Tahsilat";
                    if (radioIslemTipi.SelectedIndex != -1)
                        tip = radioIslemTipi.Properties.Items[radioIslemTipi.SelectedIndex].Value.ToString();

                    string aciklama = txtAciklama.Text;
                    decimal tutar = 0; decimal.TryParse(txtOdemeTutar.Text, out tutar);
                    int adet = 1; int.TryParse(txtAdet.Text, out adet);
                    decimal birimFiyat = 0; decimal.TryParse(txtBirimFiyat.Text, out birimFiyat);
                    object mId = (lookUpMusteri.EditValue == null) ? DBNull.Value : lookUpMusteri.EditValue;

                    if (tip != "Gider" && mId == DBNull.Value)
                    {
                        MessageBox.Show("Lütfen müşteri seçiniz.");
                        return;
                    }

                    string query = "";
                    if (guncelleme)
                    {
                        // Dinamik PK ile güncelleme
                        query = "UPDATE Kasa SET MusteriId=@p1, IslemTipi=@p2, Tutar=@p3, Aciklama=@p4, Adet=@p5, BirimFiyat=@p6 WHERE " + pkKolonAdi + "=@id";
                    }
                    else
                    {
                        query = "INSERT INTO Kasa (MusteriId, IslemTipi, Tutar, Tarih, Aciklama, Adet, BirimFiyat) VALUES (@p1, @p2, @p3, GETDATE(), @p4, @p5, @p6)";
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@p1", mId);
                    cmd.Parameters.AddWithValue("@p2", tip);
                    cmd.Parameters.AddWithValue("@p3", tutar);
                    cmd.Parameters.AddWithValue("@p4", aciklama);
                    cmd.Parameters.AddWithValue("@p5", adet);
                    cmd.Parameters.AddWithValue("@p6", birimFiyat);

                    if (guncelleme) cmd.Parameters.AddWithValue("@id", seciliKayitId);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show(guncelleme ? "Güncellendi" : "Kaydedildi");
                }

                ListeleGelir();
                ListeleGider();
                HesaplaOzet();
                if (!guncelleme) Temizle();
                else Temizle();
            }
            catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
        }

        void HesaplaOzet()
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                {
                    baglanti.Open();
                    SqlCommand cmdGelir = new SqlCommand("SELECT ISNULL(SUM(Tutar),0) FROM Kasa WHERE IslemTipi='Tahsilat'", baglanti);
                    decimal gelir = Convert.ToDecimal(cmdGelir.ExecuteScalar());

                    SqlCommand cmdGider = new SqlCommand("SELECT ISNULL(SUM(Tutar),0) FROM Kasa WHERE IslemTipi='Gider'", baglanti);
                    decimal gider = Convert.ToDecimal(cmdGider.ExecuteScalar());

                    decimal net = gelir - gider;

                    lblToplamGelir.Text = "Toplam Gelir: " + gelir.ToString("C2");
                    lblToplamGider.Text = "Toplam Gider: " + gider.ToString("C2");
                    lblNetKasa.Text = "Net Kasa: " + net.ToString("C2");

                    if (net >= 0) lblNetKasa.ForeColor = Color.DarkBlue;
                    else lblNetKasa.ForeColor = Color.Red;
                }
            }
            catch { }
        }
    }
}
