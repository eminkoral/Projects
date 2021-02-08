using System;

namespace Ödev
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, toplam, n = 1;
            string sayı;
        Başla:
            Console.WriteLine("Lütfen en fazla 4 basamaklı bir pozitif tam sayı giriniz:");
            sayı = Console.ReadLine();
            try
            {
                a = Convert.ToInt32(sayı);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Harf yerine rakam kullanınız.");
                goto Başla;
            }
            if (sayı.Length > 4)
            {
                goto Başla;
            }
            do
            {
                toplam = (n * (n + 1)) / 2;
                n += 1;
            } while (toplam < a);
            if (toplam == a)
            {
                Console.WriteLine(a + " üçgen sayıdır.");
            }
            else
            {
                Console.WriteLine(a + " üçgen sayı değildir.");
            }
        }
    }
}
