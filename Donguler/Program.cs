using System;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int top = 0;
            for (int i = 0; i < 11; i++)
            {
                top += i;
            }
                Console.WriteLine("Sayıların toplamı = "+ top);
        }
    }
}
