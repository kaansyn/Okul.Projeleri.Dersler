using System;
using KazanMyo.Emlakci.Lib;

namespace Emlakci.APP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ev evim3 = new Ev();

            Console.WriteLine(Ev.Sayac);
            SatilikEv se =new SatilikEv();
            se.Katno = 2;
            se.Alan =100.12;
            se.Semt = "Gazi";
            se.Odasayisi =4;
            se.SatisFiyat = 130000;
            

           
            
            var ke = new KiralikEv();
            ke.Katno = 3;
            ke.KiraFiyatı = 1000;
            ke.Alan = 100.25;
            ke.Depozito = 600;
            ke.Odasayisi = 5;
            ke.Semt = "Kiralik ev ";

            Ev[] evler = new Ev[2];

            evler[0] = se;
            evler[1] = ke;

            for (int i = 0; i < evler.Length; i++)
            {
               if(evler[i] is SatilikEv)
                {
                    SatilikEv sev = (SatilikEv)(evler[i]);
                    Console.WriteLine(sev.EvBilgileri());
                    Console.WriteLine();
                }
               else if (evler[i] is KiralikEv)
                {
                    KiralikEv kev = (KiralikEv)(evler[i]);
                    Console.WriteLine(kev.EvBilgileri());
                    Console.WriteLine();
                }
                
                    



            }
        
        
        
        }
    }   
}

 


