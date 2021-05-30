using System;

namespace siniflar_static_sinif_ve_uyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan sayısı: " + Çalışan.ÇalışanSayısı);

            Çalışan çalışan = new("İsim", "Soyisim", "Demirci");
            Console.WriteLine("Çalışan sayısı: " + Çalışan.ÇalışanSayısı);

            Çalışan çalışan2 = new("İsim2", "Soyisim2", "Demirci2");
            Console.WriteLine("Çalışan sayısı: " + Çalışan.ÇalışanSayısı);

            Çalışan çalışan3 = new("İsim3", "Soyisim3", "Demirci3");
            Console.WriteLine("Çalışan sayısı: " + Çalışan.ÇalışanSayısı);

            Console.WriteLine(İşlemler.topla(70, 2));
            Console.WriteLine(İşlemler.çıkar(99, 27));

        }
    }

    class Çalışan
    {
        private static int çalışanSayısı;
        private string isim;
        private string soyisim;
        private string departman;
        public static int ÇalışanSayısı { get => çalışanSayısı; }

        static Çalışan()
        {
            Console.WriteLine("Static Constructor çalıştı.");
            çalışanSayısı = 0;
        }
        public Çalışan(string isim, string soyisim, string departman)
        {
            Console.WriteLine("Public Constructor çalıştı.");
            this.isim = isim;
            this.soyisim = soyisim;
            this.departman = departman;
            çalışanSayısı++;
        }
    }

    static class İşlemler
    {
        public static long topla(int s1, int s2)
        {
            return s1 + s2;
        }

        public static long çıkar(int s1, int s2)
        {
            return s1 - s2;
        }
    }
}
