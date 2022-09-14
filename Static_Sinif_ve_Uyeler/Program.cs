using System;

namespace static_sinif_ve_uyeler // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
    
            Console.WriteLine("Çalışan Sayısı:{0}", Calisan.Calisan_sayisi); //Static property e erişildi public olana değil

            Calisan calisan1 = new Calisan("Ayşe", "Yılmaz", "IK");

            Console.WriteLine("Çalışan Sayısı:{0}", Calisan.Calisan_sayisi);
            
            Console.WriteLine("Toplama işlemi sonucu {0}",Islemler.Topla(100,200));
            Console.WriteLine("Çıkarma işlemi sonucu {0}",Islemler.Cikar(400,500));
        }
    }

    class Calisan
    {
        private static int calisan_sayisi;

        public static int Calisan_sayisi { get => calisan_sayisi; }

        private string Isim;
        private string Soyisim;
        private string Departman;

        //Static olan Constructor sadece bir kere çalışır. İlk çağırıldığı zaman. Sonra public olan Constructor çalışır. Sonraki çalışmalarda sadece public olan constructor çalışır, static olan çalışmaz. 
        static Calisan()    //Static kurucuların erişim belirtiçleri ve geri dönüş tipi yoktur
        {
            calisan_sayisi = 0;
        }
        public Calisan(string isim, string soyisim, string departman)//static olmayan kurucuların erişim belirteci olabilir fakat geri dönüş tipi yoktur
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisan_sayisi ++;
        }

    }

    static class Islemler
    {
        public static long Topla (int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        
        public static long Cikar (int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}