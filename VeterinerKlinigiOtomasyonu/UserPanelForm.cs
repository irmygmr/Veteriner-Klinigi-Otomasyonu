using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Navigation;
using System.Data.SqlClient;

namespace VeterinerKlinigiOtomasyonu
{
    public partial class UserPanelForm : Form
    {
        public UserPanelForm()
        {
            InitializeComponent();
        }

        private void UserPanelForm_Load(object sender, EventArgs e)
        {
            try { 
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "The Bezier"; 
            }
            catch { }
            
            // Başlangıçta Hoşgeldin ekranı
            ShowWelcome();
            
            // Verileri Yükle
            DashboardVerileriniGetir();
        }

        void ShowWelcome()
        {
             // Tüm formları temizle
             panelContainer.Controls.Clear();
             
             // Dashboard'u geri ekle
             if(tableLayoutPanelDashboard != null)
             {
                 panelContainer.Controls.Add(tableLayoutPanelDashboard);
                 tableLayoutPanelDashboard.Dock = DockStyle.Fill;
                 tableLayoutPanelDashboard.Visible = true;
             }
        }

        // --- DASHBOARD VERİLERİ ---
        private void DashboardVerileriniGetir()
        {
             string aktifKullanici = LoginForm.AktifKullaniciAdi;
             if (string.IsNullOrEmpty(aktifKullanici)) 
             {
                 if(lblGelecekRandevuTarih != null) lblGelecekRandevuTarih.Text = "-";
                 if(lblToplamBorcTutar != null) lblToplamBorcTutar.Text = "0,00 TL";
                 return;
             }

             using (SqlConnection baglanti = new SqlConnection(SqlBaglanti.Adres))
             {
                 try
                 {
                     baglanti.Open();

                     // 1. Kullanıcı Ad Soyadını bul
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

                     // 2. Gelecek Randevu (Query Düzeltildi: Randevular tablosu Join ile Hayvanlar'a bağlanmalı)
                     // Eski kod: SELECT Tarih, Saat ... (Yanlış kolonlar)
                     // Yeni kod: SELECT BaslangicTarihi FROM Randevular ...
                     if (lblGelecekRandevuTarih != null)
                     {
                         try
                         {
                             string randevuQuery = @"
                                 SELECT TOP 1 r.BaslangicTarihi 
                                 FROM Randevular r
                                 INNER JOIN Hayvanlar h ON r.HayvanId = h.HayvanId
                                 WHERE h.Sahibi = @p1 
                                 AND r.BaslangicTarihi > @p2 
                                 ORDER BY r.BaslangicTarihi ASC";

                             SqlCommand cmdRandevu = new SqlCommand(randevuQuery, baglanti);
                             cmdRandevu.Parameters.AddWithValue("@p1", tamAd);
                             cmdRandevu.Parameters.AddWithValue("@p2", DateTime.Now);

                             object resultTarih = cmdRandevu.ExecuteScalar();

                             if (resultTarih != null && resultTarih != DBNull.Value)
                             {
                                 DateTime randevuTarihi = Convert.ToDateTime(resultTarih);
                                 string formattedDate = randevuTarihi.ToShortDateString();
                                 string formattedTime = randevuTarihi.ToString("HH:mm");
                                 
                                 lblGelecekRandevuTarih.Text = formattedDate + "\n" + formattedTime;
                                 lblGelecekRandevuTarih.Appearance.ForeColor = System.Drawing.Color.FromArgb(46, 204, 113); // Yeşil
                             }
                             else
                             {
                                 lblGelecekRandevuTarih.Text = "Yok";
                                 lblGelecekRandevuTarih.Appearance.ForeColor = System.Drawing.Color.Gray;
                             }
                         }
                         catch 
                         { 
                             lblGelecekRandevuTarih.Text = "-"; 
                         }
                     }

                     // 3. Toplam Borç (Güncel Bakiye)
                     if (lblToplamBorcTutar != null)
                     {
                         try 
                         {
                             // Adım 1: Kullanıcının Hayvanlarını Bul
                             string hayvanlarQuery = "SELECT HayvanId FROM Hayvanlar WHERE Sahibi=@p1";
                             SqlCommand cmdHayvanlar = new SqlCommand(hayvanlarQuery, baglanti);
                             cmdHayvanlar.Parameters.AddWithValue("@p1", tamAd);
                             
                             System.Collections.Generic.List<int> hayvanIdleri = new System.Collections.Generic.List<int>();
                             using (SqlDataReader drH = cmdHayvanlar.ExecuteReader())
                             {
                                 while (drH.Read())
                                 {
                                     hayvanIdleri.Add(Convert.ToInt32(drH["HayvanId"]));
                                 }
                             }

                             if (hayvanIdleri.Count == 0)
                             {
                                 // Kullanıcının sistemde kayıtlı hayvanı bulunamadı (Ad soyad eşleşmedi veya hayvanı yok)
                                 lblToplamBorcTutar.Text = "Veri Yok (H)";
                                 lblToplamBorcTutar.ToolTip = "İsimle eşleşen hayvan bulunamadı: " + tamAd;
                                 lblToplamBorcTutar.Appearance.ForeColor = System.Drawing.Color.Gray;
                                 return;
                             }

                             // ID listesini virgüllü stringe çevir
                             string ids = string.Join(",", hayvanIdleri);

                             // Adım 2: Debug - Detaylı Sorgu
                             // Kayıt Sayısı
                             string countQuery = string.Format("SELECT COUNT(*) FROM Kasa WHERE MusteriId IN ({0})", ids);
                             int count = Convert.ToInt32(new SqlCommand(countQuery, baglanti).ExecuteScalar());

                             if (count == 0)
                             {
                                 lblToplamBorcTutar.Text = "Kasa Kaydı Yok";
                                 lblToplamBorcTutar.Appearance.ForeColor = System.Drawing.Color.Gray;
                                 lblToplamBorcTutar.Visible = true;
                                 return;
                             }

                             // Borç Toplamı (Kullanıcı talebi: Sadece Borç toplamı görünsün, tahsilatlar düşülmesin)
                             string qBorc = string.Format(@"
                                SELECT ISNULL(SUM(Tutar),0) 
                                FROM Kasa 
                                WHERE MusteriId IN ({0}) 
                                AND (IslemTipi LIKE '%Borc%' OR IslemTipi LIKE '%Borç%' OR IslemTipi LIKE '%borc%' OR IslemTipi LIKE '%borç%')", ids);
                             
                             decimal sumBorc = 0;
                             object objBorc = new SqlCommand(qBorc, baglanti).ExecuteScalar();
                             if (objBorc != null && objBorc != DBNull.Value) sumBorc = Convert.ToDecimal(objBorc);

                             if (sumBorc > 0)
                             {
                                 lblToplamBorcTutar.Text = string.Format("{0:C2}", sumBorc);
                                 lblToplamBorcTutar.Appearance.ForeColor = System.Drawing.Color.FromArgb(231, 76, 60); // Kırmızı
                             }
                             else
                             {
                                 lblToplamBorcTutar.Text = "0,00 TL"; 
                                 lblToplamBorcTutar.Appearance.ForeColor = System.Drawing.Color.FromArgb(46, 204, 113); // Yeşil
                             }
                             
                             // Tooltip temizle
                             lblToplamBorcTutar.ToolTip = "";
                             lblToplamBorcTutar.Visible = true; 
                         }
                         catch (Exception ex)
                         {
                             lblToplamBorcTutar.Text = "Hata"; 
                             lblToplamBorcTutar.Appearance.ForeColor = System.Drawing.Color.Red;
                         }
                     }
                 }
                 catch (Exception exGenel)
                 {
                     // Genel bağlantı hatası
                     if(lblGelecekRandevuTarih != null) lblGelecekRandevuTarih.Text = "Hata";
                     if(lblToplamBorcTutar != null) lblToplamBorcTutar.Text = "ErrCon";
                     if(lblToplamBorcTutar != null) lblToplamBorcTutar.ToolTip = exGenel.Message;
                 }
             }
        }

        // --- NAVIGASYON (FORM GÖMME) ---
        private void FormGetir(Form frm)
        {
            panelContainer.Controls.Clear(); 
            
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None; 
            frm.Dock = DockStyle.Fill;
            
            panelContainer.Controls.Add(frm);
            frm.Show();
        }

        private void accAnaSayfa_Click(object sender, EventArgs e)
        {
             ShowWelcome();
             DashboardVerileriniGetir();
        }

        private void accProfil_Click(object sender, EventArgs e)
        {
            FormGetir(new ProfilForm());
        }

        private void accHayvanlarim_Click(object sender, EventArgs e)
        {
            FormGetir(new HayvanlarimForm());
        }

        private void accRandevularim_Click(object sender, EventArgs e)
        {
            FormGetir(new RandevularimForm());
        }

        private void accRandevuOlustur_Click(object sender, EventArgs e)
        {
            FormGetir(new RandevuOlusturForm());
        }

        private void accOdeme_Click(object sender, EventArgs e)
        {
            FormGetir(new OdemeBilgileriForm());
        }

        private void accKlinik_Click(object sender, EventArgs e)
        {
            FormGetir(new KlinikBilgileriForm());
        }

        private void accAsilarim_Click(object sender, EventArgs e)
        {
            FormGetir(new AsilarimForm());
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}