using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class Program
    {
        private static void veriler() //private gizli, erişilemez bilgi demektir.
        {
            Console.WriteLine("Müdür: Esra YILDIZ");
            Console.WriteLine("Öğretmen: Tansu GEM");
            Console.WriteLine("Okul: Atatürk Lisesi");
            Console.WriteLine("Şehir: İstanbul");
            Console.WriteLine(DateTime.Now.ToLongDateString());
        }
        static void Main(string[] args)
        {
            veriler(); //veriler();ifadesini kaç kez yazarsam yukarıdaki veriler o kadar gelir.
            Console.Read();
        }
    }
}
