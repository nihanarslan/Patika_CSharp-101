using System;

namespace Donguler_while // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            //1'den başlayarak konsoldan girilen sayıya kadar olan sayıların ortalaması
            Console.Write("Bir sayı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int toplam = 0, sayac = 1;
            while (sayac <= n)
            {
                toplam += sayac;
                sayac++;
            }

            Console.WriteLine("Ortalama = " + toplam/n);


            //a dan z'ye tüm harfleri yazdırma
            char c = 'a';
            while (c <= 'z'){
                Console.Write(c);
                c++;
            }

            //Foreach
            string[] araba = {"BMW", "Ford", "Toyota", "Nissan"};

            foreach (var item in araba)
            {
                Console.WriteLine(item);
            }

        }
    }
}