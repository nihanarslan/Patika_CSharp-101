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
            Console.WriteLine("***** Çalışan 1 *****");
            Calisan calisan1 = new Calisan("Ayşe", "Kara", 23415634, "İnsan Kaynakları");
            calisan1.CalisanBilgileri();

            Console.WriteLine("***** Çalışan 2 *****");
            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Arda";
            calisan2.No = 23415635;
            calisan2.Departman = "Satın Alma";

            calisan2.CalisanBilgileri();

            Console.WriteLine("***** Çalışan 3 *****");
            Calisan calisan3 = new Calisan("Nihan", "Arslan");
            calisan3.CalisanBilgileri();


            
        }

        class Calisan
        {
            public string Ad;
            public string Soyad;
            public int No;
            public string Departman;

            //Constructor kurucu fonksiyon. 
            //Metoda adı sınıf adı ile aynı olmak zorundadır.
            //public olmak zorundadır
            //Geri dönüş değeri yoktur
            //Constructorlar aşırı yüklenebilir..
            //Her sınıfın biz tanımlamasakta bir tane varsayılan (default) kurucu metotu vardır.
            public Calisan(string ad, string soyad, int no, string departman)       
            {
                this.Ad = ad;   //this ile kullanılan bu sınıfın bir elemanı olan Addır.
                this.Soyad = soyad;
                this.No = no;
                this.Departman = departman;
            }
            
            public Calisan(string ad, string soyad)       //Constructor kurucu fonksiyon. 
            {
                this.Ad = ad;   //this ile kullanılan bu sınıfın bir elemanı olan Addır.
                this.Soyad = soyad;
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