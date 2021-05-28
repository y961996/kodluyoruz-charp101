using System;

namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Bir sayı gir gardaş:");
            int sayı = int.Parse(Console.ReadLine());
            int sayaç = 1;
            int sum = 0;
            while(sayaç <= sayı)
            {
                sum += sayaç;
                sayaç++;
            }

            Console.WriteLine(sum / sayı);
            */

            char c = 'a';
            while(c <= 'z')
            {
                Console.Write(c);
                c++;
            }

            Console.WriteLine();
            string[] cars = {"asd", "asdsada", "wetsdf", "gsd"};
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
