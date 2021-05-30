using System;
using System.Collections.Generic;

namespace Proje_1
{
  public class TelefonRehberi
  {
    private List<Kişi> rehber;
    public List<Kişi> Rehber { get => rehber; set => rehber = value; }

    public TelefonRehberi(){}

    public void RehbereKişiEkle()
    {
      // Kişi bilgilerini kullanıcıdan al burada.
      Console.Write("Lütfen isim giriniz: ");
      string isim = Console.ReadLine();
      Console.Write("Lütfen soyisim giriniz: ");
      string soyisim = Console.ReadLine();
      Console.Write("Lütfen telefon numarası giriniz: ");
      long numara = long.Parse(Console.ReadLine());

      Kişi kişi = new(isim, soyisim, numara);
      this.rehber.Add(kişi);

      Console.WriteLine();
    }

    public void RehberdenKişiSil()
    {
      Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
      string input = Console.ReadLine();
      if(RehberdeAramaYapma()){
        Console.WriteLine(input + " isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
      } 
      else
      {
        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
        Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
        Console.WriteLine("* Yeniden denemek için      : (2)");
      }
    }

    public void NumaraGüncelle()
    {
      Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
      string input = Console.ReadLine();
      if(RehberdeAramaYapma())
      {
        // Numarayı güncelle.
      }
      else
      {
        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
        Console.WriteLine("* Güncellemeyi sonlandırmak için    : (1)");
        Console.WriteLine("* Yeniden denemek için              : (2)");
      }
    }

    public void RehberiListele()
    {
      Console.WriteLine("Telefon Rehberi");
      Console.WriteLine("**********************************************");

      foreach (var kullanıcı in rehber)
      {
        Console.WriteLine("isim: " + kullanıcı.Isim);
        Console.WriteLine("Soyisim: " + kullanıcı.Soyisim);
        Console.WriteLine("Telefon Numarası: " + kullanıcı.Numara);
        Console.WriteLine("-");
      }

      Console.WriteLine();
    }

    public bool RehberdeAramaYapma()
    {
      return false;
    }
  }
}