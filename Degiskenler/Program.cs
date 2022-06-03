using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ınt_değişkeni
{
    public class Program
    {
        static void Main(string[] args)
        {
            string ad, soyad, numara;
            int sınav1, sınav2, sınav3, proje, ortalama;

            Console.WriteLine();
            Console.WriteLine("****Öğrenci Bilgi****");
            Console.WriteLine();

            ad = "Esra";
            soyad = "YILDIZ";
            numara = "123456";

            Console.WriteLine("AD= " + ad);
            Console.WriteLine("SOYAD= " + soyad);
            Console.WriteLine("NUMARA= " + numara);


            Console.WriteLine();
            Console.WriteLine("****Not Bilgi****");
            Console.WriteLine();

            sınav1 = 60;
            sınav2 = 70;
            sınav3 = 100;
            proje = 90;

            Console.WriteLine("Sınav1= " + sınav1);
            Console.WriteLine("Sınav2= " + sınav2);
            Console.WriteLine("Sınav3= " + sınav3);
            Console.WriteLine("Proje notu= " + proje);

            Console.WriteLine();
            Console.WriteLine("****Ortalama Bilgi****");
            Console.WriteLine();

            ortalama = (sınav1 + sınav2 + sınav3 + proje) / 4;
            Console.WriteLine("Ortalama= " + ortalama);


            Console.ReadLine();


        }
    }
}
