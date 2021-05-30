using System;

namespace oop_abstract
{
  public class Lion : IOtomobil
  {
    public Marka MarkaNe()
    {
      return Marka.Ferrari;
    }

    public Renk StandartRenk()
    {
      return Renk.Beyaz;
    }

    public int TekerlekSayısı()
    {
      return 4;
    }
  }
}