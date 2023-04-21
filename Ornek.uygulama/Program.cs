using System;

namespace Ornek.uygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seviye Seçiniz \n 1 - kolay \n 2 - orta \n 3 - zor ");
            byte seviye = byte.Parse(Console.ReadLine());

            byte hak, max;

            switch (seviye)
            {
                case 1:
                    hak = 5;
                    max = 10;
                    break;

                case 2:
                    hak = 4;
                    max = 20;
                    break;

                case 3:
                    hak = 3;
                    max = 30;
                    break;

                    default:
                    max = 10;
                    hak = 5;
                    break;

            }

            Random rnd = new Random();

            int sayi = rnd.Next(max);

            int tahmin;

            do
            {
                Console.WriteLine("Sayı tahmin ediniz...");
                tahmin = int.Parse(Console.ReadLine());
                if (tahmin==sayi)
                {
                    Console.WriteLine("Tebrikler bildiniz ");
                    break;

                }

                else
                {
                    Console.WriteLine("YAnlış tahmin tekrar deneyiniz...");
                    hak--;
                }
            } while (  hak !=0);



        }
    }
}
