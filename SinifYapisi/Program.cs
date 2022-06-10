using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinifYapisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba arbsnf = new Araba();  //Araba adlı sınıfı arbsnf adlı nesne ile çağırdık.
            arbsnf.renk = "siyah";
            arbsnf.fiyat = 150000;
            arbsnf.model = "2022";
            arbsnf.vites = "Manuel";
            arbsnf.plaka = "14 NC 456";


            Console.WriteLine("Araba1 Renk: " + arbsnf.renk);
            Console.WriteLine("Araba1 Fiyat: " + arbsnf.fiyat);
            Console.WriteLine("Araba1 Model: " + arbsnf.model);
            Console.WriteLine("Araba1 Vites:  " + arbsnf.vites);
            Console.WriteLine("Araba1 Plaka: " + arbsnf.plaka);

            Console.WriteLine();

            arbsnf.renk = "beyaz";
            arbsnf.fiyat = 100000;
            arbsnf.model = "2020";
            arbsnf.vites = "Otomatik";
            arbsnf.plaka = "54 PP 886";


            Console.WriteLine("Araba2 Renk: " + arbsnf.renk);
            Console.WriteLine("Araba2 Fiyat: " + arbsnf.fiyat);
            Console.WriteLine("Araba2 Model: " + arbsnf.model);
            Console.WriteLine("Araba2 Vites:  " + arbsnf.vites);
            Console.WriteLine("Araba2 Plaka: " + arbsnf.plaka);


            Console.Read();
        }
    }
}
