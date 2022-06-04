using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Proje1

            //int[] sayilar = { 10, 45, 21, 35, 64, 75, 84, 26 };

            //Console.WriteLine(sayilar[0]); //sayilar adlı dizimden birinci elemanı getir demek

            //Console.ReadLine();  





            //Proje2

            //string[] isimler = { "esra","ayse","veli","baran","hasan" };

            //Console.WriteLine(isimler[3]);

            //Console.ReadLine();





            //Proje3

            string[] sehirler = new string[3];

            for(int i = 0; i <3 ; i++)
            {
                Console.WriteLine("Şehir: ");
                sehirler[i] = Console.ReadLine();
            }


            Console.WriteLine("****Şehirler****");

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(sehirler[i]);
            }


            Console.ReadLine();
                













        }
    } 

}
