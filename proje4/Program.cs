using System;
using System.Diagnostics;

namespace proje4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Taban değerini giriniz...");
            int taban = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Üs değerini giriniz...");
            int us = Convert.ToInt32(Console.ReadLine());
            int toplam = 1;
            for (int i = 0; i < us; i++)
            {
                toplam*=taban;

            }
            Console.WriteLine(toplam);
        }
    }
}
