using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace VeterinerKlinigiOtomasyonu
{
    public partial class DashboardForm : XtraForm
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            // Tarih ve Gün Bilgisini Yazdır
            // Örnek: 1 Ocak 2026, Perşembe
            lblDate.Text = DateTime.Now.ToString("D");
        }

        private void lblBrand_Click(object sender, EventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}
