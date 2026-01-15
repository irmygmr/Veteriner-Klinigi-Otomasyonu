using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace VeterinerKlinigiOtomasyonu
{
    public partial class RandevuOlusturForm : Form
    {
        string baglantiAdresi = SqlBaglanti.Adres;
        string secilenSaat = "";
        SimpleButton btnSecilen = null;

        public RandevuOlusturForm()
        {
            InitializeComponent();
            this.Load += RandevuOlusturForm_Load;
            dtTarih.EditValueChanged += DtTarih_EditValueChanged;
            btnRandevuOlustur.Click += BtnRandevuOlustur_Click;

            // Saat butonlarına tıklama olayı ekle
            foreach (Control ctrl in flowSaatler.Controls)
            {
                if (ctrl is SimpleButton btn)
                {
                    btn.Click += SaatButonu_Click;
                }
            }
        }

        private void RandevuOlusturForm_Load(object sender, EventArgs e)
        {
            HayvanlariYukle();
            dtTarih.DateTime = DateTime.Today; // Varsayılan bugün
            dtTarih.Properties.MinValue = DateTime.Today; // Geçmiş tarih engeli
        }

        void HayvanlariYukle()
        {
            try
            {
                string aktifKullanici = LoginForm.AktifKullaniciAdi;
                if (string.IsNullOrEmpty(aktifKullanici)) return;

                using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                {
                    baglanti.Open();

                    // Kullanıcı adından tam adı bul
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

                    // Hayvanları yükle
                    SqlDataAdapter da = new SqlDataAdapter("SELECT HayvanId, Ad FROM Hayvanlar WHERE Sahibi=@p1", baglanti);
                    da.SelectCommand.Parameters.AddWithValue("@p1", tamAd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    lookUpHayvan.Properties.ValueMember = "HayvanId";
                    lookUpHayvan.Properties.DisplayMember = "Ad";
                    lookUpHayvan.Properties.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hayvanlar yüklenirken hata: " + ex.Message);
            }
        }

        private void DtTarih_EditValueChanged(object sender, EventArgs e)
        {
            SaatleriGuncelle();
        }

        void SaatleriGuncelle()
        {
            secilenSaat = "";
            btnSecilen = null;
            DateTime tarih = dtTarih.DateTime.Date;

            // Önce hepsini yeşil (müsait) yap
            foreach (Control ctrl in flowSaatler.Controls)
            {
                if (ctrl is SimpleButton btn)
                {
                    btn.Appearance.BackColor = Color.LightGreen;
                    btn.Enabled = true;
                }
            }

            // Eğer bugün seçiliyse geçmiş saatleri pasif yap
            if (tarih == DateTime.Today)
            {
                TimeSpan suAn = DateTime.Now.TimeOfDay;
                foreach (Control ctrl in flowSaatler.Controls)
                {
                    if (ctrl is SimpleButton btn)
                    {
                        // btn.Text formatı "09:00" şeklinde varsayıyoruz
                        if (TimeSpan.TryParse(btn.Text, out TimeSpan butonSaat))
                        {
                            // Eğer buton saati şu andan küçükse pasif yap
                            if (butonSaat < suAn)
                            {
                                btn.Appearance.BackColor = Color.LightGray;
                                btn.Enabled = false;
                            }
                        }
                    }
                }
            }

            // Dolu saatleri veritabanından çek
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                {
                    baglanti.Open();
                    // Randevu tarihini Saat bilgisi dahil kaydetmiştik (veya ayrı olabilir)
                    // Not: Mevcut yapıda 'BaslangicTarihi' datetime. Yani hem tarih hem saat var.
                    // Bu yüzden gün bazında sorgulayıp saatleri karşılaştıracağız.
                    
                    SqlCommand komut = new SqlCommand("SELECT BaslangicTarihi FROM Randevular", baglanti);
                    SqlDataReader dr = komut.ExecuteReader();
                    while (dr.Read())
                    {
                        DateTime dbTarih = Convert.ToDateTime(dr["BaslangicTarihi"]);
                        if (dbTarih.Date == tarih)
                        {
                            string doluSaat = dbTarih.ToString("HH:mm");
                            // Butonu bul ve kırmızı yap
                            foreach (Control ctrl in flowSaatler.Controls)
                            {
                                if (ctrl is SimpleButton btn && btn.Text == doluSaat)
                                {
                                    btn.Appearance.BackColor = Color.IndianRed;
                                    btn.Enabled = false; // Tıklanamaz
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Saat bilgileri çekilemedi: " + ex.Message);
            }
        }

        private void SaatButonu_Click(object sender, EventArgs e)
        {
            SimpleButton tiklanan = sender as SimpleButton;
            if (tiklanan == null) return;

            // Önceki seçimi temizle (Eğer kırmızı değilse yeşile dön)
            if (btnSecilen != null && btnSecilen.Appearance.BackColor != Color.IndianRed)
            {
                btnSecilen.Appearance.BackColor = Color.LightGreen;
            }

            // Yeni seçimi turuncu yap
            secilenSaat = tiklanan.Text;
            btnSecilen = tiklanan;
            tiklanan.Appearance.BackColor = Color.Orange;
        }

        private void BtnRandevuOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtTarih.EditValue == null)
                {
                    MessageBox.Show("Lütfen tarih seçiniz.");
                    return;
                }
                if (string.IsNullOrEmpty(secilenSaat))
                {
                    MessageBox.Show("Lütfen bir saat seçiniz.");
                    return;
                }
                if (lookUpHayvan.EditValue == null)
                {
                    MessageBox.Show("Lütfen hayvan seçiniz.");
                    return;
                }

                // Tarih ve saati birleştir
                DateTime randevuZamani = dtTarih.DateTime.Date + TimeSpan.Parse(secilenSaat);

                using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("INSERT INTO Randevular (BaslangicTarihi, HayvanId, Aciklama) VALUES (@p1, @p2, @p3)", baglanti);
                    komut.Parameters.AddWithValue("@p1", randevuZamani);
                    komut.Parameters.AddWithValue("@p2", lookUpHayvan.EditValue);
                    string aciklama = string.IsNullOrEmpty(txtAciklama.Text) ? "Kullanıcı Randevusu" : txtAciklama.Text;
                    komut.Parameters.AddWithValue("@p3", aciklama);
                    komut.ExecuteNonQuery();
                    
                    MessageBox.Show("Randevunuz oluşturuldu!");
                    this.Close(); // Formu kapat
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Randevu oluşturulurken hata: " + ex.Message);
            }
        }
    }
}
