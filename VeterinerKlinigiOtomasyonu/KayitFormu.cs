using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace VeterinerKlinigiOtomasyonu
{
    public partial class KayitFormu : XtraForm
    {
        public KayitFormu()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            HayvanModel h = new HayvanModel();
            h.Adi = txtAd.Text;
            h.Tur = txtTur.Text;
            h.Sahibi = txtSahip.Text;
            h.Cinsiyet = cmbCinsiyet.Text;
            
            if (pbResim.Image != null)
            {
                using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
                {
                    pbResim.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); // Veya PNG
                    h.Resim = ms.ToArray();
                }
            }

            this.Tag = h;
            this.DialogResult = DialogResult.OK;
            this.Close();
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
        public void BilgileriYukle(HayvanModel h)
        {
            if (h == null) return;
            
            txtAd.Text = h.Adi;
            txtTur.Text = h.Tur;
            txtSahip.Text = h.Sahibi;
            cmbCinsiyet.Text = h.Cinsiyet;
            
            if (h.Resim != null && h.Resim.Length > 0)
            {
                using (System.IO.MemoryStream ms = new System.IO.MemoryStream(h.Resim))
                {
                    pbResim.Image = System.Drawing.Image.FromStream(ms);
                }
            }
            
            btnKaydet.Text = "GÜNCELLE";
            btnKaydet.Appearance.BackColor = System.Drawing.Color.FromArgb(41, 128, 185); // Blue for Update
            this.Text = "Hasta Kaydı Güncelle";
        }
    }
}