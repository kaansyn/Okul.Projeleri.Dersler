using System;
using System.Collections.Generic;
using System.Text;

namespace KazanMyo.Emlakci.Lib
{
    public class SatilikEv : Ev
    {
        public double SatisFiyat { get; set; }

        public new string EvBilgileri()
        {
            return $"{base.EvBilgileri()}\nSatış Fiyatı : {SatisFiyat}";
        }
        //public string SatilikEvBilgileri()
        //{
        //    return $"\nSatışfiyatı : {SatisFiyat} ";
        //}
    }
}
