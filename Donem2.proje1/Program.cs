using System;

namespace Donem2.proje1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
          //  Console.WriteLine(ToplamaYap(25, 38));
         //   Console.WriteLine(ToplamaYap(231,321,5123));

          Console.Write("Kaç adet sayı girmek istiyorsunuz : ");
            int adet = Convert.ToInt32(Console.ReadLine());

            int[] sayilar = new int[adet];  

            for (int i = 0; i < adet; i++)
            {
                Console.Write((i+1) + ". sayıyı giriniz ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(ToplamaYap(sayilar)); 
           // ToplamaYap2(899, 245);
            
        
        }



        // static int ToplamaYap(int s1, int s2, int s3=0) => s1 + s2 + s3;   //optinal metotlarda değer gönderilmezse direkt olarak 0 atılır değer gönderilirse gönderdiğimiz değer ele alınır 


        /// <summary>
        /// Kendisine gönderdiğimiz 2 sayıyı toplar
        /// </summary>
        /// <param name="s1">Toplanacak 1. sayı</param>
        /// <param name="s2">Toplanacak 2. sayı</param>
        /// <returns>Toplanan sayıları int olarak geri döner </returns>
        static int ToplamaYap(int s1, int s2) => s1 + s2;

        static int ToplamaYap(int s1, int s2, int s3) => s1 + s2 + s3; // Eğer parametre sayısı veya tipi farklıysa aynı isimde birden fazla metot oluşturabiliriz genellikle bir metodu geliştirme amacıyla kullanılır .

        static int ToplamaYap(int[] sayilar )
        {
            int toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }

            return toplam;
        }

        static void ToplamaYap2 (int s1,int s2)=> Console.WriteLine(s1 + s2);
       
    
    
    
    
    
    }
}
