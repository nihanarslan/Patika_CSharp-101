using System;

namespace koleksiyonlar_soru_3 // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            char[] sesli_harfler = {'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü'};
            List<char> yazidaki_harfler = new List<char>();

            foreach (var item in sentence)
            {
                foreach (var harf in sesli_harfler)
                {
                    if(item == harf)
                    {
                        yazidaki_harfler.Add(harf);
                    }
                }
            }
            
            Console.WriteLine("********** SORT *************");
            
            yazidaki_harfler.Sort();

            foreach (var item in yazidaki_harfler)
            {
                Console.WriteLine(item);
            }
        }
    }
}