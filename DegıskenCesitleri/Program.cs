using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegıskenCesitleri
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Proje1 //Decimal degiskeni

            //Girilen sayıya 'nokta' koyarsak hata vermemesi için 'm' harfi koymalıyız.

            //decimal sayi;
            //sayi = 12.345m;
            //Console.WriteLine(sayi);

            //Console.ReadLine();








            //Proje2

            ////Tür dönüşümleri yapılırken küçük tür'ü büyük tür'e uydurmamız gerekir.


            //decimal s1;
            //int s2;

            //s1=2.52m;
            //s2 = 6;

            //decimal toplam;
            ////toplam degeri int ile tanımlayınca hata veriyor. Çünkü int decimal'e göre küçük tür olarak kalıyor.

            //toplam = s1 + s2;

            //Console.WriteLine("Toplam: " +toplam);

            //Console.ReadLine();











            //Proje3
            //{0:C} kullanımı verilen ondalıklı sayıyı yuvarlama işlemi yapar.

            //decimal x = 0.996m;
            //decimal y = 999999;
            //decimal z = 0.991m;

            //Console.WriteLine("Para1: {0:C}" , x);
            //Console.WriteLine("Para2: {0:C}" , y);
            //Console.WriteLine("Para3: {0:C}"  , z); 

            //Console.ReadLine();









            //Proje4


            //decimal urun1, urun2, toplam;

            //int s1, s2;

            //urun1 = 14.85m;
            //urun2 = 21.48m;

            //Console.WriteLine("1.Ürünün Satış Miktarı: \n");
            //s1 = Convert.ToInt16(Console.ReadLine());

            //Console.WriteLine("2.Ürünün Satış Miktarı: \n");
            //s2 = Convert.ToInt16(Console.ReadLine());   

            //toplam= s1*urun1+ s2*urun2;

            //Console.WriteLine("Gün sonunda kasada olması gereken tutar: " + toplam);

            //Console.ReadLine();








            //Proje5 ( byte: 0 ile 255 arasındaki değerleri alır.)


            byte sayi;
            sayi = 255; //256 yazınca hata veriyor.
            Console.WriteLine(sayi);

            Console.ReadLine();






            //Proje6

           
























        }
    }
}
