using System;

namespace Array_sinif_metodlari // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sorting
            int[] sayiDizisi = {23, 12, 4, 86, 72, 3 ,11, 17};

            Console.WriteLine("Sıralamadan önceki liste");

            foreach (var item in sayiDizisi)
                Console.WriteLine(item);

            Console.WriteLine("Sıralamadan sonraki liste");
            Array.Sort(sayiDizisi);

            foreach (var item in sayiDizisi)
                Console.WriteLine(item);

            //Clear
            Console.WriteLine("Array clear'dan sonraki liste");
            Array.Clear(sayiDizisi,2,2);
            foreach (var item in sayiDizisi)
                Console.WriteLine(item);

            //Reverse
            Console.WriteLine("Reverse işleminden sonraki liste");
            Array.Reverse(sayiDizisi);

            foreach (var item in sayiDizisi)
                Console.WriteLine(item);

            //IndexOf
            Console.WriteLine("Index bulma indexof");
            Console.WriteLine(Array.IndexOf(sayiDizisi,23));

            //Resize
            Console.WriteLine("Resize işlemi");
            Array.Resize<int>(ref sayiDizisi,9);

            sayiDizisi[8]=99;
            foreach (var item in sayiDizisi)
                Console.WriteLine(item);

        }
    }
}