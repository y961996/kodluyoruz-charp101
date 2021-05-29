using System;

namespace hazir_metotlar_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Biz Gucigenk, hoşgeldiniz.";
            string degisken2 = "biz Gucigenk, hoşgeldiniz.";

            // Length
            Console.WriteLine(degisken.Length);

            // ToLower ToUpper
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            // Concat
            Console.WriteLine(string.Concat(degisken, " Merhaba!"));

            // Compare, CompareTo
            Console.WriteLine(degisken.CompareTo(degisken2)); // 0 1 -1
            // Last param ignoreCase (Case sensitive)
            Console.WriteLine(string.Compare(degisken, degisken2, true));  
            Console.WriteLine(string.Compare(degisken, degisken2, false));

            // Contains
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("hoşgeldiniz."));
            Console.WriteLine(degisken.StartsWith("Merhaba!"));
            
            // IndexOf
            Console.WriteLine(degisken.IndexOf("Gucigenk"));
            Console.WriteLine(degisken.IndexOf("Olmayan string -1 döner"));
            Console.WriteLine(degisken.LastIndexOf("g"));

            // Insert
            Console.WriteLine(degisken.Insert(0, "Hola Amigo! "));

            // PadLeft, PadRight
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadLeft(30, '*'));
            Console.WriteLine(degisken.PadRight(50) + degisken2);
            Console.WriteLine(degisken.PadRight(50, '-') + degisken2);

            // Rempove
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(4, 5));
            Console.WriteLine(degisken.Remove(0, 1));

            // Replace
            Console.WriteLine(degisken.Replace("Gucigenk", "Gucibudusu"));
            Console.WriteLine(degisken.Replace(" ", "*"));

            // Split
            Console.WriteLine(degisken.Split(" ")[1]);

            // Substring
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4, 6));
        }
    }
}
