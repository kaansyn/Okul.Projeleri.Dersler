using System;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz");
            int fsayi = Convert.ToInt32(Console.ReadLine());
            int s1 = 1;
            int s2 = 0;

            int toplam = 0;



            for (int i = 0; i < fsayi-2; i++)
            {
              toplam = s1+s2;

              s2 = s1;
              s1 = toplam ;

            }                      
            Console.WriteLine(fsayi+". Fibonacci sayısı : " + toplam);
        }
    }
}
