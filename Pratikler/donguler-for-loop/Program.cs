using System;

namespace donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Bir sayı gir gardaş:");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayac; i++)
            {
                if(i % 2 == 1) Console.WriteLine(i);
            }

            int sumOdd = 0;
            int sumEven = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if(i % 2 == 0) sumEven += i;
                else sumOdd += i;
            }
            Console.WriteLine("Even sum: " + sumEven);
            Console.WriteLine("Odd sum: " + sumOdd);
            */

            for (int i = 1; i <= 10; i++)
            {
                if(i % 2 == 0) continue;
                if(i == 7) break;
                Console.WriteLine(i);
            }
        }
    }
}
