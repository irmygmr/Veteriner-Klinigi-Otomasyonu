using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using System.Data.SqlClient;

namespace VeterinerKlinigiOtomasyonu
{
    public partial class ProfilForm : Form
    {
        // Veritabanı bağlantısı
        string baglantiAdresi = SqlBaglanti.Adres;

        public ProfilForm()
        {
            InitializeComponent();
            KullaniciBilgileriniYukle();
        }

        private void KullaniciBilgileriniYukle()
        {
            try
            {
                // Giriş yapmış kullanıcının adını al
                string aktifKullanici = LoginForm.AktifKullaniciAdi;
                if (string.IsNullOrEmpty(aktifKullanici)) return;

                using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                {
                    baglanti.Open();
                    // 1. Kullanıcı bilgilerini çek
                    SqlCommand komut = new SqlCommand("SELECT * FROM Kullanicilar WHERE KullaniciAdi=@p1", baglanti);
                    komut.Parameters.AddWithValue("@p1", aktifKullanici);
                    
                    string tamAd = "";

                    using (SqlDataReader dr = komut.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            txtAd.Text = dr["Ad"].ToString();
                            txtSoyad.Text = dr["Soyad"].ToString();
                            cmbCinsiyet.Text = dr["Cinsiyet"].ToString();
                            txtTelefon.Text = dr["Telefon"].ToString();
                            
                            // Hayvanları aramak için tam adı oluştur
                            tamAd = txtAd.Text + " " + txtSoyad.Text;
                        }
                    }

                    // 2. Sahip olduğu hayvanları çek (İsme göre eşleştirme - İleride ID ile yapılmalı)
                    if (!string.IsNullOrEmpty(tamAd))
                    {
                        SqlCommand hayvanKomut = new SqlCommand("SELECT Ad as 'Hayvan Adı', Tur, Cinsiyet FROM Hayvanlar WHERE Sahibi=@sahip", baglanti);
                        hayvanKomut.Parameters.AddWithValue("@sahip", tamAd);
                        
                        SqlDataAdapter da = new SqlDataAdapter(hayvanKomut);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        gridHayvanlar.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Profil bilgileri yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHayvanEkle_Click(object sender, EventArgs e)
        {
            // Kayıt formunu aç
            KayitFormu frm = new KayitFormu();
            // Form başlığını değiştir ki anlaşılsın (Opsiyonel)
            frm.Text = "Yeni Hayvan Ekle";

            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (frm.Tag is HayvanModel h)
                {
                    try
                    {
                        // Sahip adını şu anki kullanıcıdan alıyoruz (Otomatik)
                        string sahipAdi = txtAd.Text + " " + txtSoyad.Text;

                        using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                        {
                            baglanti.Open();
                            string sorgu = "INSERT INTO Hayvanlar (Ad, Tur, Sahibi, Cinsiyet) VALUES (@p1, @p2, @p3, @p4)";
                            SqlCommand komut = new SqlCommand(sorgu, baglanti);
                            komut.Parameters.AddWithValue("@p1", h.Adi);
                            komut.Parameters.AddWithValue("@p2", h.Tur);
                            komut.Parameters.AddWithValue("@p3", sahipAdi); // Otomatik sahip
                            komut.Parameters.AddWithValue("@p4", h.Cinsiyet);
                            
                            komut.ExecuteNonQuery();
                        }
                        
                        MessageBox.Show("Hayvanınız başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        // Listeyi yenile
                        KullaniciBilgileriniYukle();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ekleme hatası: " + ex.Message);
                    }
                }
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                string aktifKullanici = LoginForm.AktifKullaniciAdi;
                if (string.IsNullOrEmpty(aktifKullanici)) return;

                using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                {
                    baglanti.Open();
                    string updateQuery = "UPDATE Kullanicilar SET Ad=@p1, Soyad=@p2, Cinsiyet=@p3, Telefon=@p4 WHERE KullaniciAdi=@pUser";
                    SqlCommand cmd = new SqlCommand(updateQuery, baglanti);
                    cmd.Parameters.AddWithValue("@p1", txtAd.Text);
                    cmd.Parameters.AddWithValue("@p2", txtSoyad.Text);
                    cmd.Parameters.AddWithValue("@p3", cmbCinsiyet.Text);
                    cmd.Parameters.AddWithValue("@p4", txtTelefon.Text);
                    cmd.Parameters.AddWithValue("@pUser", aktifKullanici);
                    
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Bilgileriniz başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    // Yeniden yüklemeye gerek yok ama emin olmak için:
                    // KullaniciBilgileriniYukle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
