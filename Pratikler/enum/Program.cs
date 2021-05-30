using System;

namespace enum_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Günler.Pazar);
            Console.WriteLine((int)Günler.Cumartesi);

            int Sıcaklık = 25;
            if(Sıcaklık <= (int)HavaSıcaklığı.Normal)
                Console.WriteLine("Hava soğuk ha!");
            else if(Sıcaklık >= (int)HavaSıcaklığı.Sıcak)
                Console.WriteLine("Cayır cayır hava, kafana geçir şapka.");
            else if(Sıcaklık >= (int)HavaSıcaklığı.Normal && Sıcaklık < (int)HavaSıcaklığı.ÇokSıcak)
                Console.WriteLine("İnekler çayırlarda hop hop hopluyorlar.");
        }
    }

    enum HavaSıcaklığı
    {
        Soğuk = 5,
        Normal = 20,
        Sıcak = 25,
        ÇokSıcak = 30
    }

    enum Günler
    {
        Pazartesi=1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi = 72,
        Pazar
    }
}
