using System;

namespace ders1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region MyRegion
            // string sayi = "25";
            //     // byte sayi2= Convert.ToByte(sayi);
            //  Console.WriteLine(sayi2);
            //checked
            //{
            //    int sayi1 = 257;
            //    byte sayi2 = (byte)sayi1;
            //    Console.WriteLine(sayi2);
            //}

            //string ad = "Kaan";
            //string soyad = "SAYAN";

            //Console.WriteLine("Hoşgeldiniz, " + ad +" "+ soyad );


            /*   try
               {

                   Console.WriteLine("Lütfen adınızı giriniz :");
                   string ad = Console.ReadLine();

                   Console.WriteLine("Lütfen soyadınızı giriniz :");
                   string soyad = Console.ReadLine();
                   Console.WriteLine("Lütfen yaşınızı giriniz  :");
                   byte yas = byte.Parse(Console.ReadLine());
                   Console.WriteLine("************************");
                   Console.WriteLine("Hoşgeldiniz, " + ad + " " + soyad + " " + yas);


               }
               catch (FormatException)
               {

                   Console.WriteLine("Lütfen Yaşınızı Sayıyla giriniz...");

                   byte yas = byte.Parse(Console.ReadLine());




               }

               catch (OverflowException)
               {

                   Console.WriteLine("Lütfen Yaşınızı DOĞRU Girdiğinizden  Emin Olun ...");

                   byte yas = byte.Parse(Console.ReadLine());


               }

               catch(Exception)
               {
                   Console.WriteLine("Bir hata oluştu");

               }*/
            #endregion
            int sayi1 = 20;
            int sayi2 = 10;
            string sonuc = sayi1 > sayi2 ? "sayi 1 büyüktür " : "sayi2 büyüktür ya da sayılar eşittir ";

            Console.WriteLine(sonuc);

           if ( sayi1>sayi2)
            {
                Console.WriteLine("1. sayı  büyüktür...");

            }
           else if (sayi2> sayi1 )
            {
                Console.WriteLine("2. sayı büyüktür...");
            }

            else
            {
                Console.WriteLine("sayılar birbirine eşittir... ");
            }
        }

    }
}
