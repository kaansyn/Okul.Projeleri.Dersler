using System;
using System.Linq;

namespace Yeni.ders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] sayilar = new int[3] {2,3,4};

            //foreach (int  sayi in sayilar)     // foreach sadece dizilerin okunmasında kullanılır atama yapılamaz
            //{
            //    Console.WriteLine(sayi);
            //}

            //Random rnd = new Random();

            //int[] numbers = new int[5];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = rnd.Next();
            //}


            //foreach (var item in numbers)
            //{
            //    item = rnd.Next();
            //}

            Console.WriteLine("Kaç adet öğrenci bilgisi girmek istersiniz?");

            byte Gsayi = Convert.ToByte(Console.ReadLine());           
            
            string[,] sayilar = new string[Gsayi+1, 3];

            sayilar[0 ,0] = "Ad";
            sayilar[0, 1] =  "Soyad";
            sayilar[0, 2] = "Numara";



            //  for (int j = 0; j < Gsayi*3; j++)
            //{
            //    if (j%3==0 || j==0)
            //     {
            //         Console.Write((a)+". Öğrencinin Adını Giriniz : ");
            //         sayilar[a,b] = Console.ReadLine();
            //      b++;
            //     }

            //     else if (j%3==1 || j==1)
            //     {
            //         Console.Write((a)+". Öğrencinin Soyadını Giriniz : ");
            //         sayilar[a, b] = Console.ReadLine();
            //         b++;
            //     }

            //     else
            //     {
            //         Console.Write((a) + ". Öğrencinin Numarasını Giriniz : ");
            //         sayilar[a, b] = Console.ReadLine();

            //      a++;
            //      b = 0;
            //     }



            //}

            for (int i = 1; i < sayilar.GetLength(0); i++)
            {
                Console.WriteLine( i + ". Öğrencinin adını giriniz ");
                sayilar[i, 0] = Console.ReadLine();

                Console.WriteLine(i + ". Öğrencinin soyadını  giriniz ");
                sayilar[i, 1] = Console.ReadLine();

                Console.WriteLine(i + ". Öğrencinin numarasını giriniz ");
                sayilar[i, 2] = Console.ReadLine();

            }

            Console.WriteLine(" ");
            Console.WriteLine("     *******    ");
            Console.WriteLine(" ");

            for (int i = 0; i < sayilar.GetLength(0); i++)
            {

                for (int j = 0; j < sayilar.GetLength(1); j++)
                {
                    Console.Write(sayilar[i,j] + "\t");

                }
                Console.WriteLine();

            }


        }

    }
}
