using System;

namespace Odev_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Odev1 odev1 = new();

            // 1
            odev1.bir();

            // 2
            odev1.iki();

            // 3
            odev1.üç();

            // 4
            odev1.dört();
        }
    }

    public class Odev1
    {
        public void bir()
        {
            Console.WriteLine("1. Bölüm");
            Console.WriteLine("---------------------------------------------------");

            try
            {
                Console.Write("Lütfen pozitif bir sayı giriniz: ");
                int n = int.Parse(Console.ReadLine());
                int[] dizi = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Lütfen {0}. sayıyı giriniz: ", i+1);
                    dizi[i] = int.Parse(Console.ReadLine());
                }

                Console.Write("Girdiğiniz Çift Sayılar :");
                foreach (var num in dizi)
                {
                    if(num % 2 == 0) Console.Write(num + " ");
                }
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Pozitif bir sayı girmediniz!");
                Console.WriteLine(e.Message);
            }
            
        }

        public void iki()
        {
            Console.WriteLine("2. Bölüm");
            Console.WriteLine("---------------------------------------------------");
            try
            {
                Console.WriteLine("Lütfen Pozitif 2 sayı giriniz.");
                
                Console.Write("1. sayı: ");
                int n = int.Parse(Console.ReadLine());
                Console.Write("2. sayı: ");
                int m = int.Parse(Console.ReadLine());
                
                int[] inputs = new int[n];
                Console.WriteLine("Lütfen " + n + " tane sayı giriniz.");
                for (int i = 0; i < n; i++)
                {
                    Console.Write("{0}. sayı: ", i+1);
                    inputs[i] = int.Parse(Console.ReadLine());
                }

                Console.Write("Girdiğiniz sayılardan " + m + " sayısına eşit yada tam bölünen sayılar: ");
                foreach (int i in inputs)
                {
                    if(m % i == 0) Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            catch(Exception e)
            {
                Console.WriteLine("Pozitif bir sayı girmediniz!");
                Console.WriteLine(e.Message);
            }
        }

        public void üç()
        {
            Console.WriteLine("3. Bölüm");
            Console.WriteLine("---------------------------------------------------");

            try
            {
                Console.Write("Lütfen pozitif bir sayı giriniz: ");
                int n = int.Parse(Console.ReadLine());
                string[] kelimeler = new string[n];
                Console.WriteLine("Lütfen " + n + " adet kelime giriniz.");
                for (int i = 0; i < n; i++)
                {
                    Console.Write("{0}. kelime: ", i+1);
                    kelimeler[i] = Console.ReadLine();
                }

                Array.Reverse(kelimeler);
                foreach (string kelime in kelimeler)
                {
                    Console.Write(kelime + " ");
                }
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Pozitif bir sayı girmediniz yada yanlış bir input girdiniz!");
                Console.WriteLine(e.Message);
            }
        }

        public void dört()
        {
            Console.WriteLine("4. Bölüm");
            Console.WriteLine("---------------------------------------------------");

            Console.Write("Lütfen bir cümle yazınız: ");
            string cümle = Console.ReadLine();
            string[] cümleDizisi = cümle.Split(" ");
            int kelimeSayısı = cümleDizisi.Length;
            int harfSayısı = string.Join("", cümleDizisi).Length;

            Console.WriteLine("Girdiğiniz cümledeki toplam kelime sayısı : " + kelimeSayısı);
            Console.WriteLine("Girdiğiniz cümledeki toplam harf sayısı : " + harfSayısı);
        }
    }
}
