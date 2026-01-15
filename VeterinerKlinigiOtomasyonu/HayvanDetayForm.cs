using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VeterinerKlinigiOtomasyonu
{
    public partial class HayvanDetayForm : DevExpress.XtraEditors.XtraForm
    {
        public int HayvanId { get; set; }
        
        public HayvanDetayForm()
        {
            InitializeComponent();
        }

        private void HayvanDetayForm_Load(object sender, EventArgs e)
        {
            BilgileriYukle();
        }

        void BilgileriYukle()
        {
            if (HayvanId == 0) return;
            try
            {
                using (SqlConnection baglanti = new SqlConnection(SqlBaglanti.Adres))
                {
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Hayvanlar WHERE HayvanId=@p1", baglanti);
                    cmd.Parameters.AddWithValue("@p1", HayvanId);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            txtAd.Text = dr["Ad"].ToString();
                            txtTur.Text = dr["Tur"].ToString();
                            txtCinsi.Text = dr["Cinsi"] != DBNull.Value ? dr["Cinsi"].ToString() : "";
                            txtCinsiyet.Text = dr["Cinsiyet"].ToString();
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
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}
