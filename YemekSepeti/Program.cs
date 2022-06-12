using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekSepeti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double secim, adet, toplam = 0;
            double hesap = 0;
            Console.WriteLine();
            Console.WriteLine("************************************ MENÜ *************************************");
            Console.WriteLine("**                                                                           **");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("**          YEMEKLER                  **          İÇECEKLER                  **");
            Console.WriteLine("**                                    **                                     **");
            Console.WriteLine("**    1-Et Döner    - 20.00TL         **        8-Ayran    -  2.00 TL        **");
            Console.WriteLine("**    2-Tavuk Döner - 10.00TL         **        9-Kola     -  5.00 TL        **");
            Console.WriteLine("**    3-Tantuni     - 8.50 TL         **        10-Fanta   -  5.00 TL        **");
            Console.WriteLine("**    4-Kokoreç     - 9.75 TL         **        11-Ice Tea -  6.75 TL        **");
            Console.WriteLine("**    5-Börek       - 5.50 TL         **        12-Sprite  -  5.00 TL        **");
            Console.WriteLine("**    6-Salata      - 7.25 TL         **        13-Çay     -  1.00 TL        **");
            Console.WriteLine("**    7-Pide        - 9.50 TL         **        14-Su      -  0.50 TL        **");
            Console.WriteLine("*******************************************************************************");

            for (int i=1; i<100; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("Alacağınız Ürünün Numarası: ");
                secim = Convert.ToDouble(Console.ReadLine());

                if (secim == 1)
                {
                    Console.Write("Kaç porsiyon Et Döner: ");
                    adet= Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 20;
                    hesap = hesap + toplam;
                }

                else if (secim == 2)
                {
                    Console.Write("Kaç porsiyon Tavuk Döner: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 10;
                    hesap = hesap + toplam;
                }


                else if (secim == 3)
                {
                    Console.Write("Kaç porsiyon Tantuni: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 8.50;
                    hesap = hesap + toplam;
                }


                else if (secim == 4)
                {
                    Console.Write("Kaç porsiyon Kokoreç: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 9.75;
                    hesap = hesap + toplam;
                }


                else if (secim == 5)
                {
                    Console.Write("Kaç porsiyon Börek: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 5.50;
                    hesap = hesap + toplam;
                }

                else if (secim == 6)
                {
                    Console.Write("Kaç porsiyon Salata: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 7.25;
                    hesap = hesap + toplam;
                }


                else if (secim == 7)
                {
                    Console.Write("Kaç porsiyon Pide: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 9.50;
                    hesap = hesap + toplam;
                }


                else if (secim == 8)
                {
                    Console.Write("Kaç Adet Ayran: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet *2;
                    hesap = hesap + toplam;
                }

                else if (secim == 9)
                {
                    Console.Write("Kaç Adet Kola: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 5;
                    hesap = hesap + toplam;
                }


                else if (secim == 10)
                {
                    Console.Write("Kaç Adet Fanta: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 5;
                    hesap = hesap + toplam;
                }


                else if (secim == 11)
                {
                    Console.Write("Kaç Adet Ice Tea: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 6.75;
                    hesap = hesap + toplam;
                }



                else if (secim == 12)
                {
                    Console.Write("Kaç Adet Sprite: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 5;
                    hesap = hesap + toplam;
                }


                else if (secim == 13)
                {
                    Console.Write("Kaç Adet Çay: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 1;
                    hesap = hesap + toplam;
                }


                else if (secim == 14)
                {
                    Console.Write("Kaç Adet Su: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 0.50;
                    hesap = hesap + toplam;
                }

                else

                    Console.WriteLine("Böyle Bir Şeçim Mevcut Değildir. ");
                    Console.WriteLine();
                    Console.WriteLine("Başka Bir İsteğiniz Var Mı? ");
                    string cevap = Console.ReadLine();
                if (cevap == "h" || cevap == "H" || cevap == "Hayır" || cevap == "HAYIR" || cevap == "hayır")
                    break;
                //break haricinde bir cevap gelirse bizi en başa götürür.

            }

            Console.WriteLine("Toplam Borcunuz: " + hesap);




            Console.Read();


        }
    }
}
