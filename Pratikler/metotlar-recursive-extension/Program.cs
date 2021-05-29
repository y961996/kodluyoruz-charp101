using System;

namespace metotlar_recursive_extension
{
    class Program
    {
        static void Main(string[] args)
        {
            // Recursive
            int res = 1;
            for (int i = 1; i < 5; i++)
                res = res * 3;
            Console.WriteLine(res);

            İşlemler iş = new();
            Console.WriteLine(iş.Expo(3, 4));
            Console.WriteLine(iş.Expo(3, 0));
            Console.WriteLine(iş.Expo(3, 1));

            // Extension
            string ifade = "Guci Genk";
            bool sonuç = ifade.HasBlank();
            Console.WriteLine(sonuç);
            if(sonuç)
            {
                Console.WriteLine(ifade.RemoveBlanks());
                Console.WriteLine(ifade.ToUpperLetter());
                Console.WriteLine(ifade.ToLowerLetter());
            }

            int[] nums = {9, 3, 2, 6, 8, 4, 5, 0};
            nums.PrintIntArray();
            nums.SortArray();
            nums.PrintIntArray();

            int numOdd = 5;
            Console.WriteLine(numOdd.IsEven());
            int numEven = 72;
            Console.WriteLine(numEven.IsEven());

            Console.WriteLine(ifade.GetFirstChar());
        }
    }

    public static class Extensions
    {
        public static bool HasBlank(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveBlanks(this string param)
        {
            string[] dizi = param.Split(" ");
            return String.Join("", dizi);
        }

        public static string ToUpperLetter(this string param)
        {
            return param.ToUpper();
        }

        public static string ToLowerLetter(this string param)
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }
        public static void PrintIntArray(this int[] param)
        {
            foreach (var item in param)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public static bool IsEven(this int param)
        {
            return param % 2 == 0;
        }

        public static string GetFirstChar(this string param)
        {
            return param.Substring(0, 1);
        }
    }

    public class İşlemler
    {
        public int Expo(int sayı, int üs)
        {
            if(üs == 0) return 1;
            if(üs < 2) return sayı; 
            return Expo(sayı, üs-1) * sayı;
        }
    }
}
