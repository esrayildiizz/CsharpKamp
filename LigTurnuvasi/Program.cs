using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigTurnuvasi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "C# Turnuvası";
            Console.WriteLine("Rastgele Lig Turnuvamıza Hoşgeldiniz \n");

            int gs = 0;
            int fb = 0;
            int bjk = 0;
            int ts = 0;
            int sayac = 1;

            int a1, a2, a3;
            int b1, b2, b3;
            int c1, c2, c3;
            int d1, d2, d3; 


           

            if (sayac == 1)
            {
                Random rastgele = new Random();

                a1 = rastgele.Next(0, 6);
                b1 = rastgele.Next(0, 6);
                c1 = rastgele.Next(0, 6);
                d1 = rastgele.Next(0, 6);

                Console.WriteLine("1.Hafta Skorları");
                Console.WriteLine("-------------------------");

                Console.WriteLine("GS " + a1 + " - " + b1 + " FB");
                Console.WriteLine("BJK " + c1 + " - " + d1 + " TS \n");
                sayac++;
                Console.ReadLine();
            }

            if (sayac == 2)
            {
                Random rastgele = new Random();

                a2 = rastgele.Next(0, 6);
                b2 = rastgele.Next(0, 6);
                c2 = rastgele.Next(0, 6);
                d2 = rastgele.Next(0, 6);

                Console.WriteLine("2.Hafta Skorları");
                Console.WriteLine("-------------------------");

                Console.WriteLine("FB " + b2 + " - " +c2+ " BJK" );
                Console.WriteLine( "GS " + a2+ " - " +d2+  " TS");
                sayac++;
                Console.ReadLine();
            }



            if (sayac == 3)
            {
                Random rastgele = new Random();

                a3 = rastgele.Next(0, 6);
                b3 = rastgele.Next(0, 6);
                c3 = rastgele.Next(0, 6);
                d3 = rastgele.Next(0, 6);

                Console.WriteLine("3.Hafta Skorları");
                Console.WriteLine("-------------------------");

                Console.WriteLine("FB " + b3 + " - " + d3 + " TS");
                Console.WriteLine("GS " + a3 + " - " + c3 + " BJK");
                sayac++;
                Console.ReadLine();
            }





        }
    }
}
