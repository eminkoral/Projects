using System;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz.");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            for (int i = 1; i < sayi - 1; i++)
            {
                if (sayi % i == 0)
                {
                    toplam = toplam + i;
                }
            }
            if (toplam == sayi)
            {
                Console.WriteLine(sayi + " mükemmel sayıdır!");
            }
            else
            {
                Console.WriteLine(sayi + " mükemmel sayı değildir.");
            }
        }
    }
}
