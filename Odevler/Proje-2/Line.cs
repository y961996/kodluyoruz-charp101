using System;
using System.Collections.Generic;

namespace Proje_2
{
  public class Line
  {
    private string isim;
    private List<Kart> kartlar;

    public string Isim { get => isim; set => isim = value; }
    public List<Kart> Kartlar { get => kartlar; set => kartlar = value; }

    public Line(string isim)
    {
      this.isim = isim;
      kartlar = new List<Kart>();
    }
  }
}