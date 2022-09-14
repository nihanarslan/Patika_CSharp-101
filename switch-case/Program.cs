﻿using System;

namespace switch_case // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            int mounth = DateTime.Now.Month;

            // switch (mounth)
            // {
            //     case 1:
            //         Console.WriteLine("Ocak ayındasınız");
            //         break;
            //     case 2:
            //         Console.WriteLine("Şubat ayındasınız");
            //         break;
            //     case 4:
            //         Console.WriteLine("Nisan ayındasınız");
            //         break;
            //     case 5:
            //         Console.WriteLine("Mart ayındasınız");
            //         break;
            //     case 8:
            //         Console.WriteLine("Ağustos ayındasınız");
            //         break;

            //     default:
            //         Console.WriteLine("Yanlış giriş");
            //         break;
            // }
            
            switch(mounth)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış Mevsimindesiniz");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar Mevsimindesiniz");
                    break;
                case 6:
                case 7:
                case 8: 
                    Console.WriteLine("Yaz Mevsimindesiniz");
                    break;
                case 9:
                case 10: 
                case 11:
                    Console.WriteLine("Sonbahar Mevsimindesiniz");
                    break;
                    
                default:
                    break;
            }
        }
    }
}