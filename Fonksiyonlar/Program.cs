using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fonksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Proje1 //Matematiksel Fonksiyonlar

            // Mutlak değer alma. (abs)

            //int sayi;
            //Console.WriteLine("Sayıyı girin: ");
            //sayi = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Mutlak Değerli Hali: " + Math.Abs(sayi));

            //Console.ReadLine();



            // Üste yuvarlama . (ceiling)

            //double sayi;
            //Console.WriteLine("Sayıyı girin: ");
            //sayi=Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Sayının Üste Yuvarlanmış Hali: " + Math.Ceiling(sayi));

            //Console.Read();



            // Alta yuvarlama. (floor)

            //double sayi;
            //Console.WriteLine("Sayıyı girin: ");
            //sayi=Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Sayının Alta Yuvarlanmış Hali: " + Math.Floor(sayi));

            //Console.Read();





            // Üs alma. (pow)

            //double sayi;
            //Console.WriteLine("Sayıyı girin: ");
            //sayi=Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Sonuç: " + Math.Pow(sayi,5));
            //// 5. kuvvetini alma örneğini yaptım.
            //Console.Read();





            // Karakök alma. (sqrt)

            //double sayi;
            //Console.WriteLine("Sayıyı girin: ");
            //sayi = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Sonuç: " + Math.Sqrt(sayi));

            //Console.Read();





            //Cos-Sin değerleri bulma.

            //double sayi;
            //Console.WriteLine("Dereceyi girin: ");
            //sayi = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Sonuç: " + Math.Sin(sayi));

            //Console.Read();



            // Max-Min değerleri bulma.


            //double sayi1, sayi2;
            //Console.WriteLine("1.Sayıyı Girin: ");
            //sayi1=Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("2.Sayıyı Girin. ");
            //sayi2= Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Büyük sayi: " + Math.Max(sayi1,sayi2));

            //Console.ReadLine();






            //Proje2 //Zaman Fonksiyonları


            //DateTime zaman;
            //zaman = DateTime.Now;

            //Console.WriteLine("Tarih ve Saat: {0} " , zaman);

            //Console.ReadLine();





            //Proje3


            //DateTime zaman;
            //zaman = DateTime.Now;

            //int ay = zaman.Month;
            //int gun = zaman.Day;
            //int yil = zaman.Year;

            //DayOfWeek haftanıngunu = zaman.DayOfWeek;
            //Console.WriteLine( "Gün:  {0} ", gun);
            //Console.WriteLine("Ay:  {0} ", ay);
            //Console.WriteLine("Yıl:  {0} ", yil);

            //Console.WriteLine("Haftanın Günü:  {0} ",haftanıngunu );

            //Console.ReadLine();








            //Proje4 KISALTMALAR
            // kısa tarih=d
            // uzun tarih=D
            // tam tarih=f  - tam tarih ve sonuna saniye ekleme=F

            DateTime zaman;
            zaman = DateTime.Now;

            Console.WriteLine("C# Dersleri Tarih Saat Fonksiyonları");
            Console.WriteLine();

            Console.WriteLine("Kısa Tarih: {0:d} " , zaman);
            Console.WriteLine("Uzun Tarih:  {0:D} " , zaman);
            Console.WriteLine("Tam Tarih: {0:f}  " , zaman);
            Console.WriteLine("Tam Tarih2: {0:F} " , zaman);
            Console.ReadLine();














































































        }
    }
}
