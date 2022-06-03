using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleDegiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Öğrenci Not Hesaplama ");

            double not1, not2, not3, proje, ort;
            string ad, soyad, numara;

            Console.WriteLine("****Öğrenci Kimlik Bilgileri****");

            Console.Write("Adınız: ");
            ad = Console.ReadLine();
            Console.Write("Soyadınız: ");
            soyad= Console.ReadLine();  
            Console.Write("Numaranız:");
            numara = Console.ReadLine();

            Console.WriteLine("****Öğrenci Sınav Bilgileri****");

            Console.Write("Brinci Sınav: ");
            not1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("İkinci Sınav: ");
            not2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Üçüncü Sınav:. ");
            not3= Convert.ToDouble(Console.ReadLine());
            Console.Write("Proje Notunuz. ");
            proje = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("****Ortama****");
            ort = (not1 + not2 + not3 + proje) / 4;
            Console.WriteLine("Ad Soyad: " + ad + soyad);
            
         
            Console.Write("Ortalamanız:  " + ort);

            Console.ReadLine();
            
        }
    }
}
