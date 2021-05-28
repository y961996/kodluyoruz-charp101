using System;

namespace console_programlama
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("İsminizi Giriniz: ");
            string name = Console.ReadLine();
            Console.WriteLine("Soyisminizi Giriniz: ");
            string surname = Console.ReadLine();
            
            Console.WriteLine("Merhaba " + name + " " + surname);
        }
    }
}
