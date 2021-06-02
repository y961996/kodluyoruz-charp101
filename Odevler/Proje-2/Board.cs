using System;

namespace Proje_2
{
  public class Board
  {
    private Line todo;
    private Line inProgress;
    private Line done;

    public Kişi[] takımdakiKişiler = {
      new Kişi(0, "Ümit Tosun"),
      new Kişi(1, "Tevfik Sokullu"),
      new Kişi(2, "Burçin Özoguz"),
      new Kişi(3, "Sabah Gülek"),
      new Kişi(4, "Esen Akbulut")
    };

    public Line Todo { get => todo; set => todo = value; }
    public Line InProgress { get => inProgress; set => inProgress = value; }
    public Line Done { get => done; set => done = value; }

    public Board()
    {
      Kart defaultKart1 = new Kart("Başlık1", "İçerik çok dolu değil.", takımdakiKişiler[0], KartBüyüklük.S);
      Kart defaultKart2 = new Kart("Başlık2", "İçerik çok dolu.", takımdakiKişiler[1], KartBüyüklük.L);  
      Kart defaultKart3 = new Kart("Başlık3", "İçerik boş.", takımdakiKişiler[3], KartBüyüklük.XS);

      todo = new Line("TODO Line");
      inProgress = new Line("IN PROGRESS Line");
      done = new Line("DONE Line");

      todo.Kartlar.Add(defaultKart1);
      todo.Kartlar.Add(defaultKart3);

      InProgress.Kartlar.Add(defaultKart2);
    }
    internal void BoardListele()
    {
      Console.WriteLine();

      PrintKartLine(todo);
      Console.WriteLine("\n");

      PrintKartLine(inProgress);
      Console.WriteLine("\n");

      PrintKartLine(done);
      Console.WriteLine();
    }

    private void PrintKartLine(Line line)
    {
      Console.WriteLine(line.Isim);
      Console.WriteLine("************************");
      if(line.Kartlar.Count <= 0)
      {
        Console.WriteLine("~ BOŞ ~");
      }
      else
      {
        int counter = 1;
        foreach(var l in line.Kartlar)
        {
          Console.WriteLine("Başlık       :" + l.Başlık);
          Console.WriteLine("İçerik       :" + l.Içerik);
          Console.WriteLine("Atanan Kişi  :" + l.AtananKişi.Isim);
          Console.WriteLine("Büyüklük     :" + l.Büyüklük);
          if(counter < line.Kartlar.Count) Console.WriteLine("-");
          counter++;
        }
      }
    }

    internal void KartEkle()
    {
      Console.Write("Başlık Giriniz                                  :");
      string başlık = Console.ReadLine();

      Console.Write("İçerik Giriniz                                  :");
      string içerik = Console.ReadLine();

      Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
      KartBüyüklük büyüklük = (KartBüyüklük)int.Parse(Console.ReadLine());

      Console.Write("Kişi Seçiniz -> (ID)                            :");
      int id = int.Parse(Console.ReadLine());
      int found = -1;
      for(int i = 0; i < takımdakiKişiler.Length; i++)
      {
        if(takımdakiKişiler[i].Id == id)
        {
          found = takımdakiKişiler[i].Id;
          break;
        } 
      }

      if(found == -1) 
      {
        Console.WriteLine("Hatali kullanici ID'si girdiniz. İşlem sonlandiriliyor...");
        return;
      }

      todo.Kartlar.Add(new Kart(başlık, içerik, takımdakiKişiler[found], büyüklük));
    }

    internal void KartSil()
    {
      Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
      Console.Write("Lütfen kart başlığını yazınız: ");
      string başlık = Console.ReadLine();
      if(!KartAra(başlık))
      {
        Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
        Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
        Console.WriteLine("* Yeniden denemek için : (2)");
        string option = Console.ReadLine();
        if(option.Equals("1")) return;
        else if(option.Equals("2")) KartSil();
        else
        {
          Console.WriteLine("Yanlis secim !");
          return;
        }
      }
      else
      {
        todo.Kartlar.RemoveAll(x => x.Başlık.Equals(başlık));
        inProgress.Kartlar.RemoveAll(x => x.Başlık.Equals(başlık));
        done.Kartlar.RemoveAll(x => x.Başlık.Equals(başlık));
      }

    }

    private bool KartAra(string başlık)
    {
      foreach(var k in todo.Kartlar)
      {
        if(k.Başlık.Equals(başlık)) return true;
      }

      foreach(var k in inProgress.Kartlar)
      {
        if(k.Başlık.Equals(başlık)) return true;
      }

      foreach(var k in done.Kartlar)
      {
        if(k.Başlık.Equals(başlık)) return true;
      }

      return false;
    }

