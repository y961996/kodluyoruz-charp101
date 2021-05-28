using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 3;
            Console.WriteLine(x);
            Console.WriteLine(y);
            y = y + 2;
            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y *= 4;
            Console.WriteLine(y);
            y /= 3;
            Console.WriteLine(y);
            x -= 2;
            Console.WriteLine(x);

            // Matnıksal Operatorler
            bool isGuci = false;
            bool isGenk = true;
            bool isGuciGenk = isGuci && isGenk;
            Console.WriteLine(isGuciGenk);

            int small = 0;
            int big = 100;

            if(small < big) Console.WriteLine(small < big);

            small += 100;
            big -= 100;

            if(small < big) Console.WriteLine(small < big);
        }
    }
}
