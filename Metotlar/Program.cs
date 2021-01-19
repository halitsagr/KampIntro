using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.stokAdedi = 18; 

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "on numara karpuz";


            Urun[] urunler = new Urun[] { urun1, urun2};
            // type-safe -- tip güvenli
            foreach (Urun urun in urunler)    
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.stokAdedi);
                Console.WriteLine("-------------------");

            }

            Console.WriteLine("----------Metotlar------------");

            //instance - örnek 
            //encapsulation- kapsülleme
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            // alttaki düzensiz bir ifadedir. yarın birgün stok adedi eklenmek istense tüm sayfalara tek tek stok adedi yazmak zorunda kalınır.
            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Yeşil karpuz", 12, 8);
        }
    }
}

// Dont repeat yourself- DRY - Clean Code
