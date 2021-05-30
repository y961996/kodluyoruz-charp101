using System;
using canlılar;

namespace bitkiler
{
    public class Bitkiler:Canlılar
    {
        protected void Fotosentez()
        {
          Console.WriteLine("Bitkiler fotosentez yapar.");
        }
    }

    public class TohumluBitkiler:Bitkiler
    {
        public TohumluBitkiler()
        {
            base.Fotosentez();
            base.Beslenme();
            base.Boşaltım();
            base.Solunum();
        }
        public void TohumlaÜreme()
        {
            Console.WriteLine("Tohumlu bitkiler tohumla çoğalır.");
        }
    }

    public class TohumsuzBitkiler:Bitkiler
    {
        public TohumsuzBitkiler()
        {
            base.Fotosentez();
            base.Beslenme();
            base.Boşaltım();
            base.Solunum();
        }
        public void SprolaÜreme()
        {
          Console.WriteLine("Tohumsuz bitkiler sporla çoğalır.");
        }
    }
}
