using System;

namespace oop_abstract
{
  public class Corolla : IOtomobil
  {
    public Marka MarkaNe()
    {
      return Marka.Toyota;
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