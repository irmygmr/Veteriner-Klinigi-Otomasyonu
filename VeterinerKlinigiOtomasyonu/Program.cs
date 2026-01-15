using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinerKlinigiOtomasyonu
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            while (true)
            {
                // 1. Giriş Seçim Ekranı Açılır
                GirisSecimForm secim = new GirisSecimForm();
                if (secim.ShowDialog() != DialogResult.OK)
                {
                    // Seçim ekranı iptal edilirse uygulamadan çık
                    break;
                }

                // 2. Login Ekranı Açılır
                LoginForm lg = new LoginForm();

                // Seçilen role göre başlığı veya davranış değiştirebiliriz
                // Şimdilik sadece kaydediyoruz
                lg.IsVeterinerMode = secim.IsVeterinerSelected;

                if (lg.ShowDialog() == DialogResult.OK)
                {
                    // 3. Ana Uygulama Açılır
                    if (lg.IsAdmin)
                    {
                        // Veteriner Girişi yaptıysa (Admin ise)
                        Application.Run(new Form1());
                    }
                    else
                    {
                        // Kullanıcı Girişi yaptıysa
                        Application.Run(new UserPanelForm());
                    }
                    // Uygulama kapandığında döngüden çık
                    break;
                }
                // Eğer Login ekranında İptal denirse döngü başa döner ve Seçim Ekranı tekrar açılır
            }
        }
    }
}
