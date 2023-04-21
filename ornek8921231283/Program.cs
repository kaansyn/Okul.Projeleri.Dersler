using System;

namespace ornek8921231283
{
    internal class Program
    {
        static void Main(string[] args)
        {


           int sayilarin_toplami =  sayitopla(15,20);

            Console.WriteLine(sayilarin_toplami);




        }

        
        static int sayitopla (int sayi1 , int sayi2)
        {

            int toplam = sayi1+ sayi2;
            return toplam;
        }


    }
}
