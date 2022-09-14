using System;

namespace koleksiyonlar_soru_2 // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            int[] buyuk_uclu = new int[3];
            int[] kucuk_uclu = new int[3];
            

            for (int i = 0; i < 20; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(arr);
            
            for (int i = 0; i < 3; i++)
            {
                kucuk_uclu[i] = arr[i];
                buyuk_uclu[i] = arr[19-i];
            }

            Console.Write("En küçük üç sayının ortalaması: ");
            int x = ElemanToplami(kucuk_uclu)/kucuk_uclu.Count();    //ortalaması toplam/eleman sayısı
            Console.WriteLine(x);
            
            Console.Write("En büyük üç sayının ortalaması");
            int y = ElemanToplami(buyuk_uclu)/buyuk_uclu.Count();    //ortalaması
            Console.WriteLine(y);

            Console.WriteLine("Ortalamaların toplamları: {0}",x+y);


        }

        static int ElemanToplami(int[] x)
        {
            int toplam = 0;
            foreach (var item in x)
            {
                toplam += item;
            }

            return toplam;
        }
    }
}