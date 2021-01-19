using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //Naming convention- yazma kuralı
        //syntax yazım kuralı
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler! Sepete Eklendi : " + urun.Adi);
          
        }
        // alttaki ifade düzensiz bir ifadedir. kolaylaştırmak için classlanıp kapsüllenir. 
        public void Ekle2(string urunAdi, string Aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler! Sepete Eklendi : " + urunAdi);
        }
        
    }
}
