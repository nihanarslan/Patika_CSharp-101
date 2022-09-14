using System;

namespace Enum // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enumeration - Sıralama
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);

            int sicaklik = 32;

            if(sicaklik <= (int)HavaDurumu.normal)
                Console.WriteLine("Hava biraz soğuk");
            else if(sicaklik >= (int)HavaDurumu.sıcak && sicaklik < (int)HavaDurumu.normal)
                Console.WriteLine("Hava sıcak");
            else if(sicaklik >= (int)HavaDurumu.coksıcak)
                Console.WriteLine("Hava çookk sıcak"); 

        }
    }

    enum Gunler 
    {
        Pazartesi=1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma = 23,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu
    {
        soguk = 5,
        normal = 20,
        sıcak = 25,
        coksıcak = 30
    }
}