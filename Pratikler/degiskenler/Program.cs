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
        }
    }
}
