using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraScheduler;

namespace VeterinerKlinigiOtomasyonu
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            

            // Skin ayarı
            try { DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "The Bezier"; }
            catch { }
            
            // Başlangıçta Dashboard aç
            try {
                 navigationFrame1.Visible = false; // Çakışmayı önlemek için gizle
                 panelContainer.Visible = true;
                 panelContainer.BringToFront();
                 accordionControl1.BringToFront(); // Menü en üstte kalsın
                 FormGetir(new DashboardForm());
            } catch { }
        }

        private void FormGetir(Form frm)
        {
            // Panel Container aktif, NavigationFrame pasif
            navigationFrame1.Visible = false;
            panelContainer.Visible = true;
            panelContainer.BringToFront();

            panelContainer.Controls.Clear(); // Önceki formu temizle
            
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None; 
            
            frm.Dock = DockStyle.Fill;
            
            panelContainer.Controls.Add(frm);
            frm.Show();
        }

        // GENEL NAVIGASYON
        private void accordionControl1_ElementClick(object sender, ElementClickEventArgs e)
        {
            if (e.Element == null) return;
            string text = e.Element.Text;

            if (text == "Panel") // Dashboard
            {
                FormGetir(new DashboardForm());
            }
            else if (text == "Müşteri ve Hasta Kayıt" || text == "Hasta Kayıt")
            {
                FormGetir(new HastaForm());
            }
            else if (text == "Randevu Takvimi")
            {
                FormGetir(new RandevuForm());
            }
            else if (text == "Stok/Depo")
            {
                FormGetir(new StokForm());
            }
            else if (text == "Aşı Takibi")
            {
                FormGetir(new AsiForm());
            }
            else if (text == "Kasa İşlemleri" || text == "Kasa/Muhasebe")
            {
                FormGetir(new KasaForm());
            }
            else if (text == "Muayeneler")
            {
                FormGetir(new MuayeneForm());
            }
        }

        // --- OLD HANDLERS (Boş) ---
        private void accordionControlElement2_Click(object sender, EventArgs e) {}
        private void accordionControlElement3_Click(object sender, EventArgs e) {}
        private void accordionControlElement1_Click(object sender, EventArgs e) {}
        private void simpleButton2_Click(object sender, EventArgs e) { }
        private void simpleButton4_Click(object sender, EventArgs e) { }
        private void simpleButton1_Click(object sender, EventArgs e) { }
        private void btnAsiKaydet_Click(object sender, EventArgs e) { }
        private void btnOdemeAl_Click(object sender, EventArgs e) { }
        private void ribbonControl1_Click(object sender, EventArgs e) { }
        private void ribbonStatusBar1_Click(object sender, EventArgs e) { }
        
        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e) { }
        
        private void PagePanel_Paint(object sender, PaintEventArgs e) { }
        private void PageRandevu_Paint(object sender, PaintEventArgs e) { }
        private void panelControl1_Paint(object sender, PaintEventArgs e) { }
        private void panelControl2_Paint(object sender, PaintEventArgs e) { }
        
        private void gridControlRandevu_Click(object sender, EventArgs e) { }
        private void schedulerControl1_Click(object sender, EventArgs e) { }
        private void schedulerControl1_AppointmentViewInfoCustomizing(object sender, AppointmentViewInfoCustomizingEventArgs e) { }
        
        private void simpleButton3_Click_1(object sender, EventArgs e) 
        { 
             // Dashboard'daki "Yeni Randevu" butonu
             navigationFrame1.SelectedPage = PageRandevu;
        }
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e) { }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
        private void accordionControlElementSettings_Click(object sender, EventArgs e)
        {
             // NavigationFrame aktif, Panel Container pasif
             panelContainer.Visible = false;
             navigationFrame1.Visible = true;
             navigationFrame1.BringToFront();

             navigationFrame1.SelectedPage = PageKlinikAyarlari;
             KlinikBilgileriniYukle();
        }

        private void KlinikBilgileriniYukle()
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(SqlBaglanti.Adres))
                {
                    baglanti.Open();

                    
                    string tabloSorgu = @"
                        IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='KlinikBilgileri' AND xtype='U')
                        BEGIN
                            CREATE TABLE KlinikBilgileri (
                                Id INT PRIMARY KEY IDENTITY(1,1),
                                Ad NVARCHAR(100),
                                Adres NVARCHAR(500),
                                Telefon NVARCHAR(50),
                                Email NVARCHAR(100),
                                Saatler NVARCHAR(500)
                            )
                            INSERT INTO KlinikBilgileri (Ad, Adres, Telefon, Email, Saatler) VALUES 
                            ('Tarçın Veteriner Kliniği', 
                             'Cumhuriyet Mah. Atatürk Cad. No:123/A' + CHAR(13) + CHAR(10) + 'Kadıköy / İSTANBUL', 
                             '0 (216) 123 45 67', 
                             'bilgi@tarcinvet.com.tr', 
                             'Hafta içi 09:00 - 18:00' + CHAR(13) + CHAR(10) + 'Hafta sonu: 10:00 - 16:00 (Pazar Kapalı)')
                        END";
                    
                    SqlCommand cmdTablo = new SqlCommand(tabloSorgu, baglanti);
                    cmdTablo.ExecuteNonQuery();

                    // 2. Verileri Çekme
                    SqlCommand cmdGet = new SqlCommand("SELECT TOP 1 * FROM KlinikBilgileri", baglanti);
                    using (SqlDataReader dr = cmdGet.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            txtKlinikAdi.Text = dr["Ad"].ToString();
                            txtAdres.Text = dr["Adres"].ToString();
                            txtTel.Text = dr["Telefon"].ToString();
                            txtEmail.Text = dr["Email"].ToString();
                            txtSaatler.Text = dr["Saatler"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Klinik bilgileri yüklenirken hata oluştu: " + ex.Message);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(SqlBaglanti.Adres))
                {
                    baglanti.Open();
                    
                    // Güncelleme Sorgusu
                    string updateQuery = @"
                        UPDATE KlinikBilgileri SET 
                        Ad = @p1, 
                        Adres = @p2, 
                        Telefon = @p3, 
                        Email = @p4, 
                        Saatler = @p5";
                    
                    SqlCommand cmd = new SqlCommand(updateQuery, baglanti);
                    cmd.Parameters.AddWithValue("@p1", txtKlinikAdi.Text);
                    cmd.Parameters.AddWithValue("@p2", txtAdres.Text);
                    cmd.Parameters.AddWithValue("@p3", txtTel.Text);
                    cmd.Parameters.AddWithValue("@p4", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@p5", txtSaatler.Text);
                    
                    int rows = cmd.ExecuteNonQuery();
                    
                    if(rows > 0)
                        MessageBox.Show("Klinik bilgileri başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Güncellenecek kayıt bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaydetme sırasında hata: " + ex.Message);
            }
        }

    }
}