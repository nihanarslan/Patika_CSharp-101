using System;
using System.Collections;

namespace koleksiyonlar_soru1 // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList asalSayilar = new ArrayList();
            ArrayList asalOlmayanSayilar = new ArrayList();

            int x; 

            for (int i = 0; i < 20; i++)
            {
                if(int.TryParse(Console.ReadLine(), out x) && x>0){
                    if(AsalMi(x))
                        asalSayilar.Add(x);
                    else
                        asalOlmayanSayilar.Add(x);
                }
                else{
                    Console.WriteLine("Girdiğiniz sayı geçersizdir. Pozitif bir sayı giriniz."); 
                    i--;
                }
            }

            Yazdir(asalSayilar, true); 
            Yazdir(asalOlmayanSayilar, false);
            


        }

        static bool AsalMi (int x)
        {
            if (x <= 1) return false;

            for (int i = 2; i <= x/2; i++)
            {
                if(x%i == 0)
                    return false;
            }
            return true;
        }

        static void Yazdir(ArrayList x, bool asalMi)
        {
            int toplam = 0;

            x.Sort();
            x.Reverse();
            
            if(asalMi)
                Console.WriteLine("Asal Sayılar");
            else
                Console.WriteLine("Asal olmayan sayılar");

            foreach (var item in x)
            {
                Console.WriteLine(item);
                toplam += (int)item;
            }

            Console.WriteLine("Eleman sayısı = "+x.Count);
            Console.WriteLine("Elemanlar ortalaması = "+(float)toplam/x.Count);
        }
    }
}