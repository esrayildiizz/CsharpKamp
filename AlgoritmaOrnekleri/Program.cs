using System;
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



            //Console.WriteLine("Lütfen Birinci Sayıyı Giriniz...");
            //int sayi1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen İkinci Sayıyı Giriniz...");
            //int sayi2= int.Parse(Console.ReadLine());

            //int sonuc = (sayi1 * sayi1) + (sayi2 * sayi2);

            //Console.WriteLine("Sonuç: " + sonuc);

            //Console.ReadLine();







            // Proje2 
            // 1'den 10'a kadar olan sayıların küplerinin toplamını bulan uygulama.



            //int i;
            //int toplam = 0;

            //for (i = 1; i <= 10; i++)
            //{

            //    toplam = toplam + (i * i * i);

            //}

            //Console.Write("1-10 arası toplam = " + toplam);
            //Console.ReadLine();







            //Proje3
            // Doğum tarihi girilen kişinin yaşını hesaplayan uygulama.


            //Console.WriteLine("Lütfen Doğum Tarihinizi Giriniz: ");
            //DateTime dogumtarihi= Convert.ToDateTime(Console.ReadLine());
            //Console.WriteLine();
            //TimeSpan sonuc= DateTime.Now - dogumtarihi;
            //Console.WriteLine( "Yaşınız: " + sonuc.Days/365);

            //Console.ReadLine();






            //Proje4
            //Girilen sayının faktöriyelini hesaplayan uygulama.


            //Console.WriteLine("Lütfen sayıyı giriniz: \n");
            //int sayi=Convert.ToInt32(Console.ReadLine());
            //int sonuc = 1;

            //for(int i=sayi ; i>0 ;i--)
            //{
            //    sonuc *= i;
            //}

            //Console.WriteLine( "Girilen sayının faktöriyeli : " + sonuc);

            //Console.ReadLine();








            //Proje5
            //Girilen pozitif sayının kaç basamaklı olduğunu söyleyen uygulama.



            Console.WriteLine("Lütfen basamak sayısını öğrenmek istediğiniz sayıyı girin. ");
            int sayi=Convert.ToInt32(Console.ReadLine());

            int sonuc=0;
            for(int i = sayi; sayi>=10; i++)
            {
                sayi /= 10;
                sonuc++;
            }
            sonuc++;
            Console.WriteLine("Girilen sayının basamak sayısı: " +sonuc);
            Console.ReadLine();

















        }
    }
}
