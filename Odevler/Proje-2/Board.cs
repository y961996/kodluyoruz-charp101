using System;

namespace Proje_2
{
  public class Board
  {
    private Line todo;
    private Line inProgress;
    private Line done;

    public Line Todo { get => todo; set => todo = value; }
    public Line InProgress { get => inProgress; set => inProgress = value; }
    public Line Done { get => done; set => done = value; }

    public Board()
    {
      Kart defaultKart1 = new Kart("Başlık1", "İçerik çok dolu değil.", kişiler()[0], KartBüyüklük.S);
      Kart defaultKart2 = new Kart("Başlık2", "İçerik çok dolu.", kişiler()[1], KartBüyüklük.L);  
      Kart defaultKart3 = new Kart("Başlık3", "İçerik boş.", kişiler()[3], KartBüyüklük.XS);

      todo.Kartlar.Add(defaultKart1);
      todo.Kartlar.Add(defaultKart3);

      InProgress.Kartlar.Add(defaultKart2);
    }

    internal Kişi[] kişiler()
    {
      Kişi[] takımdakiKişiler = {
        new Kişi(0, "Ümit Tosun"),
        new Kişi(1, "Tevfik Sokullu"),
        new Kişi(2, "Burçin Özoguz"),
        new Kişi(3, "Sabah Gülek"),
        new Kişi(4, "Esen Akbulut")
      };
      return takımdakiKişiler;
    }
    internal void BoardListele()
    {
      Console.WriteLine(todo.Isim);
      foreach(var todo in todo.Kartlar)
      {
        Console.WriteLine(todo);
      }
    }

    internal void KartEkle()
    {
      throw new NotImplementedException();
    }

    internal void KartSil()
    {
      throw new NotImplementedException();
    }

    internal void KartTaşı()
    {
      throw new NotImplementedException();
    }
  }
}