    internal void KartTaşı()
    {
      Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
      Console.Write("Lütfen kart başlığını yazınız: ");
      string başlık = Console.ReadLine();
      if(!KartAra(başlık))
      {
        Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
        Console.WriteLine("* Taşımayı sonlandırmak için : (1)");
        Console.WriteLine("* Yeniden denemek için : (2)");
        string option = Console.ReadLine();
        if(option.Equals("1")) return;
        else if(option.Equals("2")) KartTaşı();
        else
        {
          Console.WriteLine("Yanlis secim !");
          return;
        }
      }
      else
      {
        Kart kart = KartıBul(başlık);
        Line line = KartLineBul(başlık);
        Console.WriteLine("Bulunan Kart Bilgileri:");
        Console.WriteLine("**************************************");
        Console.WriteLine("Başlık      :" + kart.Başlık);
        Console.WriteLine("İçerik      :" + kart.Içerik);
        Console.WriteLine("Atanan Kişi :" + kart.AtananKişi.Isim);
        Console.WriteLine("Büyüklük    :" + kart.Büyüklük);
        Console.WriteLine("Line        :" + line.Isim);

        Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz: ");
        Console.WriteLine("(1) TODO");
        Console.WriteLine("(2) IN PROGRESS");
        Console.WriteLine("(3) DONE");
        int taşınacakLine = int.Parse(Console.ReadLine());

        KartTaşıHandler(başlık, taşınacakLine);

        BoardListele();
      }
    }

    private void KartTaşıHandler(string başlık, int line)
    {
      foreach(var k in todo.Kartlar)
      {
        if(k.Başlık.Equals(başlık))
        {
          if(line == 1)
          {
            todo.Kartlar.Add(k);
            todo.Kartlar.Remove(k);
            break;

          }
          else if(line == 2)
          {
            inProgress.Kartlar.Add(k);
            todo.Kartlar.Remove(k);
            break;
          }
          else if(line == 3)
          {
            done.Kartlar.Add(k);
            todo.Kartlar.Remove(k);
            break;
          }
          else
          {
            Console.WriteLine("Yanlış Line seçtiniz.");
            break;
          }
        }
      }

      foreach(var k in inProgress.Kartlar)
      {
        if(k.Başlık.Equals(başlık))
        {
          if(line == 1)
          {
            todo.Kartlar.Add(k);
            inProgress.Kartlar.Remove(k);
            break;
          }
          else if(line == 2)
          {
            inProgress.Kartlar.Add(k);
            inProgress.Kartlar.Remove(k);
            break;
          }
          else if(line == 3)
          {
            done.Kartlar.Add(k);
            inProgress.Kartlar.Remove(k);
            break;
          }
          else
          {
            Console.WriteLine("Yanlış Line seçtiniz.");
            break;
          }
        } 
      }

      foreach(var k in done.Kartlar)
      {
        if(k.Başlık.Equals(başlık))
        {
          if(line == 1)
          {
            todo.Kartlar.Add(k);
            done.Kartlar.Remove(k);
            break;
          }
          else if(line == 2)
          {
            inProgress.Kartlar.Add(k);
            done.Kartlar.Remove(k);
            break;
          }
          else if(line == 3)
          {
            done.Kartlar.Add(k);
            done.Kartlar.Remove(k);
            break;
          }
          else
          {
            Console.WriteLine("Yanlış Line seçtiniz.");
            break;
          }
        }
      }
    }

    private Line KartLineBul(string başlık)
    {
      foreach(var k in todo.Kartlar)
      {
        if(k.Başlık.Equals(başlık)) return todo;
      }

      foreach(var k in inProgress.Kartlar)
      {
        if(k.Başlık.Equals(başlık)) return inProgress;
      }

      foreach(var k in done.Kartlar)
      {
        if(k.Başlık.Equals(başlık)) return done;
      }

      return null;
    }

    private Kart KartıBul(string başlık)
    {
      foreach(var k in todo.Kartlar)
      {
        if(k.Başlık.Equals(başlık)) return k;
      }

      foreach(var k in inProgress.Kartlar)
      {
        if(k.Başlık.Equals(başlık)) return k;
      }

      foreach(var k in done.Kartlar)
      {
        if(k.Başlık.Equals(başlık)) return k;
      }

      return null;
    }
  }
}