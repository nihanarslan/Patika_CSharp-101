using System;

namespace degiskenler{
    
    class Program {
        static void Main(String[] args) {

            byte b = 1;
            float f = 5; 
            bool b1 = true;
            
            char c = 'a';
            string word = "hello";
            int num1 = 5;

            Console.WriteLine("Hello, World.");
            Console.WriteLine(num1);

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            string str1 = "nihan";
            string str2 = "arslan";
            string name = str1 + " " + str2;

            Console.WriteLine(name);

            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine("str yenideger = " + yeniDeger);

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine("int21 = " + int21);

            int int22 = int20 + int.Parse(str20);

            string datetime1 = DateTime.Now.ToString("dd.mm.yyyy");
            Console.WriteLine(datetime1);
        }
    }

}
