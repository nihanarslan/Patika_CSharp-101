using System;

namespace Hata_Yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            // try
            // {
            //     Console.WriteLine("Bir sayı giriniz:");
            //     int sayı = Convert.ToInt32(Console.ReadLine());
            //     Console.WriteLine("Girmiş olduğunuz sayı: " + sayı);
            // }
            // catch(Exception ex )
            // {
            //     Console.WriteLine("Hata:" + ex.Message.ToString());
            // }
            // finally
            // {
            //     Console.WriteLine("İşlem tamamlandı");
            // }


            // try
            // {
            //      int a = int.Parse(null);
            
            // }
            // catch (ArgumentNullException ex)
            // {
            //     Console.WriteLine("Boş değer girdiniz.");
            //     Console.WriteLine(ex); 
            // }

            // try
            // {
            //     int a = int.Parse("test");
            // }
            // catch (FormatException ex)
            // {
            //     Console.WriteLine("Veri tipi uygun değil.");
            //     Console.WriteLine(ex); 
            // }
            
            try
            {
                int a = int.Parse("-20000000000");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil.");
                Console.WriteLine(ex); 
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("çok küçük ya da çok büyük değer girdiniz.");
                Console.WriteLine(ex); 
            }
            finally
            {
                Console.WriteLine("işlem başarıyla tamamlandı");
            }


        }
    }
}