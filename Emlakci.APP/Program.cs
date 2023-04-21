using System;

namespace Emlakci.APP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ev evim3 = new Ev();
           
        }
    }

    class Ev
    {
        public Ev()
        {

        }
        public Ev(int odasayisi, int katno,  double alan)
        {
            this.Odasayisi = odasayisi;
            this.Katno = katno;
            this.Semt = "Gazi";
            this.Alan = alan;
        }
        public Ev(int odasayisi, int katno,string semt, double alan)
        {
            this.Odasayisi = odasayisi;
            this.Katno = katno;
            this.Semt = semt;
            this.Alan = alan;
        }


        private int odasayisi;

        public int Odasayisi
        {
            get { return odasayisi; }
            set { odasayisi = value; }
        }

        public string Semt { get => semt; set => semt = value;  }

        public int Katno { get => katno; set => katno = value; }

        private string semt;
        private int katno;

        public double Alan { get; set; }

        public string EvBilgileri()
        {
            return $"Odasayısı : {this.odasayisi}\nAlan:{this.Alan}\nSemt:{this.Semt}\nKatno:{this.Katno}";
        }

    }
}


