using System;

namespace ornek._2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Lütfen başlangıç değerini giriniz ");
            int baslangic = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen bitiş değerini giriniz");
            int bitis = Convert.ToInt32(Console.ReadLine());


            int toplam = 0;
            
            

            
            if (baslangic > bitis)
            {
              int temp = baslangic;
                baslangic = bitis;
                bitis =temp;
               
            }

            


                for (int i =baslangic; i <= bitis; i++)
                {
                    toplam += i;
                }

                Console.WriteLine(toplam);

           

        }
    }
}
