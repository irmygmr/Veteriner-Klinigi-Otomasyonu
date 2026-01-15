using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace VeterinerKlinigiOtomasyonu
{
    public partial class StokForm : XtraForm
    {
        string baglantiAdresi = SqlBaglanti.Adres;

        public StokForm()
        {
            InitializeComponent();
        }

        private void StokForm_Load(object sender, EventArgs e)
        {
            DbMigrationCheck();
            StokListele();
        }

        void DbMigrationCheck()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(baglantiAdresi))
                {
                    conn.Open();
                    
                    // Check and Add 'Kategori'
                    SqlCommand cmdCheck = new SqlCommand("SELECT COL_LENGTH('Stoklar', 'Kategori')", conn);
                    if (cmdCheck.ExecuteScalar() == DBNull.Value || cmdCheck.ExecuteScalar() == null)
                    {
                        SqlCommand cmdAdd = new SqlCommand("ALTER TABLE Stoklar ADD Kategori NVARCHAR(50)", conn);
                        cmdAdd.ExecuteNonQuery();
                    }

                    // Check and Add 'SonKullanmaTarihi'
                    SqlCommand cmdCheckSKT = new SqlCommand("SELECT COL_LENGTH('Stoklar', 'SonKullanmaTarihi')", conn);
                    if (cmdCheckSKT.ExecuteScalar() == DBNull.Value || cmdCheckSKT.ExecuteScalar() == null)
                    {
                        SqlCommand cmdAddSKT = new SqlCommand("ALTER TABLE Stoklar ADD SonKullanmaTarihi DATE", conn);
                        cmdAddSKT.ExecuteNonQuery();
                    }
                }
            }
            catch { }
        }

        void StokListele()
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                {
                    // Select * fetches everything including StokId
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Stoklar", baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gridControl1.DataSource = dt;
                }
            }
            catch { }
        }

        void Temizle()
        {
            txtUrunAdi.Text = "";
            cmbKategori.Text = "";
            spinMiktar.Value = 0;
            spinKritik.Value = 0;
            dateSKT.EditValue = null;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUrunAdi.Text))
                {
                    MessageBox.Show("Lütfen ürün adını giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(cmbKategori.Text))
                {
                    MessageBox.Show("Lütfen bir kategori seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("INSERT INTO Stoklar (UrunAdi, StokMiktari, KritikSeviye, SonKullanmaTarihi, Kategori) VALUES (@p1, @p2, @p3, @p4, @p5)", baglanti);
                    komut.Parameters.AddWithValue("@p1", txtUrunAdi.Text);
                    komut.Parameters.AddWithValue("@p2", spinMiktar.Value);
                    komut.Parameters.AddWithValue("@p3", spinKritik.Value); 
                    if (dateSKT.EditValue == null)
                        komut.Parameters.AddWithValue("@p4", DBNull.Value);
                    else
                        komut.Parameters.AddWithValue("@p4", dateSKT.DateTime);
                    
                    komut.Parameters.AddWithValue("@p5", cmbKategori.Text);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Stok Eklendi.");
                }
                StokListele();
                Temizle();
            }
            catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(dr == null) return;

            try
            {
                int id = Convert.ToInt32(dr["StokId"]);
                using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("UPDATE Stoklar SET UrunAdi=@p1, StokMiktari=@p2, KritikSeviye=@p3, SonKullanmaTarihi=@p4, Kategori=@p5 WHERE StokId=@p6", baglanti);
                    komut.Parameters.AddWithValue("@p1", txtUrunAdi.Text);
                    komut.Parameters.AddWithValue("@p2", spinMiktar.Value);
                    komut.Parameters.AddWithValue("@p3", spinKritik.Value);
                     if (dateSKT.EditValue == null)
                        komut.Parameters.AddWithValue("@p4", DBNull.Value);
                    else
                        komut.Parameters.AddWithValue("@p4", dateSKT.DateTime);

                    komut.Parameters.AddWithValue("@p5", cmbKategori.Text);
                    komut.Parameters.AddWithValue("@p6", id);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Stok Güncellendi.");
                }
                StokListele();
                Temizle();
            }
            catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr == null) return;

            if (MessageBox.Show("Bu stok kaydını silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt32(dr["StokId"]);
                    using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                    {
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("DELETE FROM Stoklar WHERE StokId=@p1", baglanti);
                        komut.Parameters.AddWithValue("@p1", id);
                        komut.ExecuteNonQuery();
                        MessageBox.Show("Stok Silindi.");
                    }
                    StokListele();
                    Temizle();
                }
                catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtUrunAdi.Text = dr["UrunAdi"].ToString();
                cmbKategori.Text = dr["Kategori"].ToString();
                spinMiktar.Value = Convert.ToDecimal(dr["StokMiktari"]);
                spinKritik.Value = Convert.ToDecimal(dr["KritikSeviye"]);
                if (dr["SonKullanmaTarihi"] != DBNull.Value)
                    dateSKT.DateTime = Convert.ToDateTime(dr["SonKullanmaTarihi"]);
                else
                    dateSKT.EditValue = null;
            }
        }
    }
}
