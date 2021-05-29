using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> kullanıcılar = new Dictionary<int, string>();

            kullanıcılar.Add(10, "Guci Genk");
            kullanıcılar.Add(72, "Guci Budusu");
            kullanıcılar.Add(18, "Bıcım Dıncırısım");
            kullanıcılar.Add(99, "Değişik İsimler");

            Console.WriteLine(kullanıcılar[72]);
            foreach (var kullanıcı in kullanıcılar)
                Console.WriteLine(kullanıcı);

            Console.WriteLine(kullanıcılar.Count);

            Console.WriteLine(kullanıcılar.ContainsKey(72));
            Console.WriteLine(kullanıcılar.ContainsValue("Guci Budusu"));
            Console.WriteLine(kullanıcılar.ContainsValue("Guci Dincır"));

            kullanıcılar.Remove(10);
            foreach (var kullanıcı in kullanıcılar)
                Console.WriteLine(kullanıcı);

            foreach (var kullanıcı in kullanıcılar)
                Console.WriteLine(kullanıcı.Value);

            foreach (var key in kullanıcılar.Keys)
            {
                Console.WriteLine(key);
            }

            foreach (var value in kullanıcılar.Values)
            {
                Console.WriteLine(value);
            }
        }
    }
}
