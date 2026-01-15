using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace VeterinerKlinigiOtomasyonu
{
    public partial class AsilarimForm : DevExpress.XtraEditors.XtraForm
    {
        string baglantiAdresi = SqlBaglanti.Adres;

        public AsilarimForm()
        {
            InitializeComponent();
        }

        private void AsilarimForm_Load(object sender, EventArgs e)
        {
            AsilariYukle();
        }

        void AsilariYukle()
        {
            try
            {
                string aktifKullanici = LoginForm.AktifKullaniciAdi;
                if (string.IsNullOrEmpty(aktifKullanici)) return;

                using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                {
                    baglanti.Open();

                    // 1. Kullanıcı Tam Adı
                    SqlCommand cmdUser = new SqlCommand("SELECT Ad, Soyad FROM Kullanicilar WHERE KullaniciAdi=@p1", baglanti);
                    cmdUser.Parameters.AddWithValue("@p1", aktifKullanici);
                    
                    string tamAd = "";
                    using (SqlDataReader dr = cmdUser.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            tamAd = dr["Ad"].ToString() + " " + dr["Soyad"].ToString();
                        }
                    }

                    if (string.IsNullOrEmpty(tamAd)) return;

                    // 2. Tüm Aşıları Çek
                    string query = @"SELECT h.Ad as HayvanAdi, a.AsiAdi, 
                                     ISNULL(a.GelecekAsiTarihi, a.YapilmaTarihi) as Tarih,
                                     CASE 
                                        WHEN a.YapilmaTarihi IS NOT NULL THEN 'Yapıldı'
                                        WHEN a.GelecekAsiTarihi < GETDATE() THEN 'Zamanı Geçti'
                                        WHEN DATEDIFF(day, GETDATE(), a.GelecekAsiTarihi) <= 7 THEN 'Yaklaşıyor'
                                        ELSE 'Planlandı'
                                     END as Durum,
                                     a.GelecekAsiTarihi
                                     FROM Asilar a
                                     INNER JOIN Hayvanlar h ON a.HayvanId = h.HayvanId
                                     WHERE h.Sahibi = @p1";

                    SqlDataAdapter da = new SqlDataAdapter(query, baglanti);
                    da.SelectCommand.Parameters.AddWithValue("@p1", tamAd);
                    
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // 3. Aktif ve Geçmiş olarak ayır
                    // Aktif: GelecekAsiTarihi >= Bugün veya (GelecekAsiTarihi < Bugün ama YapilmaTarihi NULL - yani kaçırılmış/zamanı geçmiş ama hala aktif bir görev)
                    // Geçmiş: YapilmaTarihi dolu olanlar (Tamamlanmış)
                    // VEYA Kullanıcı isteğine göre: Gelecek = Tarihi >= Bugün, Geçmiş = Tarihi < Bugün

                    // YAKLAŞIM:
                    // Aktif/Gelecek Sekmesi: Henüz tarihi gelmemiş veya tarihi geçmiş ama yapılmamış (Unutulmuş) aşılar.
                    // Geçmiş Sekmesi: Yapılmış (Tamamlanmış) aşılar veya tarihi çoktan geçmiş aşılar listesi.
                    
                    // Basit Ayrım:
                    // Aktif: Tarihi >= Bugün (Gelecek)
                    // Geçmiş: Tarihi < Bugün

                    DataTable dtAktif = dt.Clone();
                    DataTable dtGecmis = dt.Clone();

                    foreach (DataRow row in dt.Rows)
                    {
                        DateTime tarih = Convert.ToDateTime(row["Tarih"]);
                        string durum = row["Durum"].ToString();

                        // Eğer yapıldıysa kesinlikle geçmişe at
                        if (durum == "Yapıldı")
                        {
                            dtGecmis.ImportRow(row);
                        }
                        else
                        {
                            // Yapılmadıysa tarihe bak
                            if (tarih >= DateTime.Today)
                            {
                                dtAktif.ImportRow(row); // Gelecek
                            }
                            else
                            {
                                // Tarihi geçmiş ve yapılmamış -> Bunu kullanıcıya Aktif sekmesinde "Zamanı Geçti" olarak göstermek daha mantıklı olabilir ki görsün.
                                // Ancak kullanıcının isteği "Geçmiş" ve "Aktif" ayrımı genelde "Tamamlananlar" ve "Bekleyenler" gibidir.
                                // Biz burada Tarih bazlı ayıralım.
                                dtAktif.ImportRow(row); // Zamanı geçti uyarısı ile Aktif'te kalsın ki gözden kaçmasın.
                            }
                        }
                    }
                     
                    // İnce ayar: Sadece "Yapıldı" olanları Geçmişe atalım, geri kalan her şey görevdir (Aktif).
                    // Aslında yukarıdaki döngüde ufak bir mantık hatası olabilir, düzelteyim:
                    
                    dtAktif.Rows.Clear();
                    dtGecmis.Rows.Clear();
                    
                    foreach (DataRow row in dt.Rows)
                    {
                         string durum = row["Durum"].ToString();
                         if (durum == "Yapıldı")
                         {
                             dtGecmis.ImportRow(row);
                         }
                         else
                         {
                             dtAktif.ImportRow(row);
                         }
                    }

                    // Gridlere Bağla
                    gridAktif.DataSource = dtAktif;
                    gridGecmis.DataSource = dtGecmis;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aşı bilgileri yüklenirken hata oluştu: " + ex.Message);
            }
        }
    }
}
