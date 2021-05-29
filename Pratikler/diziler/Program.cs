using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring arrays
            string[] renkler = new string[5];
            string[] hayvanlar = {"Kedi", "Köpek", "Eşek", "Şeddeli Eşşek"};

            int[] dizi;
            dizi = new int[5];

            // Accessing arrays
            renkler[0] = "cyan";
            Console.WriteLine(hayvanlar[0]);
            dizi[3] = 10;

            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            // Arrays with loops
            Console.Write("Lütfen Dizinin Eleman Sayısını Giriniz: ");
            int arrayLen = int.Parse(Console.ReadLine());
            int[] numArray = new int[arrayLen];

            for (int i = 0; i < arrayLen; i++)
            {
                Console.Write((i+1) + ". elemanı giriniz: ");
                int currentNum = int.Parse(Console.ReadLine());
                numArray[i] = currentNum;
            }

            int summ = 0;
            foreach (var num in numArray)
            {
                summ += num;
            }

            Console.WriteLine("Average: " + (summ / arrayLen));
        }
    }
}
