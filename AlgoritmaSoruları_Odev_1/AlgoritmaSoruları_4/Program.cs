namespace algoritmasoruları_4 // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın
            
            Console.WriteLine("Lütfen bir cümle yazınız.");
            string sentence = Console.ReadLine();

            Console.WriteLine("Toplam kelime sayısı: "+sentence.CountWords());
            Console.WriteLine("Toplam harf sayısı: "+sentence.CountCharacters());

        }
    }

    public static class MyExtensions
    {
        public static int CountWords(this string sentence)
        {
            List<string> list = sentence.Split(' ').ToList();
            int numberOfWords = list.Count;
            return numberOfWords;
        }

        public static int CountCharacters(this string sentence)
        {
            int numberOfCharacters = sentence.Length;
            return numberOfCharacters;
        }
    }
}