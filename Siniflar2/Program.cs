using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr = new Ogrenci(); //Ogrenci sınıfında ogr adlı bir nesne türettim.
            ogr.Adı = "Esra";
            ogr.Soyadı = "Yıldız";
            ogr.Alanı = "Sayısal";
            ogr.Yası = 17;

            Console.WriteLine("Adı: " + ogr.Adı );
            Console.WriteLine("Soyadı: " + ogr.Soyadı );
            Console.WriteLine("Alanı: " + ogr.Alanı);
            Console.WriteLine("Yaşı: " + ogr.Yası);

            Console.Read();
        }
    }
}
