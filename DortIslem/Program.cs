using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DortIslem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayı1, sayı2, toplam, fark, carpim, bolum;
            Console.WriteLine("****Aritmetik Dört İşlem****");
            Console.WriteLine();


            Console.WriteLine("Birinci Sayıyı Giriniz: \n");
            sayı1= Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("İkinci Sayıyı Giriniz: \n");
            sayı2= Convert.ToInt32(Console.ReadLine());


            toplam = sayı1 + sayı2;
            Console.WriteLine("Toplam: " + toplam);
            Console.WriteLine();


            fark = sayı1 - sayı2;
            Console.WriteLine("Fark: " + fark);
            Console.WriteLine();


            carpim = sayı1 * sayı2;
            Console.WriteLine("Çarpım: " + carpim);
            Console.WriteLine();


            bolum = sayı1 / sayı2;
            Console.WriteLine("Bölüm: " + bolum);
          


            Console.ReadLine();


        }
    }
}
