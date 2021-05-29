using System;
using System.Collections.Generic;

namespace Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen bir cümle giriniz: ");
            string cümle = Console.ReadLine();
            List<char> sesliler = new List<char>();
            for (int i = 0; i < cümle.Length; i++)
            {
                if(IsSesli(cümle[i])) sesliler.Add(cümle[i]);
            }
            char[] sesliDizi = sesliler.ToArray();

            foreach(char s in sesliDizi)
            {
                Console.Write(s);
            }
            Console.WriteLine();

            Array.Sort(sesliDizi);

            foreach(char s in sesliDizi)
            {
                Console.Write(s);
            }
            Console.WriteLine();
        }

        public static bool IsSesli(char c)
        {
            char[] sesliler = {'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü'};
            foreach(var sesli in sesliler)
            {
                if(c == sesli) return true;
            }
            return false;
        }
    }
}
