using System;

namespace Proje_1
{
  public class ProgramMain
  {
    public static void Main(string[] args)
    {
      TelefonRehberi rehber = new TelefonRehberi();

      int choice;
      do
      {
        PrintMenu();
        choice = int.Parse(Console.ReadLine());
        handleChoice(choice, rehber);
      } while (choice > 0 && choice <= 5);
    }

    public static void PrintMenu()
    {
      Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
      Console.WriteLine("*******************************************");
      Console.WriteLine("(1) Yeni Numara Kaydetmek");
      Console.WriteLine("(2) Varolan Numarayı Silmek");
      Console.WriteLine("(3) Varolan Numarayı Güncelleme");
      Console.WriteLine("(4) Rehberi Listelemek");
      Console.WriteLine("(5) Rehberde Arama Yapmak");
      Console.WriteLine();
    }

    public static void handleChoice(int choice, TelefonRehberi rehber)
    {
      switch (choice)
      {
          case 1:
            rehber.RehbereKişiEkle();
            break;
          case 2:
            rehber.RehberdenKişiSil();
            break;
          case 3:
            rehber.NumaraGüncelle();
            break;
          case 4:
            rehber.RehberiListele();
            break;
          case 5:
            rehber.RehberdeAramaYapma();
            break;
          default:
            break;
      }
    }
  }
}