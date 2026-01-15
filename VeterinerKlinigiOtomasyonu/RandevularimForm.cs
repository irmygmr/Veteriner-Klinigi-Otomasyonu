using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Drawing;

namespace VeterinerKlinigiOtomasyonu
{
    public partial class RandevularimForm : Form
    {
        string baglantiAdresi = SqlBaglanti.Adres;

        public RandevularimForm()
        {
            InitializeComponent();
        }

        private void RandevularimForm_Load(object sender, EventArgs e)
        {
            VeritabaniKontrol();
            RandevulariYukle();

            viewAktif.RowStyle += ViewAktif_RowStyle;
            viewGecmis.RowStyle += ViewGecmis_RowStyle;
        }

        void VeritabaniKontrol()
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                {
                    baglanti.Open();
                    // Admin panelinde zaten yapılıyor ama user tarafında da garanti olsun
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Randevular' AND COLUMN_NAME = 'Durum'", baglanti);
                    int varMi = (int)cmd.ExecuteScalar();
                    if (varMi == 0)
                    {
                        SqlCommand cmdAdd = new SqlCommand("ALTER TABLE Randevular ADD Durum NVARCHAR(50) DEFAULT 'Aktif'", baglanti);
                        cmdAdd.ExecuteNonQuery();
                    }
                }
            }
            catch { }
        }

        void RandevulariYukle()
        {
            try
            {
                string aktifKullanici = LoginForm.AktifKullaniciAdi;
                if (string.IsNullOrEmpty(aktifKullanici)) return;

                using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                {
                    baglanti.Open();

                    // 1. Önce kullanıcının adını soyadını bulalım
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

                    // 2. Randevuları çek
                    string sorgu = @"
                        SELECT 
                            r.Id, 
                            h.Ad as 'Hayvan', 
                            r.BaslangicTarihi as 'Tarih', 
                            r.Aciklama,
                            ISNULL(r.Durum, 'Aktif') as 'Durum'
                        FROM Randevular r 
                        JOIN Hayvanlar h ON r.HayvanId = h.HayvanId 
                        WHERE h.Sahibi = @sahip 
                        ORDER BY r.BaslangicTarihi DESC";

                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@sahip", tamAd);

                    SqlDataAdapter da = new SqlDataAdapter(komut);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // 3. Verileri Aktif ve Geçmiş olarak ayır
                    DataTable dtAktif = dt.Clone();
                    DataTable dtGecmis = dt.Clone();

                    DateTime simdi = DateTime.Now;

                    foreach (DataRow row in dt.Rows)
                    {
                        DateTime randevuTarihi = Convert.ToDateTime(row["Tarih"]);
                        if (randevuTarihi >= simdi)
                        {
                            dtAktif.ImportRow(row);
                        }
                        else
                        {
                            dtGecmis.ImportRow(row);
                        }
                    }

                    // 4. Gridlere bağla
                    gridAktif.DataSource = dtAktif;
                    gridGecmis.DataSource = dtGecmis;

                    // 5. Mesaj Kontrolü
                    if (dtAktif.Rows.Count == 0)
                    {
                        gridAktif.Visible = false;
                        lblMesaj.Visible = true;
                    }
                    else
                    {
                        gridAktif.Visible = true;
                        lblMesaj.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Randevular yüklenirken hata: " + ex.Message);
            }
        }



        private void repoBtnIptal_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataRow dr = viewAktif.GetDataRow(viewAktif.FocusedRowHandle);
            if (dr != null)
            {
                if (DialogResult.Yes == MessageBox.Show("Bu randevuyu iptal etmek istediğinize emin misiniz?", "İptal Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    try
                    {
                        int id = Convert.ToInt32(dr["Id"]);
                        using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                        {
                            baglanti.Open();
                            // Silmek yerine durumunu 'İptal' yapıyoruz
                            SqlCommand komut = new SqlCommand("UPDATE Randevular SET Durum=N'İptal' WHERE Id=@p1", baglanti);
                            komut.Parameters.AddWithValue("@p1", id);
                            komut.ExecuteNonQuery();
                        }
                        MessageBox.Show("Randevu iptal edildi.");
                        RandevulariYukle(); // Listeyi yenile
                        gridAktif.Refresh(); // Görünümü zorla yenile
                        gridGecmis.Refresh();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("İptal işlemi sırasında hata: " + ex.Message);
                    }
                }
            }
        }

        private void ViewAktif_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
    {
        if (e.RowHandle >= 0)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            object durumObj = view.GetRowCellValue(e.RowHandle, "Durum");
            string durum = durumObj != null ? durumObj.ToString() : "";

            object tarihObj = view.GetRowCellValue(e.RowHandle, "Tarih");
                
            if (durum == "İptal")
            {
                e.Appearance.BackColor = System.Drawing.Color.FromArgb(255, 230, 230);
                e.Appearance.ForeColor = System.Drawing.Color.Red;
                e.Appearance.Font = new System.Drawing.Font(e.Appearance.Font, System.Drawing.FontStyle.Strikeout);
                e.HighPriority = true;
            }
            else if (tarihObj != null && tarihObj != DBNull.Value)
            {
                DateTime tarih = Convert.ToDateTime(tarihObj);
                if (tarih.Date == DateTime.Today)
                {
                    e.Appearance.BackColor = System.Drawing.Color.FromArgb(220, 255, 220);
                    e.HighPriority = true;
                }
            }
        }
    }

    private void ViewGecmis_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
    {
        if (e.RowHandle >= 0)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            object durumObj = view.GetRowCellValue(e.RowHandle, "Durum");
            string durum = durumObj != null ? durumObj.ToString() : "";

            if (durum == "İptal")
            {
                e.Appearance.ForeColor = System.Drawing.Color.Red;
                e.Appearance.Font = new System.Drawing.Font(e.Appearance.Font, System.Drawing.FontStyle.Strikeout);
                e.HighPriority = true;
            }
        }
    }
}
}
