using System;

namespace Diziler.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Kaç adet isim girmek istiyorsunuz ");
            //int isims = Convert.ToInt32(Console.ReadLine());

            //string[] isimler = new string[isims];


            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine((i+1) + ". ismi giriniz...");
            //    isimler[i] = Console.ReadLine();
            //}

            //Console.WriteLine("************");

            //Array.Sort(isimler);

            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine(isimler[i]);
            //}




            Console.WriteLine("Kaç adet sayı üretmek istiyorsunuz?");
            int sayiA = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Başlangıç değerini giriniz...");
            int min = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bitiş değerini giriniz...");
            int max = Convert.ToInt32(Console.ReadLine());

            int[] sayılar= new int[sayiA];

            Random rnd = new Random();

            
            for (int i = 0; i < sayılar.Length; i++)
            {
                int bolen = 0;

                sayılar[i] = rnd.Next(min,max);

                if (sayılar[i] > 0)
                {
                    for (int j = 2; j < sayılar[i] / 2; j++)
                    {
                        if (sayılar[i] % j == 0)
                        {
                            bolen++;
                            break;
                        }


                    }
                        Console.Write(sayılar[i]);

                        Console.WriteLine(bolen == 0 ? "Asal" : "Asal değildir");

                   
                }
            }

            

           


        }
    }
}
