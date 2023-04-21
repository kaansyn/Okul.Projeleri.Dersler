using System;

namespace PersonelAppSube1Bil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p = new Personel();
            Console.WriteLine("Personel adı giriniz:");
            p.Ad = Console.ReadLine();
            Console.WriteLine("Personel soyadı giriniz:");
            p.Soyad = Console.ReadLine();
            Console.WriteLine("İşe giriş yılını giriniz:");
            p.Isegirisyil = int.Parse(Console.ReadLine());
            // p.Maas = 500000;
            Console.WriteLine(p.PersonelBilgi());


        }
    }

    class Personel
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        double maas;

        private int isegirisyil;
        public int Isegirisyil
        {
            get { return isegirisyil; }
            set
            {
                isegirisyil = value;
                this.maas = 10000 + (DateTime.Now.Year - isegirisyil) * 1000;
            }
        }

        public double Maas { get => maas; }

        public string PersonelBilgi() => $"{this.Ad} {this.Soyad} isimli personelin hesaplanan maaşı:{this.Maas}";

    }
}

//Maas=10000+(calistigiyil*1000)
