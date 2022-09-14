using System;

namespace algoritmasoruları_3 // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
            
            Console.Write("Lütfen bir sayı girin: ");
            int n;
            bool isSuccess = int.TryParse(Console.ReadLine(), out n);

            if(isSuccess)
            {
                try
                {
                    string[] arr = new string[n];

                    Console.Write("Lütfen {0} adet kelime girin: ", n);

                    arr = Console.ReadLine().Split(' ').ToArray();
                    Array.Reverse(arr);
                    foreach (var item in arr)
                    {
                        Console.WriteLine(item + " ");
                    }
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("Hatalı veri girişi");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata oluştu.");
                    Console.WriteLine("Hata detayı: "+ex.Message);
                }
                
            }
            else{
                Console.Write("Hatalı veri girişi");
            }
        }
    }
}