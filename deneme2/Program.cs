using System;

namespace deneme2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç adet sayı girmek istiyorsunuz ? : ");
            int sayi_adedi = Convert.ToInt32(Console.ReadLine());

            int teks = 0;
            int cifts = 0;


            int[] tek_s = new int[sayi_adedi];
            int[] cift_s = new int[sayi_adedi];


            for (int i = 0; i < sayi_adedi; i++)
            {
                Console.WriteLine("Lütfen " + (i+1) + ". sayıyı giriniz... ");
                int g_sayi = Convert.ToInt32(Console.ReadLine());

                if (g_sayi % 2==0 )
                {
                    cift_s[cifts] = g_sayi;
                    cifts++;
                }

                else
                {
                    tek_s[teks] = g_sayi;
                    teks++;
                }
            }

            Console.WriteLine("***********");

            Console.WriteLine("Tek sayıların adedi : " +teks);

            Array.Sort(tek_s);
            for (int i = (tek_s.Length-teks ); i < tek_s.Length; i++)
            {
                Console.WriteLine(tek_s[i]);
            }

            Array.Sort(cift_s);
            Console.WriteLine("Çift sayıların adedi : " +cifts);

            for (int i = (cift_s.Length - cifts ); i < cift_s.Length; i++)
            {
                Console.WriteLine(cift_s[i]);
            }



        }
    }
}
