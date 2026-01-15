using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace VeterinerKlinigiOtomasyonu
{
    public partial class HastaForm : XtraForm
    {
        // Veritabanı yolu sabitlendi (Veri kaybını önlemek için)
        string baglantiAdresi = SqlBaglanti.Adres;

        public HastaForm()
        {
            InitializeComponent();
        }

        private void HastaForm_Load(object sender, EventArgs e)
        {
            Listele();
            PaneliGuncelle();
        }

        void Listele()
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                {
                    baglanti.Open();
                    
                    // Fotograf sütunu yoksa ekle
                    new SqlCommand(@"IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Hayvanlar' AND COLUMN_NAME = 'Fotograf')
                                     BEGIN
                                         ALTER TABLE Hayvanlar ADD Fotograf VARBINARY(MAX) NULL
                                     END", baglanti).ExecuteNonQuery();

                    SqlDataAdapter da = new SqlDataAdapter("SELECT HayvanId, Ad, Tur, Cinsiyet, Sahibi, Fotograf FROM Hayvanlar", baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gridControl1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme Hatası: " + ex.Message);
            }
        }

        void PaneliGuncelle()
        {
             // Burası dashboard değil ama belki toplam sayı göstermek istenir.
             // Şimdilik boş bırakıyorum veya basit bir label güncellenebilir.
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            // Yeni kayıt ekleme
            KayitFormu frm = new KayitFormu();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (frm.Tag != null && frm.Tag is HayvanModel h)
                {
                    try
                    {
                        using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                        {
                            baglanti.Open();
                            SqlCommand komut = new SqlCommand("INSERT INTO Hayvanlar (Ad, Tur, Sahibi, Cinsiyet, Fotograf) VALUES (@p1, @p2, @p3, @p4, @p5)", baglanti);
                            komut.Parameters.AddWithValue("@p1", h.Adi);
                            komut.Parameters.AddWithValue("@p2", h.Tur);
                            komut.Parameters.AddWithValue("@p3", h.Sahibi);
                            komut.Parameters.AddWithValue("@p4", h.Cinsiyet);
                            
                            if (h.Resim != null)
                                komut.Parameters.AddWithValue("@p5", h.Resim);
                            else
                                komut.Parameters.AddWithValue("@p5", DBNull.Value);
                                
                            komut.ExecuteNonQuery();
                        }
                        Listele();
                        MessageBox.Show("Kayıt Başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (layoutView1.FocusedRowHandle < 0) return;
            object val = layoutView1.GetRowCellValue(layoutView1.FocusedRowHandle, "HayvanId");
            if (val == null) return;
            int id = Convert.ToInt32(val);

            HayvanModel h = new HayvanModel();
            h.Id = id;
            h.Adi = layoutView1.GetRowCellValue(layoutView1.FocusedRowHandle, "Ad").ToString();
            h.Tur = layoutView1.GetRowCellValue(layoutView1.FocusedRowHandle, "Tur").ToString();
            h.Sahibi = layoutView1.GetRowCellValue(layoutView1.FocusedRowHandle, "Sahibi").ToString();
            h.Cinsiyet = layoutView1.GetRowCellValue(layoutView1.FocusedRowHandle, "Cinsiyet").ToString();
            
            object fotoObj = layoutView1.GetRowCellValue(layoutView1.FocusedRowHandle, "Fotograf");
            if (fotoObj != DBNull.Value && fotoObj != null)
                h.Resim = (byte[])fotoObj;

            KayitFormu frm = new KayitFormu();
            frm.BilgileriYukle(h); // Formu güncelleme modunda aç
            
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (frm.Tag is HayvanModel guncelModel)
                {
                    try
                    {
                        using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                        {
                            baglanti.Open();
                            // Güncelleme sorgusu
                            string query = "UPDATE Hayvanlar SET Ad=@p1, Tur=@p2, Sahibi=@p3, Cinsiyet=@p4";
                            if (guncelModel.Resim != null) query += ", Fotograf=@p5";
                            query += " WHERE HayvanId=@id";

                            SqlCommand komut = new SqlCommand(query, baglanti);
                            komut.Parameters.AddWithValue("@p1", guncelModel.Adi);
                            komut.Parameters.AddWithValue("@p2", guncelModel.Tur);
                            komut.Parameters.AddWithValue("@p3", guncelModel.Sahibi);
                            komut.Parameters.AddWithValue("@p4", guncelModel.Cinsiyet);
                            if (guncelModel.Resim != null) komut.Parameters.AddWithValue("@p5", guncelModel.Resim);
                            komut.Parameters.AddWithValue("@id", id);
                            
                            komut.ExecuteNonQuery();
                        }
                        Listele();
                        MessageBox.Show("Bilgiler güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex) { MessageBox.Show("Güncelleme Hatası: " + ex.Message); }
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (layoutView1.FocusedRowHandle < 0) return;
                object val = layoutView1.GetRowCellValue(layoutView1.FocusedRowHandle, "HayvanId");
                
                if (val == null) return;
                int id = Convert.ToInt32(val);

                if (MessageBox.Show("Bu hastayı ve tüm kayıtlarını silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (SqlConnection b = new SqlConnection(baglantiAdresi))
                    {
                        b.Open();
                        // Önce bağlı kayıtları silmek gerekebilir (Randevu, Muayene vb.)
                        // Cascading delete yoksa manuel silmeliyiz, şimdilik direkt silmeyi deniyoruz.
                        new SqlCommand("DELETE FROM Hayvanlar WHERE HayvanId=" + id, b).ExecuteNonQuery();
                    }
                    Listele();
                    MessageBox.Show("Kayıt silindi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme İşlemi Başarısız: " + ex.Message + "\n(Muhtemelen bu kayda bağlı randevu veya muayene verisi var.)");
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
             // Geçmiş muayeneleri göstermek istenirse burada kod olacak
             // Ancak Muayene geçmişi genellikle bu sayfada gridin altında detay olarak gösteriliyordu.
             // Şimdilik sadece ana listeyi alıyoruz.
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
