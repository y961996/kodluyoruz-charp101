using System;
using System.Collections.Generic;

namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int>();

            numList.Add(72);
            numList.Add(7);
            numList.Add(2);
            numList.Add(5);
            numList.Add(92);
            numList.Add(210);

            List<string> renkListesi = new List<string>();

            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            // Count
            Console.WriteLine(numList.Count);
            Console.WriteLine(renkListesi.Count);

            foreach (var num in numList)
                Console.WriteLine(num);

            foreach (var renk in renkListesi)
                Console.WriteLine(renk);

            numList.ForEach(sayı => Console.WriteLine(sayı));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            numList.Remove(2);
            renkListesi.Remove("Turuncu");

            numList.ForEach(sayı => Console.WriteLine(sayı));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            numList.RemoveAt(0);
            renkListesi.RemoveAt(1);

            numList.ForEach(sayı => Console.WriteLine(sayı));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            if(numList.Contains(72))
                Console.WriteLine("72 Liste içerisinde bulundu.");

            Console.WriteLine(renkListesi.BinarySearch("Sarı"));

            string[] hayvanlar = {"kedi", "köpek", "keçi", "kuş"};
            List<string> hayvanlarList = new List<string>(hayvanlar);

            hayvanlarList.Clear();

            List<Kullanıcı> kullanıcıListesi = new List<Kullanıcı>();
            Kullanıcı k1 = new();
            k1.İsim = "Test";
            k1.Soyisim = "Test Soyad";
            k1.Yaş = 72;

            Kullanıcı k2 = new();
            k2.İsim = "Test2";
            k2.Soyisim = "Test2 Soyad";
            k2.Yaş = 27;

            kullanıcıListesi.Add(k1);
            kullanıcıListesi.Add(k2);

            List<Kullanıcı> yeniListe = new List<Kullanıcı>();
            yeniListe.Add(new Kullanıcı(){
                İsim="Guci",
                Soyisim="Genk",
                Yaş=10435
            });

            foreach (var kullanıcı in kullanıcıListesi)
            {
                Console.WriteLine("Kullanıcı Adı : " + kullanıcı.İsim);
                Console.WriteLine("Kullanıcı Soyadı : " + kullanıcı.Soyisim);
                Console.WriteLine("Kullanıcı Yaşı : " + kullanıcı.Yaş);
            }

            yeniListe.Clear();
        }

        public class Kullanıcı
        {
            private string isim;
            private string soyisim;
            private int yaş;

            public string İsim { get => isim; set => isim = value; }
            public string Soyisim { get => soyisim; set => soyisim = value; }
            public int Yaş { get => yaş; set => yaş = value; }
        }
    }
}
