using System;

namespace VeterinerKlinigiOtomasyonu
{
    public class HayvanModel
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Tur { get; set; }
        public string Sahibi { get; set; }
        public string Cinsiyet { get; set; }
        public byte[] Resim { get; set; }
    }
}
