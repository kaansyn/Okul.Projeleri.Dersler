using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte[] dizi = { 11,12,25,38,43,2, 3, 4 , 5 , 7 , 8 , 9 ,0};

          DiziYazdiran(dizi);

            
           
        }





       static void DiziYazdiran(byte[] dizi )
        {
            Array.Sort(dizi);

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine(dizi[i]);

            }

        }

    }
}
