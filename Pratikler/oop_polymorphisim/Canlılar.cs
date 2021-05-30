using System;

namespace canlılar
{
    // sealed => Extend edilemez yapar class'ı;
    public class Canlılar
    {
        protected void Beslenme()
        {
          Console.WriteLine("Canlılar beslenir.");
        }
        protected void Solunum()
        {
          Console.WriteLine("Canlılar solunum yapar.");
        }
        protected void Boşaltım()
        {
          Console.WriteLine("Canlılar boşaltım yapar.");
        }

        public virtual void UyaranlaraTepki()
        {
          Console.WriteLine("Canlılar uyarılara tepki verir.");
        }
    }
}
