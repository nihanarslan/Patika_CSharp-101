using System;

namespace algoritmasorulari_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

            bool success1 = false;
            bool success2 = false;

            do{
                int n;

                Console.Write("Pozitif bir sayı giriniz: ");

                success1 = int.TryParse(Console.ReadLine(), out n);

                if(success1 && n > 0)
                {
                    Console.Write("Lütfen aralarında boşluklar olacak şekilde {0} adet pozitif sayı giriniz: ", n);
                    
                    try
                    {
                        List<int> a = Console.ReadLine().Trim().Split(' ').ToList().Select(temp => Convert.ToInt32(temp)).ToList();
                    
                        foreach (var item in a)
                        {
                            if((item > 0) && (item%2 == 0))
                                Console.WriteLine(item);
                            else if(item < 0)
                            {
                                Console.WriteLine("Geçersiz bir veri girdiniz. Pozitif sayı girdiğinizden emin olun");
                                Console.WriteLine("Tekrar deneyin");
                                a.Clear();
                                success2 = false;
                                break;
                            }
                            success2 = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Hata oluştu!");
                        Console.WriteLine("Hata mesajı:"+ex.Message);
                        Console.WriteLine("Tekrar deneyin");
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz bir veri girdiniz.");
                    Console.WriteLine("Tekrar deneyin");
                }
            }while(!success2);  //Başarılı bir şekilde tüm sayılar alınınca çık

        }
    }
}