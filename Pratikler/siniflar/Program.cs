using System;

namespace sınıflar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Erişim Belirleyiciler
            // 1- Public     => Erişim serbest
            // 2- Private    => Erişim Yok
            // 3- Internal   => Projeye özel
            // 4- Protected  => Tanımlandığı ve extend edilen sınıflarda.

            Çalışan çalışan1 = new();
            çalışan1.Ad = "Guci";
            çalışan1.Soyad = "Genk";
            çalışan1.No = 12345678;
            çalışan1.Departman = "Irgat";

            çalışan1.ÇalışanBilgileri();

            Çalışan çalışan2 = new();
            çalışan2.Ad = "Age";
            çalışan2.Soyad = "Empire";
            çalışan2.No = 87654332;
            çalışan2.Departman = "Madenci";

            çalışan2.ÇalışanBilgileri();
        }
    }

    class Çalışan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void ÇalışanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı: " + Ad);
            Console.WriteLine("Çalışanın Soyadı: " + Soyad);
            Console.WriteLine("Çalışanın No: " + No);
            Console.WriteLine("Çalışanın Departman: " + Departman);
        }
    }
}
