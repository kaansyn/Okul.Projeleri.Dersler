using System;

namespace onek._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine((i+1) + ". Sayıyı giriniz");
                int sayi=int.Parse(Console.ReadLine());
                toplam+=sayi;
            }
            Console.WriteLine(toplam);
        }
    }
}
