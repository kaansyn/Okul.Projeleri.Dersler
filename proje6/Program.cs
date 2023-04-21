using System;
using System.Diagnostics.Contracts;

namespace proje6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayıyı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int sonuc = 1;
            
            for (int i = 1; i <= sayi; i++)
            {
                
               sonuc *= i;


            }
            Console.WriteLine(sonuc);
        }
    }
}
