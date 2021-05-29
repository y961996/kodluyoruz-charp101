using System;
using System.Collections;
using System.Collections.Generic;

namespace arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            liste.Add("Guci");
            liste.Add(72);
            liste.Add(true);
            liste.Add('~');

            Console.WriteLine(liste[1]);

            foreach (var item in liste)
                Console.WriteLine(item);

            Console.WriteLine("==== Add Range =====");
            string[] renkler = {"kırmızı", "sarı", "yeşil", "mavi"};
            List<int> sayılar = new List<int>(){1, 8, 3, 7, 9, 72};
            
            liste.AddRange(renkler);
            liste.AddRange(sayılar);

            foreach (var item in liste)
                Console.WriteLine(item);

            Console.WriteLine("=== Sort ===");
            
            // Eğer hepsi aynı türse çalışır yoksa hata verir.
            //liste.Sort();

            Console.WriteLine(liste.BinarySearch("yeşil"));

            liste.Reverse();
            foreach (var item in liste)
                Console.WriteLine(item);

            liste.Clear();
            
            foreach (var item in liste)
                Console.WriteLine(item);
        }
    }
}
