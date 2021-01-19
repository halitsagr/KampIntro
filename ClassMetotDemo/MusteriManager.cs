using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + musteri.Soyad + ", Adlı Müşteri Başarıyla Eklenmiştir.");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + musteri.Soyad + ", Adlı Müşteri Başarıyla Silinmiştir.");
        }

        public void Lİstele ( Musteri musteri)
        {
            Console.WriteLine("Adı:" + musteri.Adi + "  Soyadı:" + musteri.Soyad + "  Mesleği:" + musteri.Meslegi + " Müşteri Bilgileri başarıyla Listelenmiştir.");
        }
    }
}
