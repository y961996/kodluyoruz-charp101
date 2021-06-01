using System;

namespace Proje_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Kişi[] takımdakiKişiler = {
                new Kişi(0, "Ümit Tosun"),
                new Kişi(1, "Tevfik Sokullu"),
                new Kişi(2, "Burçin Özoguz"),
                new Kişi(3, "Sabah Gülek"),
                new Kişi(4, "Esen Akbulut")
            };

            Board board = new Board();

            int option;
            do
            {
                PrintMenu();
                option = int.Parse(Console.ReadLine());
                handleOption(option);
            } while (option > 0 && option <4);

            Console.WriteLine("Geçersiz seçim! Programdan çıkılıyor...");
        }

        public static void PrintMenu()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");
        }

        public static void handleOption(int option)
        {
            
        }
    }
}
