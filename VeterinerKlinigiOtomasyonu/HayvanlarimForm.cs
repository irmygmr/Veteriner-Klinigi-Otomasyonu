using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VeterinerKlinigiOtomasyonu
{
    public partial class HayvanlarimForm : Form
    {
        string baglantiAdresi = SqlBaglanti.Adres;

        public HayvanlarimForm()
        {
            InitializeComponent();
            this.Load += HayvanlarimForm_Load;
            this.btnKaydet.Click += BtnKaydet_Click;
        }

        private void HayvanlarimForm_Load(object sender, EventArgs e)
        {
            VeritabaniGuncelle();
            HayvanlariYukle();
        }

        void VeritabaniGuncelle()
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                {
                    baglanti.Open();
                    
                    // Yas kolonu kontrolü
                    SqlCommand cmdYas = new SqlCommand("IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Hayvanlar' AND COLUMN_NAME = 'Yas') BEGIN ALTER TABLE Hayvanlar ADD Yas INT END", baglanti);
                    cmdYas.ExecuteNonQuery();

                    // Aciklama kolonu kontrolü
                    SqlCommand cmdAciklama = new SqlCommand("IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Hayvanlar' AND COLUMN_NAME = 'Aciklama') BEGIN ALTER TABLE Hayvanlar ADD Aciklama NVARCHAR(250) END", baglanti);
                    cmdAciklama.ExecuteNonQuery();

                    // Cinsi kolonu kontrolü (YENİ)
                    SqlCommand cmdCinsi = new SqlCommand("IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Hayvanlar' AND COLUMN_NAME = 'Cinsi') BEGIN ALTER TABLE Hayvanlar ADD Cinsi NVARCHAR(50) END", baglanti);
                    cmdCinsi.ExecuteNonQuery();

                    // FOTOĞRAF kolonu kontrolü (YENİ)
                    SqlCommand cmdFoto = new SqlCommand("IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Hayvanlar' AND COLUMN_NAME = 'Fotograf') BEGIN ALTER TABLE Hayvanlar ADD Fotograf VARBINARY(MAX) NULL END", baglanti);
                    cmdFoto.ExecuteNonQuery();
                }
            }
            catch { }
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
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Hayvanlar WHERE Sahibi=@p1", baglanti);
                    da.SelectCommand.Parameters.AddWithValue("@p1", tamAd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    gridHayvanlar.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hayvanlar yüklenirken hata: " + ex.Message);
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(txtAd.Text) || string.IsNullOrEmpty(cmbTur.Text))
                {
                    MessageBox.Show("Lütfen Hayvan Adı ve Türünü giriniz.");
                    return;
                }

                string aktifKullanici = LoginForm.AktifKullaniciAdi;
                using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                {
                    baglanti.Open();

                    // Sahibi Bul
                    SqlCommand kmtUser = new SqlCommand("SELECT Ad, Soyad FROM Kullanicilar WHERE KullaniciAdi=@p1", baglanti);
                    kmtUser.Parameters.AddWithValue("@p1", aktifKullanici);
                    string sahipAd = "";
                    using (SqlDataReader dr = kmtUser.ExecuteReader())
                    {
                        if (dr.Read()) sahipAd = dr["Ad"].ToString() + " " + dr["Soyad"].ToString();
                    }

                    if (string.IsNullOrEmpty(sahipAd))
                    {
                        MessageBox.Show("Kullanıcı bilgisi bulunamadı.");
                        return;
                    }

                    SqlCommand komut = new SqlCommand("INSERT INTO Hayvanlar (Ad, Tur, Cinsi, Cinsiyet, Yas, Aciklama, Sahibi, Fotograf) VALUES (@p1, @p2, @p7, @p3, @p4, @p5, @p6, @p8)", baglanti);
                    komut.Parameters.AddWithValue("@p1", txtAd.Text);
                    komut.Parameters.AddWithValue("@p2", cmbTur.Text);
                    komut.Parameters.AddWithValue("@p7", txtCinsi.Text);
                    komut.Parameters.AddWithValue("@p3", cmbCinsiyet.Text);
                    komut.Parameters.AddWithValue("@p4", Convert.ToInt32(txtYas.Value));
                    komut.Parameters.AddWithValue("@p5", memoNot.Text);
                    komut.Parameters.AddWithValue("@p6", sahipAd);
                    
                    if (pbResim.Image != null)
                    {
                        using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
                        {
                            pbResim.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            komut.Parameters.AddWithValue("@p8", ms.ToArray());
                        }
                    }
                    else
                    {
                        komut.Parameters.AddWithValue("@p8", DBNull.Value);
                    }

                    komut.ExecuteNonQuery();

                    MessageBox.Show("Hayvan başarıyla kaydedildi!");
                    HayvanlariYukle();
                    
                    // Temizle
                    Temizle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaydetme hatası: " + ex.Message);
            }
        }

        // Seçili hayvanın ID'sini tutmak için
        int seciliHayvanId = 0;

        private void gridHayvanlar_Click(object sender, EventArgs e)
        {
            DataRow dr = null;
            if (layoutView1.FocusedRowHandle >= 0)
            {
                dr = layoutView1.GetDataRow(layoutView1.FocusedRowHandle);
            }

            if (dr != null)
            {
                // Önce form üzerindeki alanları doldur (edit için)
                seciliHayvanId = Convert.ToInt32(dr["HayvanId"]);
                txtAd.Text = dr["Ad"].ToString();
                cmbTur.Text = dr["Tur"].ToString();
                txtCinsi.Text = dr["Cinsi"] != DBNull.Value ? dr["Cinsi"].ToString() : "";
                cmbCinsiyet.Text = dr["Cinsiyet"].ToString();
                txtYas.Text = dr["Yas"].ToString();
                memoNot.Text = dr["Aciklama"].ToString();
                
                if (dr["Fotograf"] != DBNull.Value)
                {
                    byte[] resim = (byte[])dr["Fotograf"];
                    using (System.IO.MemoryStream ms = new System.IO.MemoryStream(resim))
                    {
                        pbResim.Image = System.Drawing.Image.FromStream(ms);
                    }
                }
                else
                {
                    pbResim.Image = null;
                }

                // AYRICA DETAY FORMUNU AÇ
                HayvanDetayForm detayForm = new HayvanDetayForm();
                detayForm.HayvanId = seciliHayvanId;
                detayForm.ShowDialog();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliHayvanId == 0)
            {
                MessageBox.Show("Lütfen listeden güncellenecek bir hayvan seçin.");
                return;
            }

            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                {
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Hayvanlar SET Ad=@p1, Tur=@p2, Cinsi=@p7, Cinsiyet=@p3, Yas=@p4, Aciklama=@p5, Fotograf=@p8 WHERE HayvanId=@p6", baglanti);
                    cmd.Parameters.AddWithValue("@p1", txtAd.Text);
                    cmd.Parameters.AddWithValue("@p2", cmbTur.Text);
                    cmd.Parameters.AddWithValue("@p7", txtCinsi.Text);
                    cmd.Parameters.AddWithValue("@p3", cmbCinsiyet.Text);
                    cmd.Parameters.AddWithValue("@p4", Convert.ToInt32(txtYas.Value));
                    cmd.Parameters.AddWithValue("@p5", memoNot.Text);
                    cmd.Parameters.AddWithValue("@p6", seciliHayvanId);

                    if (pbResim.Image != null)
                    {
                        using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
                        {
                            pbResim.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            cmd.Parameters.AddWithValue("@p8", ms.ToArray());
                        }
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@p8", DBNull.Value);
                    }

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Hayvan bilgileri güncellendi.");
                HayvanlariYukle();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme hatası: " + ex.Message);
            }
        }

        public void repoBtnSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            // Layout view ile silme işlemi farklı olabilir, şimdilik basit tutuyoruz.
            DataRow dr = layoutView1.GetDataRow(layoutView1.FocusedRowHandle);
            if (dr != null)
            {
                if (DialogResult.Yes == MessageBox.Show("Bu hayvan kaydını silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    try
                    {
                        int id = Convert.ToInt32(dr["HayvanId"]);
                        using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                        {
                            baglanti.Open();
                            SqlCommand cmd = new SqlCommand("DELETE FROM Hayvanlar WHERE HayvanId=@p1", baglanti);
                            cmd.Parameters.AddWithValue("@p1", id);
                            cmd.ExecuteNonQuery();
                        }
                        HayvanlariYukle();
                        Temizle();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Silme hatası: " + ex.Message);
                    }
                }
            }
        }

        void Temizle()
        {
            txtAd.Text = "";
            cmbTur.SelectedIndex = -1;
            txtCinsi.Text = "";
            cmbCinsiyet.SelectedIndex = -1;
            txtYas.Value = 0;
            memoNot.Text = "";
            seciliHayvanId = 0;
            pbResim.Image = null;
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbResim.Image = System.Drawing.Image.FromFile(ofd.FileName);
            }
        }
    }
}
