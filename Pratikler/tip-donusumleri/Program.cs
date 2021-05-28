using System;

namespace tip_donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversion
            Console.WriteLine("Implicit Conversion");
            Console.WriteLine("-----------------------------------------");

            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine(d);

            long h = d;
            Console.WriteLine(h);

            float i = h;
            Console.WriteLine(i);

            string e = "guci";
            char f = 'g';

            object g = e + f + d;
            Console.WriteLine(g);

            // Explicit Conversion
            Console.WriteLine("Explicit Conversion");
            Console.WriteLine("-----------------------------------------");
            
            int x = 4;
            byte y = (byte)x;
            Console.WriteLine(y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine(z);
            Console.WriteLine(t);

            float w = 10.3f;
            byte xb = (byte)w;
            Console.WriteLine(xb);

            // ToString metodu
            Console.WriteLine("ToString Metodu");
            Console.WriteLine("-----------------------------------------");

            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine(yy);

            string xs = 12.5f.ToString();
            Console.WriteLine(xs);

            // System.Convert
            Console.WriteLine("System.Convert metodu");
            Console.WriteLine("-----------------------------------------");

            string s1 = "10", s2 = "20";
            int si1, si2;
            int toplam;

            si1 = Convert.ToInt32(s1);
            si2 = Convert.ToInt32(s2);
            toplam = si1 + si2;
            Console.WriteLine(toplam);

            // Parse
            Console.WriteLine("Parse metodu");
            Console.WriteLine("-----------------------------------------");

            ParseMethod();
        }

        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.72";
            int rakam1;
            double rakam2;

            rakam1 = Int32.Parse(metin1);
            Console.WriteLine(rakam1);

            rakam2 = Double.Parse(metin2);
            Console.WriteLine(rakam2);
        }
    }
}
