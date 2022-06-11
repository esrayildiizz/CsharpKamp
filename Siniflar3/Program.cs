using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emlak eml = new Emlak();
            eml.Semt = "Karasu";
            eml.Renk = "Sarı";
            eml.OdaSayısı = 3;
            eml.KatNo = 2;
            eml.Alan = -80; // Negatif bir değer girsek bile mutlak değer kısıtlaması getirdiğimiz için ekrana pozitif gelecektir.

            Console.WriteLine(" Evin Semti: " + eml.Semt);
            Console.WriteLine(" Evin Rengi: " + eml.Renk);
            Console.WriteLine(" Evin Oda Sayısı: " + eml.OdaSayısı);
            Console.WriteLine(" Evin Kat Numarası : " + eml.KatNo);
            Console.WriteLine(" Evin Toplam Alanı : " + eml.Alan  + "Metrekare");

            Console.Read();
        }
    }
}
