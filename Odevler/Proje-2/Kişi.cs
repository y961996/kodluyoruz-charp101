using System;

namespace Proje_2
{
  public class Kişi
  {
    private int id;
    private string isim;

    public int Id { get => id; set => id = value; }
    public string Isim { get => isim; set => isim = value; }

    public Kişi(){}

    public Kişi(int id, string isim)
    {
      this.id = id;
      this.isim = isim;
    }
  }
}