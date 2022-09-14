using System;

namespace Donguler // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır
            Console.Write("Bir sayı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                if(i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }

            //1 ile 1000 arasındaki tek ve çift sayıların toplamı
            int tek_toplam = 0;
            int cift_toplam = 0;
            for(int i = 0; i<=1000; i++)
            {
                if(i%2 == 0){
                    cift_toplam += i;
                }
                else{
                    tek_toplam += i;
                }
            }
            Console.WriteLine("Tek toplam = " + tek_toplam);
            Console.WriteLine("Çift toplam = " + cift_toplam);

            //break, continue
            for(int i =1; i<10; i++)
            {
                if(i == 4)
                    break;
                
                Console.WriteLine(i);
            }
            
            for(int i =1; i<10; i++)
            {
                if(i == 4)
                    continue;
                
                Console.WriteLine(i);
            }
        }
    }
}