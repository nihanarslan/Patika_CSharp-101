using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            //ATAMA VE İŞLEMLİ ATAMA
            int x = 3;
            int y = 5;

            y = y+2;
            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);

            //MANTIKSAL OPERATORLER

            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted) {
            Console.WriteLine("Perfect");
            }
            if (isSuccess || isCompleted) {
            Console.WriteLine("Great");
            }
            if (isSuccess && !isCompleted) {
            Console.WriteLine("Fine");
            }

            //İLİŞKİSEL OPERATORLER

            int a = 5;
            int b = 4;
            bool sonuc = a<b;

            Console.WriteLine("A<B = "+sonuc);
            sonuc = a>b;
            Console.WriteLine("A>B = "+sonuc);
            sonuc = a>=b;
            Console.WriteLine("A>=B = "+sonuc);
            sonuc = a<=b;
            Console.WriteLine("A<=B = "+sonuc);
            sonuc = a==b;
            Console.WriteLine("A==B = "+sonuc);
            sonuc = a!=b;
            Console.WriteLine("A!=B = "+sonuc);

            int sayi1= 10;
            int sayi2=5;
            int sonucl=sayi1/sayi2;

            Console.WriteLine(sonucl);
            sonucl = sayi1 + sayi2;
            Console.WriteLine(sonucl);
            sonucl = sayi1+sayi2;
            Console.WriteLine(sonucl);
            sonucl = sayi1 ++;
            Console.WriteLine(sonucl);

        }
    }
}


