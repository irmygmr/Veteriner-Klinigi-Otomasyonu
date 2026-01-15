using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace VeterinerKlinigiOtomasyonu
{
    public partial class UserDashboardForm : Form
    {
        string baglantiAdresi = SqlBaglanti.Adres;

        public UserDashboardForm()
        {
            InitializeComponent();
        }

        private void UserDashboardForm_Load(object sender, EventArgs e)
        {
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

                    // 1. Kullanıcıyı Bul
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

                    // 2. Gelecek Randevu
                    SqlCommand cmdRandevu = new SqlCommand(@"
                        SELECT TOP 1 r.BaslangicTarihi, h.Ad as HayvanAdi, r.Aciklama 
                        FROM Randevular r 
                        JOIN Hayvanlar h ON r.HayvanId = h.HayvanId 
                        WHERE h.Sahibi = @sahip AND r.BaslangicTarihi >= GETDATE() 
                        ORDER BY r.BaslangicTarihi ASC", baglanti);
                    cmdRandevu.Parameters.AddWithValue("@sahip", tamAd);

                    using (SqlDataReader dr = cmdRandevu.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            DateTime tarih = Convert.ToDateTime(dr["BaslangicTarihi"]);
                            string hayvan = dr["HayvanAdi"].ToString();
                            
                            lblRandevuTarih.Text = tarih.ToString("dd MMMM\nHH:mm");
                            lblRandevuDetay.Text = string.Format("{0} için randevunuz var.", hayvan);
                            lblRandevuTarih.Appearance.ForeColor = System.Drawing.Color.FromArgb(52, 152, 219); // Mavi
                        }
                        else
                        {
                            lblRandevuTarih.Text = "-";
                            lblRandevuDetay.Text = "Planlanmış randevunuz bulunmamaktadır.";
                            lblRandevuTarih.Appearance.ForeColor = System.Drawing.Color.Gray;
                        }
                    }

                    // 3. Borç Hesaplama
                    string hayvanIdsQuery = "SELECT HayvanId FROM Hayvanlar WHERE Sahibi=@p1";
                    string kasaIdKolonu = "Id"; // Varsayılan

                    // Kasa Id Kolonunu Bul (Güvenlik Önlemi)
                    SqlCommand cmdIdFind = new SqlCommand("SELECT name FROM sys.identity_columns WHERE object_id = OBJECT_ID('Kasa')", baglanti);
                    object resultId = cmdIdFind.ExecuteScalar();
                    if (resultId != null) kasaIdKolonu = resultId.ToString();

                    string queryKasa = @"SELECT IslemTipi, Tutar FROM Kasa WHERE MusteriId IN (" + hayvanIdsQuery + ")";
                    
                    SqlCommand cmdKasa = new SqlCommand(queryKasa, baglanti);
                    cmdKasa.Parameters.AddWithValue("@p1", tamAd);

                    decimal toplamBorc = 0;
                    decimal toplamOdenen = 0;

                    using (SqlDataReader dr = cmdKasa.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            string tip = dr["IslemTipi"].ToString().ToLower(new System.Globalization.CultureInfo("tr-TR"));
                            decimal tutar = dr["Tutar"] != DBNull.Value ? Convert.ToDecimal(dr["Tutar"]) : 0;

                            if (tip.Contains("borc") || tip.Contains("borç"))
                                toplamBorc += tutar;
                            else if (tip.Contains("tahsilat") || tip.Contains("ödeme") || tip.Contains("odeme"))
                                toplamOdenen += tutar;
                        }
                    }

                    // Borç gösterimi (Kullanıcı panelinde sadece Toplam Borç gösterilir, ödenen düşülmez çünkü 'Kalan Borç' mantığı veritabanı yapısında net değilse kafa karıştırabilir.
                    // Ancak OdemeBilgileriForm'da ne yaptıysak aynısını yapalım: Orada sadece Borçlar toplanmıştı (guncelBorc = toplamBorc). 
                    // Fakat OdemeBilgileriForm'da "IslemTipi" ne göre süzdüğümüzde, ödenenleri "Tahsilat" olarak INSERT ediyorsak, o zaman toplam borç = Borç - Tahsilat olmalı mı?
                    // OdemeBilgileriForm koduna baktım: "decimal guncelBorc = toplamBorc;" diyor. Yani tahsilatları DÜŞMÜYOR.
                    // Demek ki sistemde "Borç silinmiyor", sadece statüsü değişiyor (Update IslemTipi='Tahsilat').
                    // EVET! OdemeBilgileriForm line 184: "UPDATE Kasa SET IslemTipi='Tahsilat'..."
                    // Bu durumda 'Tahsilat' olanlar artık 'Borc' sayılmıyor. Yani sadece 'Borc' tipli olanları toplamak yeterli.
                    // Zekice. Tahsilatları toplamaya gerek yok.

                    decimal guncelBorc = toplamBorc;

                    if (guncelBorc > 0)
                    {
                        lblBorcTutar.Text = string.Format("{0:C2}", guncelBorc);
                        lblBorcTutar.Appearance.ForeColor = System.Drawing.Color.FromArgb(231, 76, 60); // Kırmızı
                    }
                    else
                    {
                        lblBorcTutar.Text = "0,00 ₺";
                        lblBorcTutar.Appearance.ForeColor = System.Drawing.Color.FromArgb(46, 204, 113); // Yeşil
                    }
                }
            }
            catch (Exception ex)
            {
                lblRandevuDetay.Text = "Hata oluştu.";
                lblBorcBaslik.Text = "Hata";
            }
        }
    }
}
