using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace VeterinerKlinigiOtomasyonu
{
    public partial class GirisSecimForm : XtraForm
    {
        public bool IsVeterinerSelected { get; private set; } = false;

        public GirisSecimForm()
        {
            InitializeComponent();
            this.btnVeteriner.Click += BtnVeteriner_Click;
            this.btnKullanici.Click += BtnKullanici_Click;
        }

        private void BtnVeteriner_Click(object sender, EventArgs e)
        {
            IsVeterinerSelected = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnKullanici_Click(object sender, EventArgs e)
        {
            IsVeterinerSelected = false;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void lblHosgeldiniz_Click(object sender, EventArgs e)
        {

        }

        private void lblBaslik_Click(object sender, EventArgs e)
        {

        }
    }
}
