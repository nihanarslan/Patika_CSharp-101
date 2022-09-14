using System;

namespace generic_list // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {

            //Syntax: List<T> class
            //System.Collections.Generic namespace altından gelir
            // T -> object türündedir. Liste içindeki nesnelerin tipini belirtir.

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            foreach (var sayi in sayiListesi)
                Console.WriteLine(sayi);
            foreach (var renk in renkListesi)
                Console.WriteLine(renk);

            Console.WriteLine("********************");

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Listeden eleman çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Liste içerisinde armama
            if (sayiListesi.Contains(10))
                Console.WriteLine("10 liste içerisinde bulunudu");

            //Eleman ile indexe erişme
            Console.WriteLine(renkListesi.BinarySearch("Kırmızı"));

            //Dizyi list'e çevirme
            string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };

            List<string> hayvan_listesi = new List<string>(hayvanlar);

            //Listeyi temizleme
            hayvan_listesi.Clear();

            //Liste içerisinde nesne tutma
            List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();

            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.Isim = "Ayşe";
            kullanici1.Soyisim = "Yılmaz";
            kullanici1.Yas=26;

            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici2.Isim = "Merve";
            kullanici2.Soyisim = "Çalışkan";
            kullanici2.Yas=26;

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();
            yeniListe.Add(new Kullanicilar{
                Isim = "Deniz",
                Soyisim = "Arda",
                Yas=24
            });

            foreach (var kullanici in kullaniciListesi)
            {
                Console.WriteLine("Kullanıcı Adı:"+kullanici.Isim);
                Console.WriteLine("Kullanıcı Soyadı:"+kullanici.Soyisim);
                Console.WriteLine("Kullanıcı yaşı:"+kullanici.Yas);
            }
        }
    }

    public class Kullanicilar
    {
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}