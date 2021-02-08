using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            char devam = 'e';
            while (devam == 'e')
            {
                Console.WriteLine("3 ya da 4 basamaklı bir sayı girin:");
                string sayi = Console.ReadLine();
                int rakam = Convert.ToInt32(sayi);
                int uzunluk = sayi.Length;
                if (uzunluk == 3)
                {
                    int sonuc = 0, a;
                    while (rakam > 0)
                    {
                        a = (rakam % 10);
                        rakam = rakam / 10;
                        sonuc = sonuc + a * a;
                    }
                    Console.WriteLine(sayi + " sayısının basamak kareleri toplamı: " + sonuc);
                }
                else if (uzunluk == 4)
                {
                    if (rakam % 4 == 0)
                    {
                        Console.WriteLine(sayi + " sayısı 4'e tam bölünebilir.");
                    }
                    else
                    {
                        Console.WriteLine(sayi + " sayısı 4'e tam bölünemez.");
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz bir sayı girdiniz.");
                }
                Console.WriteLine("Devam etmek ister misiniz?(e/h)");
                devam = Convert.ToChar(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}
