using System;

namespace sinif_kavrami // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sınıf Söz Dizimi

            //class className
            // {
            //     [Erişim belirleyici] [Veri Tipi] Özellik adı;
            //     [Erişim belirleyici] [Geri Dönüş tpi] MEtotAdı(Parametre Listesi)
            //     {

            //     }
            // }

            /*
            Erişim belirleyiciler: public private internal protected
            
            Public: her yerden erişilebilir.
            Private: sadece tanımlandığı sınıf içinde erişilebilen
            Internal: sadece kendi bulunduğu proje içerisinde erişilebilen property ve metotlar
            Protected: sadece tanımlandığı sınıfta veya o sınıftan miras alan diğer sınıflarda kullanılabilir. 
            */

            Calisan calisan1 = new Calisan("Ayşe", "Kara", 23415634, "İnsan Kaynakları");
            calisan1.CalisanBilgileri();

            Console.WriteLine("************************");
            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Arda";
            calisan2.No = 23415635;
            calisan2.Departman = "Satın Alma";

            calisan2.CalisanBilgileri();
        }

        class Calisan
        {
            public string Ad;
            public string Soyad;
            public int No;
            public string Departman;

            public Calisan(string ad, string soyad, int no, string departman)       //Constructor kurucu fonksiyon. 
            {
                this.Ad = ad;   //this ile kullanılan bu sınıfın bir elemanı olan Addır.
                this.Soyad = soyad;
                this.No = no;
                this.Departman = departman;
            }

            public Calisan(){}
            public void CalisanBilgileri()
            {
                Console.WriteLine("Çalışan adı: {0}", Ad);
                Console.WriteLine("Çalışan soyadı: {0}", Soyad);
                Console.WriteLine("Çalışan numarası: {0}", No);
                Console.WriteLine("Çalışan departmanı: {0}", Departman);
            }
        }
    }
}