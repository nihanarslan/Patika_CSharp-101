using System;

namespace algoritmasoruları_2 
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

            bool success1 = false;
            bool success2 = false;
            
            do{
                Console.Write("Lütfen aralarında boşluklar olacak şekilde iki adet pozitif sayı giriniz: ");

                try
                {
                    List<int> nm = Console.ReadLine().Trim().Split(' ').ToList().Select(temp => Convert.ToInt32(temp)).ToList();
                    
                    bool state = nm.ContainsNegative();

                    if(!state)
                    {
                        Console.Write("Lütfen aralarında boşluklar olacak şekilde {0} adet pozitif sayı giriniz: ", nm[0]);

                        try
                        {
                            List<int> a = Console.ReadLine().Trim().Split(' ').ToList().Select(temp => Convert.ToInt32(temp)).ToList();

                            bool state2 = a.ContainsNegative();
                            if(!state2)
                            {
                                foreach (var item in a)
                                {
                                    if(item%nm[1] == 0)
                                        Console.WriteLine(item);
                                }
                                success2 = true;
                            }
                            else
                            {
                                Console.WriteLine("Geçersiz bir veri girdiniz. Pozitif sayı girdiğinizden emin olun");
                                Console.WriteLine("Tekrar deneyin");
                                a.Clear();
                                success2 = false;
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Hata oluştu!");
                            Console.WriteLine("Hata mesajı:"+ex.Message);
                            Console.WriteLine("Tekrar deneyin");
                        }

                    }
                    else{
                        Console.WriteLine("Geçersiz bir veri girdiniz. Pozitif sayı girdiğinizden emin olun");
                        Console.WriteLine("Tekrar deneyin");
                        nm.Clear();
                        success2 = false;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata oluştu!");
                    Console.WriteLine("Hata mesajı:"+ex.Message);
                    Console.WriteLine("Tekrar deneyin");
                }
                
            }while(!success2);  //Başarılı bir şekilde tüm sayılar alınınca çık

        }
    }

    public static class MyExtensions
    {
        public static bool ContainsNegative(this List<int> list)
        {
            foreach (var item in list)
            {
                if(item < 0)
                    return true;
            }
            return false;
        }
    }

    
}
