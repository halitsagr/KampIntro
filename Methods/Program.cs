using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
           // Add();
           //var toplam = Add2(20,30);
           // Console.WriteLine(toplam);


            int number1 = 20;
            int number2 = 100;
            var result = Add3(number1, number2);
            Console.WriteLine(result);
            Console.WriteLine(number1);
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added");
        }

        static int Add2(int number1, int number2) // yeni gelen özellikle beraber number2= 30 diyebilir Add2 den 30 u silebilirz. yine çalışır. Fakat sonda olması lazımdır.
        {                                               // Ve yine Add2 den tüm sayıları silip bu sistemle number1 e number2 ye değer vererek te çalıştırabiliriz. 
            var toplam = number1 + number2;
            return toplam;
        }

      static int Add3(int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
    }
}
