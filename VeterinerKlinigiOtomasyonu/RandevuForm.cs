using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace VeterinerKlinigiOtomasyonu
{
    public partial class RandevuForm : XtraForm
    {
        string baglantiAdresi = SqlBaglanti.Adres;
        int seciliRandevuId = 0;

        public RandevuForm()
        {
            InitializeComponent();
        }

        private void RandevuForm_Load(object sender, EventArgs e)
        {
            VeritabaniKontrol();
            HayvanlariYukle();
            RandevulariListele();
            Temizle();
            
            // Gridview olaylarını bağla
            gridViewGelecek.FocusedRowChanged += GridView_FocusedRowChanged;
            gridViewGecmis.FocusedRowChanged += GridView_FocusedRowChanged;
            
            // Renklendirme
            gridViewGelecek.RowStyle += GridViewGelecek_RowStyle;
            gridViewGecmis.RowStyle += GridViewGecmis_RowStyle;
        }

        void VeritabaniKontrol()
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                {
                    baglanti.Open();
                    // Durum kolonu kontrolü
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Randevular' AND COLUMN_NAME = 'Durum'", baglanti);
                    int varMi = (int)cmd.ExecuteScalar();
                    if (varMi == 0)
                    {
                        // Kolon yoksa ekle ve mevcut kayıtları 'Aktif' yap
                        SqlCommand cmdAdd = new SqlCommand("ALTER TABLE Randevular ADD Durum NVARCHAR(50) DEFAULT 'Aktif'", baglanti);
                        cmdAdd.ExecuteNonQuery();

                        SqlCommand cmdUpdate = new SqlCommand("UPDATE Randevular SET Durum='Aktif' WHERE Durum IS NULL", baglanti);
                        cmdUpdate.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Veritabanı güncelleme hatası: " + ex.Message); }
        }

        private void GridViewGelecek_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                GridView view = sender as GridView;
                object durumObj = view.GetRowCellValue(e.RowHandle, "Durum");
                string durum = durumObj != null ? durumObj.ToString() : "";

                object tarihObj = view.GetRowCellValue(e.RowHandle, "BaslangicTarihi");
                
                // İptal edilenler Kırmızı
                if (durum == "İptal")
                {
                    e.Appearance.BackColor = Color.FromArgb(255, 230, 230); // Soluk Kırmızı
                    e.Appearance.ForeColor = Color.Red;
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Strikeout);
                }
                // Bugünün Aktif randevuları Yeşil
                else if (tarihObj != null && tarihObj != DBNull.Value)
                {
                    DateTime tarih = Convert.ToDateTime(tarihObj);
                    if (tarih.Date == DateTime.Today)
                    {
                        e.Appearance.BackColor = Color.FromArgb(220, 255, 220); // Hafif Yeşil
                        e.Appearance.BackColor2 = Color.FromArgb(200, 255, 200);
                        e.HighPriority = true;
                    }
                }
            }
        }

        private void GridViewGecmis_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                GridView view = sender as GridView;
                object durumObj = view.GetRowCellValue(e.RowHandle, "Durum");
                string durum = durumObj != null ? durumObj.ToString() : "";

                if (durum == "İptal")
                {
                    e.Appearance.ForeColor = Color.Red; // Geçmişte sadece yazı kırmızı olsun
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Strikeout);
                }
            }
        }

        void HayvanlariYukle()
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT HayvanId, Ad, Tur, Sahibi FROM Hayvanlar", baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    lookUpHayvan.Properties.DataSource = dt;
                    lookUpHayvan.Properties.DisplayMember = "Ad";
                    lookUpHayvan.Properties.ValueMember = "HayvanId";

                    lookUpHayvan.Properties.Columns.Clear();
                    lookUpHayvan.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ad", "Hayvan Adı"));
                    lookUpHayvan.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Tur", "Tür"));
                    lookUpHayvan.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Sahibi", "Sahip"));
                    
                    lookUpHayvan.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hayvan listesi yüklenemedi: " + ex.Message);
            }
        }

        void RandevulariListele()
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                {
                    // Ortak Sorgu Parçası
                    string baseQuery = @"
                        SELECT 
                            r.Id as RandevuId, 
                            r.BaslangicTarihi, 
                            h.Ad as HayvanAdi, 
                            h.Sahibi as SahipAdi,
                            r.Aciklama, 
                            r.HayvanId,
                            ISNULL(r.Durum, 'Aktif') as Durum
                        FROM Randevular r 
                        LEFT JOIN Hayvanlar h ON r.HayvanId = h.HayvanId ";

                    // 1. Gelecek Randevular (Bugün ve Sonrası)
                    string queryGelecek = baseQuery + " WHERE r.BaslangicTarihi >= CAST(GETDATE() AS DATE) ORDER BY r.BaslangicTarihi ASC";
                    SqlDataAdapter daGelecek = new SqlDataAdapter(queryGelecek, baglanti);
                    DataTable dtGelecek = new DataTable();
                    daGelecek.Fill(dtGelecek);
                    gridControlGelecek.DataSource = dtGelecek;

                    // 2. Geçmiş Randevular (Bugünden Önce)
                    string queryGecmis = baseQuery + " WHERE r.BaslangicTarihi < CAST(GETDATE() AS DATE) ORDER BY r.BaslangicTarihi DESC";
                    SqlDataAdapter daGecmis = new SqlDataAdapter(queryGecmis, baglanti);
                    DataTable dtGecmis = new DataTable();
                    daGecmis.Fill(dtGecmis);
                    gridControlGecmis.DataSource = dtGecmis;
                }
            }
            catch (Exception ex) { MessageBox.Show("Liste Hatası: " + ex.Message); }
        }

        void Temizle()
        {
            seciliRandevuId = 0;
            lookUpHayvan.EditValue = null;
            txtAciklama.Text = "";
            deRandevuTarihi.EditValue = DateTime.Now;

            btnEkle.Enabled = true;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
            btnIptal.Enabled = false;
            
            // Grid seçimlerini temizle (Görsel olarak)
            // gridViewGelecek.ClearSelection(); // Grid odaklanma sorununu önlemek için kapattık
            // gridViewGecmis.ClearSelection();
        }

        // Her iki Grid için ortak FocusedRowChanged Eventi
        private void GridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.GetFocusedRow() == null) return;

            try
            {
                object idVal = view.GetRowCellValue(view.FocusedRowHandle, "RandevuId");
                if (idVal != DBNull.Value && idVal != null)
                {
                    seciliRandevuId = Convert.ToInt32(idVal);

                    object hId = view.GetRowCellValue(view.FocusedRowHandle, "HayvanId");
                    if (hId != DBNull.Value) lookUpHayvan.EditValue = hId;

                    object tarih = view.GetRowCellValue(view.FocusedRowHandle, "BaslangicTarihi");
                    if (tarih != DBNull.Value) deRandevuTarihi.DateTime = Convert.ToDateTime(tarih);

                    object aciklama = view.GetRowCellValue(view.FocusedRowHandle, "Aciklama");
                    txtAciklama.Text = aciklama != null ? aciklama.ToString() : "";

                    // Buton Durumları
                    btnEkle.Enabled = false;
                    btnGuncelle.Enabled = true;
                    btnSil.Enabled = true;
                    btnIptal.Enabled = true;
                }
            }
            catch { }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kaydet(false);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Kaydet(true);
        }

        void Kaydet(bool guncelleme)
        {
            try
            {
                if (lookUpHayvan.EditValue == null)
                {
                    MessageBox.Show("Lütfen bir hayvan seçiniz.");
                    return;
                }

                using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                {
                    baglanti.Open();
                    string query = "";
                    
                    if (guncelleme)
                        query = "UPDATE Randevular SET BaslangicTarihi=@p1, Aciklama=@p2, HayvanId=@p3 WHERE Id=@id";
                    else
                        query = "INSERT INTO Randevular (BaslangicTarihi, Aciklama, HayvanId, Durum) VALUES (@p1, @p2, @p3, 'Aktif')";

                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.Parameters.AddWithValue("@p1", deRandevuTarihi.DateTime);
                    komut.Parameters.AddWithValue("@p2", txtAciklama.Text);
                    komut.Parameters.AddWithValue("@p3", lookUpHayvan.EditValue);

                    if (guncelleme) komut.Parameters.AddWithValue("@id", seciliRandevuId);

                    komut.ExecuteNonQuery();
                    MessageBox.Show(guncelleme ? "Randevu güncellendi." : "Randevu oluşturuldu.");
                }
                RandevulariListele();
                Temizle();
            }
            catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (seciliRandevuId == 0) return;
            if (MessageBox.Show("Randevuyu tamamen silmek istediğinize emin misiniz? (İptal etmek isterseniz İPTAL butonunu kullanın)", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                {
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Randevular WHERE Id=@id", baglanti);
                    cmd.Parameters.AddWithValue("@id", seciliRandevuId);
                    cmd.ExecuteNonQuery();
                }
                RandevulariListele();
                Temizle();
            }
            catch (Exception ex) { MessageBox.Show("Silme Hatası: " + ex.Message); }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            if (seciliRandevuId == 0) return;
            if (MessageBox.Show("Bu randevuyu iptal etmek istediğinize emin misiniz?", "Vazgeçme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                {
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Randevular SET Durum='İptal' WHERE Id=@id", baglanti);
                    cmd.Parameters.AddWithValue("@id", seciliRandevuId);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Randevu iptal edildi.");
                RandevulariListele();
                Temizle();
            }
            catch (Exception ex) { MessageBox.Show("İptal Hatası: " + ex.Message); }
        }
    }
}
