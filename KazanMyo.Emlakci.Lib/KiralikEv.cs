using System;
using System.Collections.Generic;
using System.Text;

namespace KazanMyo.Emlakci.Lib
{
    public class KiralikEv:Ev
    {

        public double KiraFiyatı { get; set; }
        public double Depozito { get; set; }


        public  override string EvBilgileri()
        {
            return $"{base.EvBilgileri()}\nKira Fiyatı : {KiraFiyatı}\nDepozito : {Depozito}";

        }
    }
}
