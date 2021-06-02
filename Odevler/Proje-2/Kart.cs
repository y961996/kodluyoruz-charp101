using System;

namespace Proje_2{
  public class Kart
  {
    private string başlık;
    private string içerik;
    private Kişi atananKişi;
    private KartBüyüklük büyüklük;

    public string Başlık { get => başlık; set => başlık = value; }
    public string Içerik { get => içerik; set => içerik = value; }
    public Kişi AtananKişi { get => atananKişi; set => atananKişi = value; }
    public KartBüyüklük Büyüklük { get => büyüklük; set => büyüklük = value; }

    public Kart(string başlık, string içerik, Kişi atananKişi, KartBüyüklük büyüklük)
    {
      this.başlık = başlık;
      this.içerik = içerik;
      this.atananKişi = atananKişi;
      this.büyüklük = büyüklük;
    }
  }

  public enum KartBüyüklük
  {
    XS,
    S,
    M,
    L,
    XL
  }
}