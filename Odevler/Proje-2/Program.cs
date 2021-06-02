using System;

namespace Proje_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();

            int option;
            do
            {
                PrintMenu();
                option = int.Parse(Console.ReadLine());
                handleOption(option, board);
            } while (option > 0 && option < 4);

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

        public static void handleOption(int option, Board board)
        {
            switch (option)
            {
                case 1:
                    board.BoardListele();
                    break;
                case 2:
                    board.KartEkle();
                    break;
                case 3:
                    board.KartSil();
                    break;
                case 4:
                    board.KartTaşı();
                    break;;
                default:
                    Console.WriteLine("Geçersiz bir seçim yaptınız!");
                    break;
            }
        }
    }
}
