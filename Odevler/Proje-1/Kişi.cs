using System;

namespace Proje_1
{
  public class Kişi
  {
    private string isim;
    private string soyisim;
    private long numara;

    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public long Numara { get => numara; set => numara = value; }

    public Kişi(){}
    public Kişi(string isim, string soyisim, long numara)
    {
      this.isim = isim;
      this. soyisim = soyisim;
      this.numara = numara;
    }

    public void KişiBilgileri()
    {
      Console.WriteLine("Kişi Bilgilerini yazdır...");
    }
  }
}