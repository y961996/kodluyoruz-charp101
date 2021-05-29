using System;

namespace diziler_array_sinif_metodlari
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = {2, 72, 13, 69, 85, 123, 1, 17};
            
            // Sıralanmamış dizi
            foreach (var num in dizi)
                Console.Write(num + ",");
            Console.WriteLine();

            // Sıralanmış dizi
            Array.Sort(dizi);

            foreach (var num in dizi)
                Console.Write(num + ",");
            Console.WriteLine();

            // Clear
            Array.Clear(dizi, 2, 2);

            foreach (var num in dizi)
                Console.Write(num + ",");
            Console.WriteLine();

            // Reverse
            Array.Reverse(dizi);

            foreach (var num in dizi)
                Console.Write(num + ",");
            Console.WriteLine();

            // indexOf
            Console.WriteLine(Array.IndexOf(dizi, 72));

            // Resize
            Array.Resize<int>(ref dizi, 11);
            dizi[9] = 99;
            
            foreach (var num in dizi)
                Console.Write(num + ",");
            Console.WriteLine();
        }
    }
}
