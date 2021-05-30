using System;

namespace oop_interface_ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new();
            Console.WriteLine(lion.MarkaNe().ToString());
            Console.WriteLine(lion.TekerlekSayısı().ToString());
            Console.WriteLine(lion.StandartRenk().ToString());

            Civic civic = new();
            Console.WriteLine(civic.MarkaNe().ToString());
            Console.WriteLine(civic.TekerlekSayısı().ToString());
            Console.WriteLine(civic.StandartRenk().ToString());
        }
    }
}
