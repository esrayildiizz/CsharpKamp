using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ucak uck= new Ucak();
            uck.Marka = "Türk Hava Yolları";
            uck.Kalkis = "Adana-Şakirpaşa";
            uck.Varis = "İstanbul-Sabiha Gökçen";
            uck.Ad = "Esra";
            uck.Soyad = "Yıldız";
            uck.Yas = 24;
            uck.Cinsiyet = "Kadın";

            Console.WriteLine("Hava Yolu Şirketi: " + uck.Marka);
            Console.WriteLine("Kalkış Yeri: " + uck.Kalkis);
            Console.WriteLine("Varış Yeri: " + uck.Varis);
            Console.WriteLine("Yolcu ADI: " + uck.Ad);
            Console.WriteLine("Yolcu SOYADI: " + uck.Soyad);
            Console.WriteLine("Yolcu Yaşı: " + uck.Yas);
            Console.WriteLine("Yolcu Cinsiyeti: " + uck.Cinsiyet);

            Console.Read();
        }
    }
}
