using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir Sayı Giriniz:");
                int sayı = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girilen sayı: " + sayı);   
            } 
            catch(Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı gucigenk!");
            }

            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("7.2");
                int a = int.Parse("99999999999");
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Boş değer girdiniz");
                Console.WriteLine(e);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Veri tipi uygun dğeil");
                Console.WriteLine(e);
            }
            catch(OverflowException e)
            {
                Console.WriteLine("Küçük yada büyük değer!");
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("İşlem sonlandı. Başarılı mı? Bilmiyoruz.");
            }
        }
    }
}
