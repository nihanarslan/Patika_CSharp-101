using System;

namespace Metodlar // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;

            Console.WriteLine(a+b);

            int sonuc = Topla(a,b);
            Console.WriteLine(sonuc);

            Metodlar ornek = new Metodlar();
            ornek.EkranaYazdir(sonuc.ToString());

            int sonuc2 = ornek.ArttırVeTopla(a,b);
            ornek.EkranaYazdir(sonuc2.ToString());
            ornek.EkranaYazdir((a+b).ToString());

            int sonuc3 = ornek.ArttırVeTopla2(ref a,ref b);
            ornek.EkranaYazdir(sonuc3.ToString());
            ornek.EkranaYazdir((a+b).ToString());

        }

        static int Topla(int deger1, int deger2)
        {
            return deger1 + deger2;
        }

    }

    class Metodlar{
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttırVeTopla(int val1, int val2)
        {
            val1+=1;
            val2+=1;
            return val1+val2;
        }


        public int ArttırVeTopla2(ref int val1, ref int val2)
        {
            val1+=1;
            val2+=1;
            return val1+val2;
        }
    }
}