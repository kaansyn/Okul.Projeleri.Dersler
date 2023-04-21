using System;

namespace Asal_Sayı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Lütfen bir sayı giriniz...");
        
            int sayi = Convert.ToInt32(Console.ReadLine());
            int bolen = 0 ;
            if (sayi>0)
            {
                for (int i = 2; i < sayi/2; i++)
                {
                    if (sayi % i == 0)
                    {
                        bolen++;
                        break;
                    }
                }

                Console.WriteLine(bolen == 0 ? "Asal" : "Asal değildir");
            }


           
        
        }
    }
}
