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

        //private static void yazdir(string bilgi)
        //{
        //    for (int i = 0; i < 10; i++)
        //        Console.WriteLine(bilgi);

        //}

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Metni Girin: ");
        //    string blg = Console.ReadLine();
        //    yazdir(blg);

        //    Console.ReadLine();
        //}





        //Proje2

        private static  int Topla(int s1,int s2)

        {
            int t = s1 + s2;
            return t;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Toplam: " + Topla(5,8));
            Console.WriteLine("Toplam: " + Topla(18,26));
            Console.ReadLine();
        }

        

    }
}
