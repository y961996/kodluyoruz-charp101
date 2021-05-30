using System;

namespace siniflar_struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdörtgen dikdörtgen = new();
            dikdörtgen.KısaKenar = 3;
            dikdörtgen.UzunKenar = 4;

            Console.WriteLine("Class Alan Hesabı : " + dikdörtgen.AlanHesapla());

            //Dikdörtgen_Struct dikdörtgen_struct = new();
            Dikdörtgen_Struct dikdörtgen_struct;  // Burada nesnenin attributeları aşağıdaki 
                                                  // satırda olduğu gibi atanmazsa hata verir.
            dikdörtgen_struct.KısaKenar = 3;
            dikdörtgen_struct.UzunKenar = 4;

            Console.WriteLine("Struct Alan Hesabı : " + dikdörtgen_struct.AlanHesapla());

            Dikdörtgen_Struct dikdörtgen_struct2 = new(5, 7);
            Console.WriteLine(dikdörtgen_struct2.AlanHesapla());
        }
    }

    class Dikdörtgen
    {
        public int KısaKenar;
        public int UzunKenar;

        public Dikdörtgen()
        {
            KısaKenar = 3;
            UzunKenar = 4;
        }

        public long AlanHesapla()
        {
            return this.KısaKenar * this.UzunKenar;
        }
    }

    struct Dikdörtgen_Struct
    {
        public int KısaKenar;
        public int UzunKenar;

        //public Dikdörtgen_Struct(){}
        public Dikdörtgen_Struct(int KısaKenar, int UzunKenar)
        {
            this.KısaKenar = KısaKenar;
            this.UzunKenar = UzunKenar;
        }
        public long AlanHesapla()
        {
            return this.KısaKenar * this.UzunKenar;
        }
    }
}
