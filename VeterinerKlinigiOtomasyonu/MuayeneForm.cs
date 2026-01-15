using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace VeterinerKlinigiOtomasyonu
{
    public partial class MuayeneForm : XtraForm
    {
        string baglantiAdresi = SqlBaglanti.Adres;
        int seciliMuayeneId = 0;

        public MuayeneForm()
        {
            InitializeComponent();
        }

        private void MuayeneForm_Load(object sender, EventArgs e)
        {
            VeritabaniKontrol();
            ListeleHayvanlar();
            Temizle();
        }

        void VeritabaniKontrol()
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                {
                    baglanti.Open();

                    // 1. MuayeneId PK Kontrolü (Primary Key)
                    SqlCommand cmdPK = new SqlCommand("SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Muayeneler' AND COLUMN_NAME = 'MuayeneId'", baglanti);
                    if ((int)cmdPK.ExecuteScalar() == 0)
                    {
                        using (SqlCommand cmdAdd = new SqlCommand("ALTER TABLE Muayeneler ADD MuayeneId INT IDENTITY(1,1) PRIMARY KEY", baglanti))
                            cmdAdd.ExecuteNonQuery();
                    }

                    // 2. Teshis Kolonu Kontrolü
                    SqlCommand cmdTeshis = new SqlCommand("SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Muayeneler' AND COLUMN_NAME = 'Teshis'", baglanti);
                    if ((int)cmdTeshis.ExecuteScalar() == 0)
                    {
                        using (SqlCommand cmdAdd = new SqlCommand("ALTER TABLE Muayeneler ADD Teshis NVARCHAR(MAX)", baglanti))
                            cmdAdd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) 
            {
                // Kritik tablo hatası varsa uyar
                MessageBox.Show("Veritabanı yapılandırma hatası: " + ex.Message);
            }
        }

        void ListeleHayvanlar()
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                {
                    // Hayvan listesi
                    SqlDataAdapter da = new SqlDataAdapter("SELECT HayvanId, Ad, Tur, Cinsiyet, Sahibi FROM Hayvanlar ORDER BY Ad ASC", baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gridControlHastaListesi.DataSource = dt;
                }
            }
            catch (Exception ex) { MessageBox.Show("Hayvan listesi yüklenemedi: " + ex.Message); }
        }

        private void gridViewHastaListesi_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                object val = gridViewHastaListesi.GetFocusedRowCellValue("HayvanId");
                if (val != null && val != DBNull.Value)
                {
                    int id = Convert.ToInt32(val);
                    ListeleGeçmisMuayeneler(id);
                    TemizleGiris(false); // Yeni hasta seçildiğinde girişleri temizle
                }
            }
            catch { }
        }

        void ListeleGeçmisMuayeneler(int hayvanId)
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                {
                    string query = "SELECT MuayeneId, Sikayet, Teshis, Tarih FROM Muayeneler WHERE HayvanId=@hId ORDER BY Tarih DESC";
                    SqlDataAdapter da = new SqlDataAdapter(query, baglanti);
                    da.SelectCommand.Parameters.AddWithValue("@hId", hayvanId);
                    
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gridControlGecmis.DataSource = dt;
                }
            }
            catch (Exception ex) { MessageBox.Show("Geçmiş muayeneler yüklenemedi: " + ex.Message); }
        }

        private void gridViewGecmis_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                object valId = gridViewGecmis.GetFocusedRowCellValue("MuayeneId");
                if (valId == null || valId == DBNull.Value) return;

                seciliMuayeneId = Convert.ToInt32(valId);
                
                object valSikayet = gridViewGecmis.GetFocusedRowCellValue("Sikayet");
                memoSikayet.Text = (valSikayet != null) ? valSikayet.ToString() : "";

                object valTeshis = gridViewGecmis.GetFocusedRowCellValue("Teshis");
                memoTeshis.Text = (valTeshis != null) ? valTeshis.ToString() : "";

                // Düzenleme moduna geç
                btnMuayeneKaydet.Enabled = false;
                btnMuayeneGuncelle.Enabled = true;
                btnMuayeneSil.Enabled = true;
            }
            catch { }
        }

        private void btnMuayeneKaydet_Click(object sender, EventArgs e)
        {
            KaydetVeGuncelle(false);
        }

        private void btnMuayeneGuncelle_Click(object sender, EventArgs e)
        {
            KaydetVeGuncelle(true);
        }

        private void btnMuayeneSil_Click(object sender, EventArgs e)
        {
            if (seciliMuayeneId == 0) return;
            if (MessageBox.Show("Bu muayene kaydını kalıcı olarak silmek istiyor musunuz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                {
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Muayeneler WHERE MuayeneId=@id", baglanti);
                    cmd.Parameters.AddWithValue("@id", seciliMuayeneId);
                    cmd.ExecuteNonQuery();
                }
                ListeyiYenile();
                TemizleGiris(true);
                MessageBox.Show("Muayene kaydı silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show("Silme işlemi başarısız: " + ex.Message); }
        }

        void KaydetVeGuncelle(bool guncelleme)
        {
            try
            {
                object val = gridViewHastaListesi.GetFocusedRowCellValue("HayvanId");
                if (val == null || val == DBNull.Value)
                {
                    MessageBox.Show("Lütfen sol taraftan bir hasta seçiniz.");
                    return;
                }
                int hayvanId = Convert.ToInt32(val);

                if (string.IsNullOrWhiteSpace(memoSikayet.Text) && string.IsNullOrWhiteSpace(memoTeshis.Text))
                {
                    MessageBox.Show("Lütfen 'Şikayet' veya 'Teşhis' alanlarından en az birini doldurunuz.");
                    return;
                }

                using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                {
                    baglanti.Open();
                    string query = "";
                    
                    if (guncelleme)
                        query = "UPDATE Muayeneler SET Sikayet=@p1, Teshis=@p2 WHERE MuayeneId=@id";
                    else
                        query = "INSERT INTO Muayeneler (HayvanId, Sikayet, Teshis, Tarih) VALUES (@hId, @p1, @p2, @tarih)";

                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.Parameters.AddWithValue("@p1", memoSikayet.Text.Trim());
                    komut.Parameters.AddWithValue("@p2", memoTeshis.Text.Trim());

                    if (guncelleme)
                    {
                        komut.Parameters.AddWithValue("@id", seciliMuayeneId);
                    }
                    else
                    {
                        komut.Parameters.AddWithValue("@hId", hayvanId);
                        komut.Parameters.AddWithValue("@tarih", DateTime.Now);
                    }

                    komut.ExecuteNonQuery();
                }

                MessageBox.Show(guncelleme ? "Muayene güncellendi." : "Muayene kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListeyiYenile();
                
                if (guncelleme) 
                    Temizle(); // Güncelleme bitti, normale dön
                else 
                    TemizleGiris(true); // Kayıt bitti, temizle
            }
            catch (Exception ex) { MessageBox.Show("İşlem hatası: " + ex.Message); }
        }

        void ListeyiYenile()
        {
            object val = gridViewHastaListesi.GetFocusedRowCellValue("HayvanId");
            if (val != null && val != DBNull.Value)
            {
                ListeleGeçmisMuayeneler(Convert.ToInt32(val));
            }
        }

        void Temizle()
        {
            TemizleGiris(true);
        }

        void TemizleGiris(bool herseyiSifirla)
        {
            seciliMuayeneId = 0;
            memoSikayet.Text = "";
            memoTeshis.Text = "";
            
            btnMuayeneKaydet.Enabled = true;
            btnMuayeneGuncelle.Enabled = false;
            btnMuayeneSil.Enabled = false;

            if (herseyiSifirla)
            {
                // Grid seçimini görsel olarak kaldırabiliriz ama FocusedRow kalır.
                // gridViewGecmis.ClearSelection(); 
            }
        }
    }
}
