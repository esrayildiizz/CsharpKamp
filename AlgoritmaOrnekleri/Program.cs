﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmaOrnekleri
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Proje1 -Parse Kullanımı
            //Kullanıcının girdiği iki sayının karelerinin toplamını veren uygulama.

            Console.WriteLine("Lütfen Birinci Sayıyı Giriniz...");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen İkinci Sayıyı Giriniz...");
            int sayi2= int.Parse(Console.ReadLine());

            int sonuc = (sayi1 * sayi1) + (sayi2 * sayi2);

            Console.WriteLine("Sonuç: " + sonuc);

            Console.ReadLine();
        }
    }
}
