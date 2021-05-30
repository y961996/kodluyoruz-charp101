using System;
using canlılar;
using hayvanlar;
using bitkiler;

namespace oop_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            TohumluBitkiler tohumluBitki = new();
            //tohumluBitki.Beslenme();
            //tohumluBitki.Solunum();
            //tohumluBitki.Boşaltım();
            //tohumluBitki.Fotosentez();
            tohumluBitki.TohumlaÜreme();

            Console.WriteLine("=========================");

            Kuşlar martı = new();
            //martı.Solunum();
            //martı.Beslenme();
            //martı.Boşaltım();
            //martı.Adaptasyon();
            martı.Uçar();
        }
    }
}
