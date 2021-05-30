using System;

namespace oop_abstract
{
  public class NewLion : Otomobil
  {
    public override Marka MarkaNe()
    {
      return Marka.Ferrari;
    }

    public override Renk StandartRenk()
    {
      return Renk.Gri;
    }
  }
}