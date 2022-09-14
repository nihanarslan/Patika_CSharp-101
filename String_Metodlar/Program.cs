using System;

namespace string_metodlar // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp, Hoşgeldiniz!";
            string degisken2 = "Dersimiz CSharp";
            string degisken3 = "dersimiz CSharp, Hoşgeldiniz!";

            //Length
            Console.WriteLine("Karakter sayısı:"+ degisken.Length);

            //toupper tolower
            Console.WriteLine("toupper : "+ degisken.ToUpper());
            Console.WriteLine("tolower : "+ degisken.ToLower());

            //Concat
            Console.WriteLine("concat : "+ string.Concat(degisken," merhaba"));

            //Compare, compareto    
            Console.WriteLine("compare to : "+degisken.CompareTo(degisken2));   //returns 0,1,-1
            Console.WriteLine("compare: "+String.Compare(degisken,degisken3,true)); //ignore case true
            Console.WriteLine("compare: "+String.Compare(degisken,degisken3,false));//ignore case false

            //contains
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine("ends with "+ degisken.EndsWith("Hoşgeldiniz!"));
            Console.WriteLine("starts with " +degisken.StartsWith("Merhaba"));

            //Indexof
            Console.WriteLine(degisken.IndexOf("CS"));
            Console.WriteLine(degisken.IndexOf("test"));
            Console.WriteLine("last index of i : "+degisken.LastIndexOf("i"));

            //Insert
            Console.WriteLine(degisken.Insert(0,"Merhaba!"));

            //Padleft, padright
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadLeft(30, '*'));
            Console.WriteLine(degisken.PadRight(50) + degisken2);
            Console.WriteLine(degisken.PadRight(50,'-') + degisken2);

            //Remove
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3));    //5. indexten başlayıp 3 karakter sil
            Console.WriteLine(degisken.Remove(0,1));

            //Replace
            Console.WriteLine(degisken.Replace("CSharp", "C#"));
            Console.WriteLine(degisken.Replace(" ", "*"));

            //Split
            Console.WriteLine(degisken.Split(' ')[1]);

            //Substring
            Console.WriteLine(degisken.Substring(4));   //4. indexten sonuna kadar getir.
            Console.WriteLine(degisken.Substring(4,6));   //4. indexten başlayıp 6 karakter getir.
            

        }
    }
}