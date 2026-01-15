using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VeterinerKlinigiOtomasyonu
{
    public partial class LoginForm : Form
    {
        string baglantiAdresi = SqlBaglanti.Adres;

        public LoginForm()
        {
            InitializeComponent();
        }

        public bool IsVeterinerMode { get; set; } = false; // Default to User

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (IsVeterinerMode)
            {
                // Veteriner Modu
                rbAdmin.Checked = true;
                rbKullanici.Checked = false;
                lblBaslik.Text = "VETERİNER GİRİŞİ";
                
                // Seçim zaten yapıldığı için butonları gizle
                rbAdmin.Visible = false;
                rbKullanici.Visible = false;
                
                // Kayıt Ol butonu gizle (Veteriner admin tarafından eklenir)
                btnKayitOl.Visible = false;
            }
            else
            {
                // Kullanıcı Modu
                rbAdmin.Checked = false;
                rbKullanici.Checked = true;
                lblBaslik.Text = "KULLANICI GİRİŞİ";

                // Seçim zaten yapıldığı için butonları gizle
                rbAdmin.Visible = false;
                rbKullanici.Visible = false;
                
                // Kayıt Ol butonu görünür
                btnKayitOl.Visible = true;
            }
        }

        // Hangi rolle giriş yapıldığını tutar
        public bool IsAdmin { get; private set; } = false;
        
        // Giriş yapan kullanıcının adını tutar (Diğer formlardan erişim için static)
        public static string AktifKullaniciAdi { get; set; } = "";

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // YÖNETİCİ GİRİŞİ
            if (rbAdmin.Checked)
            {
                if (txtKullanici.Text == "admin" && txtSifre.Text == "1234")
                {
                    IsAdmin = true;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Yönetici bilgileri hatalı!", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            // KULLANICI GİRİŞİ
            else
            {
                try
                {
                    using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                    {
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("SELECT * FROM Kullanicilar WHERE KullaniciAdi=@p1 AND Sifre=@p2 AND Rol='user'", baglanti);
                        komut.Parameters.AddWithValue("@p1", txtKullanici.Text);
                        komut.Parameters.AddWithValue("@p2", txtSifre.Text);
                        
                        SqlDataReader dr = komut.ExecuteReader();
                        if (dr.Read())
                        {
                            IsAdmin = false;
                            AktifKullaniciAdi = txtKullanici.Text; // Kullanıcı adını kaydet
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            // Eğer tablo henüz yoksa veya boşsa eski hardcoded girişe izin ver (Fallback)
                            if (txtKullanici.Text == "user" && txtSifre.Text == "1234")
                            {
                                IsAdmin = false;
                                AktifKullaniciAdi = "user"; // Demo kullanıcısı
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    // Hata durumunda (örn. tablo yoksa) yine demo girişe izin verelim ki kullanıcı kitlenmesin
                    if (txtKullanici.Text == "user" && txtSifre.Text == "1234")
                    {
                        IsAdmin = false;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Veritabanı bağlantı hatası veya hatalı giriş.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (DialogResult != DialogResult.OK)
            {
                txtKullanici.Text = "";
                txtSifre.Text = "";
                txtKullanici.Focus();
            }
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            KullaniciKayitForm kayitForm = new KullaniciKayitForm();
            kayitForm.ShowDialog();
        }

        private void lblBaslik_Click(object sender, EventArgs e)
        {

        }

        private void txtKullanici_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
    }

