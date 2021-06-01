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