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

            Console.Title = "*****C# Turnuvası*****";
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
                if (a1 > b1)
                {
                    gs = gs + 3;
                }
                if (b1 > a1)
                {
                    fb= fb + 3; 
                }
                if (a1 == b1)
                {
                    gs = gs + 1;
                    fb= fb + 1; 
                }
                Console.WriteLine("BJK " + c1 + " - " + d1 + " TS \n");
                if (c1 > d1)
                {
                    bjk = bjk + 3;
                }
                if (d1 > c1)
                {
                    ts = ts + 3;
                }
                if (c1 == d1)
                {
                    bjk = bjk + 1;
                    ts = ts + 1;
                }
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
                if (b2 > c2)
                {
                    fb = fb + 3;
                }
                if (c2 > b2)
                {
                    bjk = bjk + 3;
                }
                if (b2 == c2)
                {
                    fb = fb + 1;
                    bjk = bjk + 1;
                }
                Console.WriteLine( "GS " + a2+ " - " +d2+  " TS");
                if (a2 > d2)
                {
                    gs = gs + 3;
                }
                if (d2 > a2)
                {
                    ts = ts + 3;
                }
                if (b2 == c2)
                {
                    gs = gs + 1;
                    ts = ts + 1;
                }
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
                if (b3 > d3)
                {
                    fb = fb + 3;
                }
                if (d3 > b3)
                {
                    ts = ts + 3;
                }
                if (b3 == d3)
                {
                    fb = fb + 1;
                    ts = ts + 1;
                }
                Console.WriteLine("GS " + a3 + " - " + c3 + " BJK");
                if (a3 > c3)
                {
                    gs = gs + 3;
                }
                if (c3 > a3)
                {
                    bjk = bjk + 3;
                }
                if (a3 == c3)
                {
                    gs = gs + 1;
                    bjk = bjk + 1;
                }
                sayac++;
                Console.ReadLine();
            }

            if(sayac == 4)
            {
                Console.WriteLine("****Maçlar Tamamlandı****\n");
                Console.WriteLine("PUAN TABLOSU\n");
                Console.WriteLine("GS: " + gs);
                Console.WriteLine("FB: " +fb);
                Console.WriteLine("BJK: " +bjk);
                Console.WriteLine("TS: " +ts);
            }
            Console.WriteLine(); 

            if (gs>fb && gs>bjk && gs>ts)
            {
                Console.WriteLine("**GALATASARAY ŞAMPİYON**");
            }

            if(fb>gs && fb>ts && fb>bjk)
            {
                Console.WriteLine("**FENERBAHÇE ŞAMPİYON**");
            }

            if(bjk>gs && bjk>fb && bjk>ts)
            {
                Console.WriteLine("**BEŞİKTAŞ ŞAMPİYON**");
            }
            if(ts>gs && ts>fb && ts>bjk)
            {
                Console.WriteLine("**TRABZONSPOR ŞAMPİYON**");
            }
            
                
         
            Console.ReadLine();
        }
    }
}
