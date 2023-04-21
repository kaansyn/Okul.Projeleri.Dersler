using System;
using System.Linq;

namespace Lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Rastgele bir sayı dizisi oluşturma
            //Random rng = new Random();
            //int[] numbers = new int[6];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    int number;
            //    do
            //    {
            //        number = rng.Next(1, 49);
            //    }
            //    while (numbers.Contains(number));

            //    numbers[i] = number;
            //}
            //Array.Sort(numbers);
            //// Sayı dizisini ekrana yazdırma
            //Console.WriteLine("Sayısal Loto kodunuz:");
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
        
        
        
                Random rng = new Random();   

                int[] numaralar = new int[6];                                  

            for (int i = 0; i < numaralar.Length; i++)                         
            {
                int sayi =0;                                                  

                sayi = rng.Next(1,50);                                       

                for (int j = 0; j <i;)                                    
                {
                    if (sayi == numaralar[j])                                 
                    {
                        sayi = rng.Next(1, 50);
                        j = 0;
                    }                                                         

                    else
                    {
                        j++;
                    }
                }

                numaralar[i] = sayi;                                        
            }

            Array.Sort (numaralar);                                        

            Console.WriteLine("Sayısal loto sonuçları...");

            for (int i = 0; i < numaralar.Length; i++)                    
            {
                Console.Write(" , "+numaralar[i]);
            }
        
        
        
        
        
        
        
        }
    }
}
