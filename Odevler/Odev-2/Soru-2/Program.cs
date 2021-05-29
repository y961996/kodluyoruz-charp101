using System;

namespace Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayılar = new int[20];

            Console.WriteLine("20 tane sayı giriniz.");
            for (int i = 0; i < 20; i++)
            {
                Console.Write("{0}. sayıyı giriniz: ", i+1);
                int sayı = int.Parse(Console.ReadLine());
                sayılar[i] = sayı;
            }

            Array.Sort(sayılar);

            int büyükÜçToplam = sayılar[sayılar.Length - 1] + sayılar[sayılar.Length - 2] + sayılar[sayılar.Length - 3];
            int küçükÜçToplam = sayılar[0] + sayılar[1] + sayılar[2];

            Console.WriteLine("En büyük 3 sayının ortalama toplamı: " + büyükÜçToplam);
            Console.WriteLine("En büyük 3 sayının ortalaması: " + (büyükÜçToplam / 3));

            Console.WriteLine("En küçük 3 sayının ortalama toplamı: " + küçükÜçToplam);
            Console.WriteLine("En küçük 3 sayının ortalaması: " + (küçükÜçToplam / 3));
        }
    }
}
