using System;
using System.Collections.Generic;

namespace Proje_1
{
  public class TelefonRehberi
  {
    private List<Kişi> rehber;
    public List<Kişi> Rehber { get => rehber; set => rehber = value; }

    public TelefonRehberi(){
      rehber = new List<Kişi>();

      rehber.Add(new Kişi("Elpis", "Brianna", 5555555555));
      rehber.Add(new Kişi("Earline", "Shandar", 1234567890));
      rehber.Add(new Kişi("Halim", "Annice", 5515510909));
      rehber.Add(new Kişi("Yelizaveta", "Jouko", 5055051122));
      rehber.Add(new Kişi("Adriano", "Jenni", 5068963256));
    }

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
      if(IsimVeyaSoyisimeGoreAra(input)){
        int idx = returnIndexIsimSoyisim(input);
        string isimSoyisim = this.rehber[idx].Isim + " " + this.rehber[idx].Soyisim;
        Console.WriteLine(isimSoyisim + " isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
        string opt = Console.ReadLine();
        if(opt.Equals("y")){
          for(int i = 0; i < this.rehber.Count; i++){
            if(this.rehber[i].Isim.Equals(input) || this.rehber[i].Soyisim.Equals(input)){
              this.rehber.RemoveAt(i);
            }
          }
        }
      } 
      else
      {
        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
        Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
        Console.WriteLine("* Yeniden denemek için      : (2)");
        string scnk = Console.ReadLine();
        if(scnk.Equals("1")) return;
        else if(scnk.Equals("2")) RehberdenKişiSil();
        else Console.WriteLine("Yanlis secim !");
      }
    }

    private bool IsimVeyaSoyisimeGoreAra(string s){
      for(int i = 0; i < this.rehber.Count; i++){
        if(this.rehber[i].Isim.Equals(s) || this.rehber[i].Soyisim.Equals(s)) return true;
      }
      return false;
    }

    private int returnIndexIsimSoyisim(string s){
      for(int i = 0; i < this.rehber.Count; i++){
        if(this.rehber[i].Isim.Equals(s) || this.rehber[i].Soyisim.Equals(s)) return i;
      }
      return -1;
    }

    public void NumaraGüncelle()
    {
      Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
      string input = Console.ReadLine();
      if(IsimVeyaSoyisimeGoreAra(input))
      {
        int idx = returnIndexIsimSoyisim(input);
        // Numarayı güncelle.
        string isimSoyisim = this.rehber[idx].Isim + " " +  this.rehber[idx].Soyisim;
        Console.Write(isimSoyisim + " adli kisinin yeni numarasini giriniz: ");
        long yeniNumara = long.Parse(Console.ReadLine());
        this.rehber[idx].Numara = yeniNumara;
        Console.WriteLine(isimSoyisim + " adli kisinin numarasi basariyla guncellendi.\n");
      }
      else
      {
        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
        Console.WriteLine("* Güncellemeyi sonlandırmak için    : (1)");
        Console.WriteLine("* Yeniden denemek için              : (2)");
        string scnk = Console.ReadLine();
        if(scnk.Equals("1")) return;
        else if(scnk.Equals("2")) NumaraGüncelle();
        else Console.WriteLine("Yanlis secim !");
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

    public List<int> RehberdeAramaYapma()
    {
      List<int> idxs = new List<int>();

      Console.WriteLine();

      for(){
        
      }

      return idxs;
    }
  }
}