using System;

namespace Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kaç öğrenci girişi yapacaksınız: ");
            int mevcut = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            string[,] ogrenci = new string[mevcut, 2];


            for (int i = 0; i < mevcut; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(i + 1 + " " + "öğrencinin sırasıyla adını ve soyadını giriniz: ");
                    ogrenci[i, j] = Console.ReadLine();

                }
            }

            Console.Clear();

            Console.WriteLine("Adı                             Soyadı");
            Console.WriteLine("======================================");

            for (int i = 0; i < mevcut; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(ogrenci[i, j] + "                       " + "\t");
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
