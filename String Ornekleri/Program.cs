using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Ornekleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ad;
            Console.WriteLine("Lütfen İsminizi Giriniz: ");
            ad = Console.ReadLine();
            Console.WriteLine("Merhaba: {0}", ad);
            Console.Read();
        }
    }
}
