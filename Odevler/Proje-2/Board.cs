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
      Console.WriteLine("TEST START");
      Console.WriteLine(todo.Isim);
      foreach(var todo in todo.Kartlar)
      {
        Console.WriteLine(todo);
      }
      Console.WriteLine("TEST END");
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