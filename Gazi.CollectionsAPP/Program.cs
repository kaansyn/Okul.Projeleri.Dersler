using System;
using System.Collections;
using System.Collections.Generic;

namespace Gazi.CollectionsAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // int[] dizi = new int[2];
           // dizi[0] = 5; //Type Safe 
           // dizi[1] = 3;

           ////Non Generic Collections
           //// -BAŞLANGIÇ-
           //ArrayList a1 = new ArrayList();
           // a1.Add(5);
           // a1.Add(3);
           // a1.Add(6);
           // a1.Add(1);
           // a1.Add(2);
           // a1.Capacity = a1.Count;

           
           // int toplam =0;
           // for (int i = 0; i < a1.Count; i++)
           // {
                
           //     toplam += (int)a1[i];
           // }
           // Console.WriteLine(toplam);
           // Console.WriteLine($"eleman sayısı : {a1.Count}\nKapasite:{a1.Capacity}");

           // int sayi = 10; //Değer Tipidir - stack
           // object number = sayi;//Referans tipidir - Heap - "Boxing" işlemi
           // int _sayi = (int)number; // "Unboxing" işlemi 
        
           // //-BİTİŞ-
                
           // //Generic Collections
           // //-Başlangıç-
           // test<int , string > t = new test<int , string>();
           // t.veri1 = 10;
           // t.veri2 = "10";
            

           
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);
            list.Add(3);

            Console.WriteLine(list[0] + list[1]);

        }
    }

    //class test<T,U> where T : struct
    //                where U : class
    //{
    //    public T veri1;
    //    public U veri2;

    //    public void Print (T value)
    //    {
    //        Console.WriteLine(value);
    //    }
    //}
}



// Diziler : Başta eleman sayısı bilinmek zorunda . Tip Güvenliği sağlayan yapılardır.
// Koleksiyolar : Başta eleman sayısı bilinmek zorunda değil . Bir koleksiyona eleman ataması yapılırken , koleksiyonun boyutu dinamik olarak arttırllır.