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


            //byte sayi;
            //sayi = 255; //256 yazınca hata veriyor.
            //Console.WriteLine(sayi);

            //Console.ReadLine();









            //Proje6 
            //Sbyte, byte'ın ikiye bölünmüş halidir.Yarısı negatif yarısı pozitif olmak üzere.
            //(sbyte: -128 ,0 ve 127 aralığındaki değerleri kapsar.)



            //Console.WriteLine("****Doğu Anadolu Bölgesi Hava Durumu****");

            //Console.WriteLine(" 1 Ocak 2022 Hava Tahminleri \n");

            //sbyte Erzurum, Malatya, Elazıg;

            //Erzurum = -35;
            //Malatya = 3;
            //Elazıg = -7;

            //Console.WriteLine("Erzurum Karlı: " + Erzurum);
            //Console.WriteLine("Malatya Çok Bulutlu:  " + Malatya);
            //Console.WriteLine("Elazığ Karla Karışık Yağmurlu: " + Elazıg);

            //Console.ReadLine();











            //Proje7  //short degiskeni

            //short s1, s2, s3;
            //s1 = 50;
            //s2 = 35;
            //s3 = 40;

            //Console.WriteLine(s1+s2+s3);
            //Console.ReadLine();



            //Proje8 //ushort degiskeni

            //ushort s1, s2;
            //s1 = 1;
            //s2 = 20;

            //Console.WriteLine(s1+s2);

            //Console.ReadLine();








            //Proje9  // bool degiskeninin iki sonucu vardır.
            //True veya False dur. // {0} yazan yere true veya false gelecektir.

            //int sayi;
            //Console.WriteLine("Sayıyı Girin: ");

            //sayi=Convert.ToInt32(Console.ReadLine());

            //bool durum1 = sayi > 0;
            //bool durum2 = sayi >10;

            //Console.WriteLine("Sayı Pozitif Mi? : {0} ", durum1);
            //Console.WriteLine("Sayı 10'dan Büyük Mü?: {0} " , durum2);
           
            //Console.ReadLine();





        }
    }
}
