using System;

namespace Personel2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p = new Personel(-20,"Kaan");
            var p2 = new Personel();
        }
    }

    class Personel
    {
        public Personel()
        {

        }
        public Personel(int yas, string ad)
        {
            this.yas = yas;
            this.ad = ad;
        }

        int yas;
        string ad;

        public string Ad { get => ad; set => ad = value; }

        public int Yas { get => yas; set => yas = Math.Abs(value); }

    }
}
