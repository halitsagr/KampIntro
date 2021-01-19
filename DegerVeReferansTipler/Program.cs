using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi2 = sayi1;
            sayi2 = 65;
            Console.WriteLine(sayi1);    //sayi1 = 30 da kalır sayi2 = sayi1 denildiğinde sayi2 nin değeri sayi1 ile aynı olur. 
                                         //sayi1 = sayi2 denildiğinde ise sayi1 in değeri sayi2 ile aynı olur.  


            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;  // bu ifade sayilar1 in referans numarası sayilar2 nin referans numarasına eşittir demek olur. bundan sonra ona bağlanır. değeri onunla aynı olur
            sayilar2[0] = 700;
         
            //sayilar1[0] ?  999
            Console.WriteLine(sayilar1[0]);

        }
    }
}
