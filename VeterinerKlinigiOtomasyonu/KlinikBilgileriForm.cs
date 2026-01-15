using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace VeterinerKlinigiOtomasyonu
{
    public partial class KlinikBilgileriForm : Form
    {
        string baglantiAdresi = SqlBaglanti.Adres;

        public KlinikBilgileriForm()
        {
            InitializeComponent();
        }

        private void KlinikBilgileriForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                {
                    baglanti.Open();
                    
                    // Tablo Var mı?
                    string tabloSorgu = @"
                        IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='KlinikBilgileri' AND xtype='U')
                        BEGIN
                             -- Eğer Admin henüz oluşturmadıysa, geçici varsayılan değerleri döndürebiliriz veya tabloyu oluşturabiliriz.
                             -- Kullanıcı deneyimi için oluşturalım.
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

                    // Verileri Çek
                    SqlCommand cmdGet = new SqlCommand("SELECT TOP 1 * FROM KlinikBilgileri", baglanti);
                    using (SqlDataReader dr = cmdGet.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            if(dr["Ad"] != DBNull.Value) lblKlinikAdi.Text = dr["Ad"].ToString();
                            if(dr["Adres"] != DBNull.Value) lblAdres.Text = dr["Adres"].ToString();
                            if(dr["Telefon"] != DBNull.Value) lblTel.Text = dr["Telefon"].ToString();
                            if(dr["Email"] != DBNull.Value) lblEmail.Text = dr["Email"].ToString();
                            if(dr["Saatler"] != DBNull.Value) lblSaatler.Text = "Çalışma Saatleri: " + dr["Saatler"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda tasarım zamanındaki varsayılanlar kalır, sadece uyarı verelim mi? 
                // Hayır, kullanıcıyı rahatsız etmeyelim.
                System.Diagnostics.Debug.WriteLine("Klinik bilgileri yüklenemedi: " + ex.Message);
            }
        }
    }
}
