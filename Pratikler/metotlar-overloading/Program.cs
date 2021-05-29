using System;

namespace metotlar_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            // Out parametreler
            string sayı = "999";
            //int outSayı;

            //int.TryParse(sayı, out outSayı);
            bool sonuç = int.TryParse(sayı, out int outSayı);
            if(sonuç)
            {
                Console.WriteLine("Başarılı");
                Console.WriteLine(outSayı);
            }
            else
            {
                Console.WriteLine("Başarısız");
            }

            Metotlar m = new Metotlar();
            m.Topla(4, 5, out int sum);
            Console.WriteLine(sum);

            // Metot Overloading
            int ifade = 999;
            m.EkranaYazdır(Convert.ToString(ifade));
            m.EkranaYazdır(ifade);
            m.EkranaYazdır("Sayı: ", Convert.ToString(ifade));
        }

        class Metotlar
        {
            public void Topla(int a, int b, out int toplam)
            {
                toplam = a + b;
            }

            public void EkranaYazdır(string text)
            {
                Console.WriteLine(text);
            }

            public void EkranaYazdır(int text)
            {
                Console.WriteLine(text);
            }

            public void EkranaYazdır(string text1, string text2)
            {
                Console.WriteLine(text1 + text2);
            }
        }
    }
}
