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
    public partial class KullaniciKayitForm : Form
    {
        // Veritabanı bağlantı cümlesi - Diğer formlardaki ile aynı standartta
        // Veritabanı yolu sabitlendi (Veri kaybını önlemek için)
        string baglantiAdresi = SqlBaglanti.Adres;

        public KullaniciKayitForm()
        {
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) || string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Kullanıcı adı ve şifre zorunludur!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Tablo yoksa oluştur (Code-First yaklaşımı benzeri, pratik çözüm)
                KullaniciTablosunuKontrolEt();

                using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                {
                    baglanti.Open();

                    // Kullanıcı adı kontrolü
                    SqlCommand kontrolKomut = new SqlCommand("SELECT COUNT(*) FROM Kullanicilar WHERE KullaniciAdi = @p1", baglanti);
                    kontrolKomut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
                    int varMi = (int)kontrolKomut.ExecuteScalar();

                    if (varMi > 0)
                    {
                        MessageBox.Show("Bu kullanıcı adı zaten alınmış. Lütfen başka bir tane seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Kayıt Ekleme
                    string sorgu = "INSERT INTO Kullanicilar (Ad, Soyad, Cinsiyet, Telefon, KullaniciAdi, Sifre, Rol) VALUES (@Ad, @Soyad, @Cinsiyet, @Telefon, @KullaniciAdi, @Sifre, 'user')";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@Ad", txtAd.Text);
                    komut.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
                    komut.Parameters.AddWithValue("@Cinsiyet", cmbCinsiyet.Text);
                    komut.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                    komut.Parameters.AddWithValue("@KullaniciAdi", txtKullaniciAdi.Text);
                    komut.Parameters.AddWithValue("@Sifre", txtSifre.Text);
                    
                    komut.ExecuteNonQuery();
                    
                    MessageBox.Show("Kayıt başarıyla oluşturuldu! Şimdi giriş yapabilirsiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KullaniciTablosunuKontrolEt()
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
            {
                baglanti.Open();
                // Kullanicilar tablosu var mı kontrol et, yoksa oluştur
                string tabloOlustur = @"
                    IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Kullanicilar' AND xtype='U')
                    CREATE TABLE Kullanicilar (
                        KullaniciId INT PRIMARY KEY IDENTITY(1,1),
                        Ad NVARCHAR(50),
                        Soyad NVARCHAR(50),
                        Cinsiyet NVARCHAR(10),
                        Telefon NVARCHAR(20),
                        KullaniciAdi NVARCHAR(50) UNIQUE,
                        Sifre NVARCHAR(50),
                        Rol NVARCHAR(20)
                    )";
                
                SqlCommand komut = new SqlCommand(tabloOlustur, baglanti);
                komut.ExecuteNonQuery();
            }
        }
    }
}
