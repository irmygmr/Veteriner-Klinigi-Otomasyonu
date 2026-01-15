using System;

namespace VeterinerKlinigiOtomasyonu
{
    public class Hayvan
    {
        public int HayvanId { get; set; }
        public string Sahibi { get; set; }
        public int MusteriId { get; set; } // Hangi müşteriye ait?
        public string Adi { get; set; }
        public string Tur { get; set; }

        public string Cinsiyet { get; set; }

    }
}