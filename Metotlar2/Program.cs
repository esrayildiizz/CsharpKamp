using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar2
{
    internal class Program
    {

        //Proje1

        private static void yazdir(string bilgi)
        {
            for (int i = 0; i < 10; i++)
                Console.WriteLine(bilgi);

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Metni Girin: ");
            string blg = Console.ReadLine();
            yazdir(blg);

            Console.ReadLine();
        }










    }
}
