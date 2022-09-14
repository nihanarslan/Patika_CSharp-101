using System;
using System.Collections;

namespace array_list // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collections namespace altında bulunur

            ArrayList list = new ArrayList();
            //list.Add("Ayşe");
            //list.Add(2);
            //list.Add(true);
            //list.Add('A');
            
            //Listedeki elemanlara erişim
            //Console.WriteLine(list[1]);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //Addrange
            Console.WriteLine("****** Add Range *****");
            string[] renkler = {"kırmızı", "sarı", "yeşil"};
            //list.AddRange(renkler);

            List<int> sayilar = new List<int>(){1,8,3,7,9,92,5};

            list.AddRange(sayilar);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //Sıralama - Sorting
            Console.WriteLine("*********Sorting*********");

            list.Sort();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //Binary Search
            Console.WriteLine("*********Binary Search*********");
            Console.WriteLine(list.BinarySearch(9));

            //Reverse
            Console.WriteLine("*********Reverse*********");
            list.Reverse();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //Clear
            Console.WriteLine("*********Clear*********");
            list.Clear();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}