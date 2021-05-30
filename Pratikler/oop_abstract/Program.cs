using System;

namespace oop_abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new();
            Console.WriteLine(lion.MarkaNe().ToString());
            Console.WriteLine(lion.TekerlekSayısı().ToString());
            Console.WriteLine(lion.StandartRenk().ToString());
            Console.WriteLine("==================================");

            Civic civic = new();
            Console.WriteLine(civic.MarkaNe().ToString());
            Console.WriteLine(civic.TekerlekSayısı().ToString());
            Console.WriteLine(civic.StandartRenk().ToString());
            Console.WriteLine("==================================");

            NewLion newLion= new();
            Console.WriteLine(newLion.MarkaNe().ToString());
            Console.WriteLine(newLion.TekerlekSayısı().ToString());
            Console.WriteLine(newLion.StandartRenk().ToString());
            Console.WriteLine("==================================");

            NewCivic newCivic = new();
            Console.WriteLine(newCivic.MarkaNe().ToString());
            Console.WriteLine(newCivic.TekerlekSayısı().ToString());
            Console.WriteLine(newCivic.StandartRenk().ToString());
            Console.WriteLine("==================================");
        }
    }
}
