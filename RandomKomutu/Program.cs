﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomKomutu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Proje1 

            //Random rastgele = new Random();
            //int a;
            //a=rastgele.Next(0,10);  //Sol taraftaki değer aralığa dahil fakat sağ taraftaki değer aralığa dahil değil.

            //Console.WriteLine(a);
            //Console.ReadLine(); 







            //Proje2


            //Random  rastgele= new Random();
            //int a, b;

            //a=rastgele.Next(0,10);
            //b=rastgele.Next(0,10);

            //Console.WriteLine("a: "+a);
            //Console.WriteLine("b: "+b);

            //Console.ReadLine();







            //Proje3

            Random rastgele= new Random();
            int sayi;
            sayi=rastgele.Next(50);   // Parantez içi bize değerin 0 ile 50 arasında geleceğini söylüyor.

            Console.WriteLine(sayi);

            Console.ReadLine();















        }
    }
}
