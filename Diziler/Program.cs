using System;

namespace Diziler // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] renkler = new String[5];

            string[] hayvanlar = {"kedi", "köpek", "kuş", "maymun"};

            int[] dizi;
            dizi = new int[5];

            //Değer atama
            renkler[0] = "mavi";
            dizi[3] = 10;

            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);
            
            //Döngülerle diziler
            //Klavyeden girilen n tane sayının ortalamasını alan program
            Console.WriteLine("Bir sayı giriniz:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] sayi_Dizisi = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Lütfen {0}. elemanı giriniz:", i+1);
                sayi_Dizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach (var item in sayi_Dizisi)
                toplam += item;

            Console.WriteLine("Ortalama = "+ (float)toplam/n);

        }
    }
}