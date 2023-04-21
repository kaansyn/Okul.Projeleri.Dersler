using System;

namespace Hava_Durumu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lütfen havanın nasıl olduğuınu söyleyiniz ");
            string hd = Console.ReadLine().ToLower();


            if (hd == "güzel" || hd == "guzel")
            {
                Console.WriteLine("Hava kaç derece ?");
                int sicaklik =Convert.ToInt32(Console.ReadLine());
                if (sicaklik<15)
                {
                    Console.WriteLine("Hava çok soğuk lütfen evde kalınız ");
                }
                else if (sicaklik>=15 && sicaklik<35)
                {
                    Console.WriteLine("Dışarı çıkabilirsiniz");

                }
                else
                {
                    Console.WriteLine("Hava Çok sıcak dışarı çıkmayınız");
                }

            }

            else if (hd == "kötü" || hd == "kotu")
            {
                Console.WriteLine("Evde kalmanız sizin için daha doğru olacaktır");
            }

            else 
            {
                Console.WriteLine("HATALI GİRİŞ");
            }
          
                

            Console.ReadLine();
          }
    }
}
