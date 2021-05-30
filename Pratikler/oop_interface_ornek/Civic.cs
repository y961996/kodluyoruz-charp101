using System;

namespace oop_interface_ornek
{
  public class Civic : IOtomobil
  {
    public Marka MarkaNe()
    {
      return Marka.Ford;
    }

    public Renk StandartRenk()
    {
      return Renk.Gri;
    }

    public int TekerlekSayısı()
    {
      return 4;
    }
  }
}