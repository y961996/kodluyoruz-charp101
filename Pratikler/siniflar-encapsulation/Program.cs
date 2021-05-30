using System;

namespace siniflar_encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Öğrenci öğrenci = new();
            öğrenci.Isim = "Haydar";
            öğrenci.Soyisim = "Haydar";
            öğrenci.No = 72;
            öğrenci.Sınıf = 3;
            öğrenci.ÖğrenciBilgileri();

            öğrenci.SınıfAtlat();
            öğrenci.ÖğrenciBilgileri();

            Öğrenci öğrenci2 = new("Kara", "Gümrük", 100, 2);
            öğrenci2.ÖğrenciBilgileri();

            öğrenci2.SınıfDüşür();
            öğrenci2.SınıfDüşür();
            öğrenci2.SınıfDüşür();
            öğrenci2.SınıfDüşür();
            öğrenci.SınıfAtlat();
            öğrenci2.SınıfDüşür();
            öğrenci2.SınıfDüşür();
            öğrenci2.ÖğrenciBilgileri();
        }
    }

    class Öğrenci
    {
        private string isim;
        private string soyisim;
        private int no;
        private int sınıf;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int No { get => no; set => no = value; }
        public int Sınıf {
            get => sınıf;
            set
            {
                if(value <= 1)
                {
                    Console.WriteLine("Sınıf 1 den küçük olamaz!");
                    sınıf = 1;
                }
                else
                    sınıf = value; 
            } 
        }

        public Öğrenci(){}
        public Öğrenci(string isim, string soyisim, int no, int sınıf)
        {
            this.isim = isim;
            this.soyisim = soyisim;
            this.no = no;
            this.sınıf = sınıf;
        }

        public void ÖğrenciBilgileri()
        {
            Console.WriteLine("-------------- Öğrenci Bilgileri -------------");
            Console.WriteLine("Öğrencinin Adı:       " + this.isim);
            Console.WriteLine("Öğrencinin Soydı:     " + this.soyisim);
            Console.WriteLine("Öğrencinin Numarası:  " + this.no);
            Console.WriteLine("Öğrencinin Sınıfı:    " + this.sınıf);
        }

        public void SınıfAtlat()
        {
            this.Sınıf = this.Sınıf + 1;
        }
        public void SınıfDüşür()
        {

            this.Sınıf = this.Sınıf - 1;
        }
  }
}
