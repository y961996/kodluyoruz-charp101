using System;

namespace oop_interface_ornek
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