using System;
using System.Collections;

namespace Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList asal = new ArrayList();
            ArrayList asalOlmayan = new ArrayList();

            Console.WriteLine("20 tane pozitif sayı giriniz.");
            for(int i = 0; i < 20; i++)
            {
                Console.Write("{0}. sayıyı giriniz: ", i+1);
                try
                {
                    int currentNum = int.Parse(Console.ReadLine());
                    if(currentNum <= 0)
                    {
                        Console.WriteLine("Lütfen pozitif sayılar giriniz.");
                        break;
                    }

                    if(IsAsal(currentNum))
                        asal.Add(currentNum);
                    else
                        asalOlmayan.Add(currentNum);
                }
                catch(Exception e)
                {
                    Console.WriteLine("Lütfen pozitif sayılar giriniz.");
                    Console.WriteLine(e.Message);
                    break;
                }
            }

            asal.Sort();
            asalOlmayan.Sort();
            
            Console.Write("Asal sayılar: ");
            foreach (var sayı in asal)
            {
                Console.Write(sayı + " ");
            }
            Console.WriteLine();

            Console.Write("Asal olmayan sayılar: ");
            foreach (var sayı in asalOlmayan)
            {
                Console.Write(sayı + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Asal dizisinin eleman sayısı : " + asal.Count);
            Console.WriteLine("Asal olmayan dizisinin eleman sayısı : " + asalOlmayan.Count);

            int asalToplam = 0;
            foreach (var sayı in asal)
                asalToplam += (int)sayı;

            int asalOlmayanToplam = 0;
            foreach (var sayı in asalOlmayan)
                asalOlmayanToplam += (int)sayı;

            if(asal.Count > 0) 
                Console.WriteLine("Asal dizisinin elemanlarının ortalaması : " + (asalToplam / asal.Count));
            else
                Console.WriteLine("Asal dizisinin elemanlarının ortalaması 0");
            if(asalOlmayan.Count > 0) 
                Console.WriteLine("Asal olmayan dizisinin elemanlarının ortalaması : " + (asalOlmayanToplam / asalOlmayan.Count));
            else
                Console.WriteLine("Asal olmayan dizisinin elemanlarının ortalaması 0");
        }

        public static bool IsAsal(int val)
        {
            if(val < 2) return false;

            int count = val-1;
            while(count > 1)
            {
                if(val % count == 0) return false;
                count--;
            }

            return true;
        }
    }
}
