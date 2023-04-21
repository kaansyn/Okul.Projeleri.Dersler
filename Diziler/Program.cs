using System;

namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lütfen satır sayısını giriniz ");
            int satir = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen sütun sayısını giriniz ");
            int sutun = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < satir; i++)
            {
                for (int j = 0;  j < sutun;  j++)
                {
                    Console.Write((i+j) % 2 == 0 ? "*" : " ");
                }

                    Console.WriteLine();
            }

        }
    }
}
