using System;
using canlılar;

namespace hayvanlar
{
    public class Hayvanlar:Canlılar
    {
        protected void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adapte olur.");
        }

        public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki();
            Console.WriteLine("Hayvanlar temasa tepki verir.");
        }
    }

    public class Sürüngen:Hayvanlar
    {
        public Sürüngen()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Boşaltım();
            base.Solunum();
        }
        public void Sürünme()
        {
          Console.WriteLine("Sürüngenler sürünerek hareket ederler.");
        }
    }

    public class Kuşlar:Hayvanlar
    {
        public Kuşlar()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Boşaltım();
            base.Solunum();
            base.UyaranlaraTepki();
        }
        public void Uçar()
        {
            Console.WriteLine("Kuşlar uçarlar.");
        }
    }
}
