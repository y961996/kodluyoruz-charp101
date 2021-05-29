using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;

            Console.WriteLine(a + b);

            Console.WriteLine(sum(a, b));

            Metotlar m = new Metotlar();
            m.Log(Convert.ToString(sum(70, 2)));

            Console.WriteLine(sum(a, b));
            int result = m.ArttırveTopla(a, b);
            Console.WriteLine(result);
            Console.WriteLine(sum(a, b));

            Console.WriteLine(sum(a, b));
            int result2 = m.RefArttırVETopla(ref a, ref b);
            Console.WriteLine(result2);
            Console.WriteLine(sum(a, b));
        }

        public static int sum(int a, int b)
        {
            return a + b;
        }
    }

    class Metotlar
    {
        public void Log(string text)
        {
            Console.WriteLine(text);
        }

        public int ArttırveTopla(int val1, int val2)
        {
            val1++;
            val2++;
            return val1 + val2;
        }

        public int RefArttırVETopla(ref int val1, ref int val2)
        {
            val1++;
            val2++;
            return val1 + val2;
        }
    }
}
