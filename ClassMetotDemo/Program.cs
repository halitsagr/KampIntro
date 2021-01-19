using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Mustafa";
            musteri1.Soyad = " Yüksel";
            musteri1.Meslegi = "Polis";

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Halit";
            musteri2.Soyad = " Sağır";
            musteri2.Meslegi = "Yazılım Mühendisi";

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Ali";
            musteri3.Soyad = "Taşçı";
            musteri3.Meslegi = "Doktor ";

            

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3};

            //foreach (Musteri musteri in musteriler)
            //{
            //    Console.WriteLine(musteri.Adi);
            //    Console.WriteLine(musteri.Soyad);
            //    Console.WriteLine(musteri.Meslegi);
            //}

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Lİstele(musteri3);





        }
    }
}
