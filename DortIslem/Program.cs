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
            int sayı1, sayı2, toplam;

            Console.WriteLine("****Toplama İşlemi****");

            Console.WriteLine("Birinci Sayıyı Giriniz: ");
            sayı1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci Sayıyı Giriniz: ");
            sayı2= Convert.ToInt32(Console.ReadLine());

            toplam = sayı1 + sayı2;
            Console.WriteLine( "Toplam: " +toplam);

            Console.ReadLine();
        }
    }
}
