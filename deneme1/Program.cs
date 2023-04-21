using System;

namespace deneme1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanıcı kaç adet sayı gireceğini belirlesin
            // kullanıcı başlangıç ve bitiş değerini seçsin ve bu değerler arasında rastgele bir sayı üretilsin
            // üretilen bu sayıların asal olup olmadığı ekranda yazsın 


            Console.WriteLine("Hoşgeldiniz...");
            Console.Write("Kaç adet sayı üretilmesini istiyorsunuz ? : ");
            byte Sayi_adedi = Convert.ToByte(Console.ReadLine());

            Console.Write("Başlangıç değerini giriniz ; ");
            int min = Convert.ToInt32(Console.ReadLine());

            Console.Write("Bitiş değerini giriniz ; ");
            int max = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();

            //for (int i = 0; i < Sayi_adedi; i++)
            //{
            //    int bolen =  0;
            //    int r_sayi = rnd.Next(min,max);

            //    for (int j = 2; j < r_sayi/2; j++)
            //    {

            //        if (r_sayi % j == 0)
            //        {
            //            bolen++;

            //        }

            //    }
            //        if (bolen!=0)
            //        {
            //            Console.WriteLine(r_sayi + " Sayı asal değildir...");
            //        }

            //        else
            //        {
            //            Console.WriteLine(r_sayi + " Sayı asaldır...");
            //        }


            //}

            int [] r_sayilar = new int[Sayi_adedi];

            for (int i = 0; i < r_sayilar.Length; i++)
            {
                int bolen = 0;
                r_sayilar[i] = rnd.Next(min,max);


                for (int j = 2; j < r_sayilar[i]/2; j++)
                {
                    if (r_sayilar[i] % j ==0)
                    {
                        bolen++;
                    }

                }
                    if (bolen==0)
                    {
                        Console.WriteLine(r_sayilar[i] + " Sayı asaldır... ");
                    }

                    else
                    {
                        Console.WriteLine(r_sayilar[i] + " Sayı asal değildir... ");
                    }
            }












        }
    }
}
