using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                byte        => 1 Byte
                sbyte       => 1 Byte

                short       => 2 Byte
                ushort      => 2 Byte

                Int16       => 2 Byte
                int         => 4 Byte
                Int32       => 4 Byte
                Int64       => 8 Byte

                uint        => 4 Byte
                long        => 8 Byte
                ulong       => 8 Byte

                - Reel Sayılar
                float       => 4 Byte
                double      => 8 Byte
                decimal     => 16 Byte

                char        => 2 Byte
                string      => ... Byte (stringin boyutuna bağlı.)

                bool

                DateTime    DateTime dt = DateTime.Now
            */
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 't';
            object o3 = 72;
            object o4 = 7.2;

            // string ifadeler
            string str1 = string.Empty; // string str1 = null;
            str1 = "GuciGenk";
            string ad = "Guci";
            string soyad = "Genk";
            string tamİsim = ad + " " + soyad;

            // Değişken dönüşümleri
            string str72 = "72";
            int int72 = 72;
            string newVal = str72 + int72.ToString();

            Console.WriteLine(newVal);

            int testVal = int72 + Convert.ToInt32("3");
            Console.WriteLine(testVal);

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            string hourtime = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hourtime);
        }
    }
}
