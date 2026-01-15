using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace VeterinerKlinigiOtomasyonu
{
    public partial class AsiForm : XtraForm
    {
        string baglantiAdresi = SqlBaglanti.Adres;

        public AsiForm()
        {
            InitializeComponent();
        }

        private void AsiForm_Load(object sender, EventArgs e)
        {
            Listele();
            AsilariListele();
        }

        void Listele()
        {
             // Hayvan seçimi için liste
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                {
                    baglanti.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT HayvanId, Ad, Tur, Sahibi FROM Hayvanlar", baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gridControl4.DataSource = dt;
                }
            }
            catch { }
        }

        void AsilariListele()
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                {
                    string query = @"SELECT a.AsiId, h.Ad as HayvanAdi, a.AsiAdi, 
                                     ISNULL(a.YapilmaTarihi, a.GelecekAsiTarihi) as Tarih,
                                     CASE 
                                        WHEN a.YapilmaTarihi IS NOT NULL THEN 'Yapıldı' 
                                        ELSE 'Gelecek Aşı' 
                                     END as Durum
                                     FROM Asilar a 
                                     INNER JOIN Hayvanlar h ON a.HayvanId = h.HayvanId 
                                     ORDER BY a.GelecekAsiTarihi ASC";
                    SqlDataAdapter da = new SqlDataAdapter(query, baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gridControl3.DataSource = dt;
                }
            }
            catch { }
        }

        private void btnAsiKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtAsiAdi.Text))
                {
                     MessageBox.Show("Lütfen aşı adını giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     return;
                }
                int seciliHayvanId = (int)gridView4.GetFocusedRowCellValue("HayvanId");
                using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("INSERT INTO Asilar (HayvanId, AsiAdi, YapilmaTarihi, GelecekAsiTarihi) VALUES (@p1, @p2, @p3, @p4)", baglanti);
                    komut.Parameters.AddWithValue("@p1", seciliHayvanId);
                    komut.Parameters.AddWithValue("@p2", txtAsiAdi.Text);
                    
                    if (dateYapilma.EditValue == null)
                        komut.Parameters.AddWithValue("@p3", DBNull.Value);
                    else
                        komut.Parameters.AddWithValue("@p3", dateYapilma.DateTime);

                    if (dateGelecek.EditValue == null)
                        komut.Parameters.AddWithValue("@p4", DBNull.Value);
                    else
                        komut.Parameters.AddWithValue("@p4", dateGelecek.DateTime);

                    komut.ExecuteNonQuery();
                    MessageBox.Show("Aşı eklendi.");
                }
                AsilariListele();
            }
            catch { MessageBox.Show("Listeden hayvan seçiniz."); }
        }

        private void repoBtnOnayla_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
             DataRow dr = gridView5.GetDataRow(gridView5.FocusedRowHandle);
             if (dr != null)
             {
                 string durum = dr["Durum"].ToString();
                 if (durum == "Yapıldı")
                 {
                     MessageBox.Show("Bu aşı zaten yapılmış.");
                     return;
                 }

                 if (DialogResult.Yes == MessageBox.Show("Aşının yapıldığını onaylıyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                 {
                     try
                     {
                         int asiId = Convert.ToInt32(dr["AsiId"]);
                         using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                         {
                             baglanti.Open();
                             // Yapilma Tarihini BUGÜN olarak güncelle, Gelecek Tarihi NULL yap (veya kalsın, mantığa göre)
                             // Kullanıcının isteği: "onaylarsa o aşının durumu da yapıldı olsun" -> YapilmaTarihi IS NOT NULL olmalı.
                             SqlCommand cmd = new SqlCommand("UPDATE Asilar SET YapilmaTarihi=@p1 WHERE AsiId=@p2", baglanti);
                             cmd.Parameters.AddWithValue("@p1", DateTime.Now);
                             cmd.Parameters.AddWithValue("@p2", asiId);
                             cmd.ExecuteNonQuery();
                         }
                         MessageBox.Show("Aşı durumu güncellendi.");
                         AsilariListele(); // Listeyi yenile
                     }
                     catch (Exception ex)
                     {
                         MessageBox.Show("Hata: " + ex.Message);
                     }
                 }
             }
        }

        private void gridView5_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string durum = view.GetRowCellDisplayText(e.RowHandle, colDurum).Trim();
                if (durum == "Yapıldı")
                {
                    e.Appearance.BackColor = System.Drawing.Color.LightGreen;
                    e.Appearance.BackColor2 = System.Drawing.Color.LightGreen;
                    e.Appearance.Options.UseBackColor = true;
                }
                else if (durum == "Gelecek Aşı")
                {
                     e.Appearance.BackColor = System.Drawing.Color.LightYellow;
                     e.Appearance.BackColor2 = System.Drawing.Color.LightYellow;
                     e.Appearance.Options.UseBackColor = true;
                }
            }
        }
    }
}
