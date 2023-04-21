using System;

namespace Donem2.Proje2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ev ev1 = new ev(); // Ev classından yeni bir nesne ürettik 

            Console.WriteLine("Oda sayısını giriniz :");
            ev1.SetOdaSayisi(int.Parse(Console.ReadLine()));
            Console.WriteLine("Kat no giriniz:");
            ev1.kat_no = int.Parse(Console.ReadLine());
            Console.WriteLine("Alanı giriniz:");
            ev1.alan = int.Parse(Console.ReadLine());
            Console.WriteLine("Semti giriniz:");
            ev1.Semt = Console.ReadLine();

            Console.WriteLine(ev.EvBilgileriGoster(ev1));
            Console.WriteLine(ev1.GetOdaSayisi());
        }       
    }

    class ev
    {
        private  int oda_sayisi; // field 
        private string semt;
        public int kat_no;
        public double alan;

        public string Semt { get => semt; set => semt = value.ToUpper(); }

        public void SetOdaSayisi(int oda_sayisi)=> this.oda_sayisi = Math.Abs(oda_sayisi);     
        public int GetOdaSayisi()=> oda_sayisi;
                
        public static string EvBilgileriGoster(ev Home) =>  $"Odasayısı :{Home.oda_sayisi}\n Katbilgisi : {Home.kat_no}\n Alan : {Home.alan} \n Semt : {Home.Semt}";
       
    }


    // private : sadece bulunduğu class içerisinden erişilebilir 
    // public : Her yerden erişilebilir
    //Class : Aynı zamanda bir veri tipidir , eğer önceden tanımlanmış veri tipleri bizim ihtiyacımızı karşılamıyorsa  o zaman class yazarak ihtiyacımıza özel  veri tipi oluşturabiliriz
    // class içinde tanımlanan static üyelerin nesnelerle bağlantısı yoktur. Oradan class ismi ile ulaşılabilir.. 
}
