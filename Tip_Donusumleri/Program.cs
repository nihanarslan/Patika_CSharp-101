using System;

namespace Tip_Donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit conversion (Bilinçsiz dönüşüm)
            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b +c;
            Console.WriteLine("d" + d);

            long h = d;
            Console.WriteLine("h" + h);

            float i = h;
            Console.WriteLine("i" + i);

            string v = "nihan";
            char f = 'k';
            object g = a+v+f;
            Console.WriteLine(g);


            //Explicit conversion (Bilinçli Dönüşüm)
            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y:"+y);

            float p = 10.3f;
            byte by = (byte)p;
            Console.WriteLine("by:"+by);

            //tostring
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy"+yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz"+zz);

            //System.convert
            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 =  Convert.ToInt32(s2);
            toplam = sayi1 + sayi2;

            Console.WriteLine("toplam=" + toplam);

            //Parse
            ParseMethod();

        }

        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            Console.WriteLine("rakam1=" + rakam1);

            double1 = Double.Parse(metin2);
            Console.WriteLine("double1=" + double1);


        }
    }
}