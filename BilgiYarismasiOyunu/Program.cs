using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiYarismasiOyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("****Bilgi Yarışmasına Hoşgeldiniz****");
            Console.Title = (" 5 SORULUK BİLGİ YARIŞMASI");

            String ad, soyad;

            Console.WriteLine("Adınız: ");
            ad = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Soyadınız: ");
            soyad = Convert.ToString(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("****YARIŞMA BAŞLIYOR****");
            Console.WriteLine("****Her Yanıttan Sonra Enter Tuşuna Basın Lütfen****");
            Console.WriteLine();
            int dogru, yanlis, para;
            dogru = 0;
            yanlis = 0;
            para= 0;

            string s1;
            Console.WriteLine("Soru-1: Cumhuriyet kaç yılında ilan edilmiştir? ");
            s1 = Convert.ToString(Console.ReadLine());
            String c1;
            Console.WriteLine(" A-1920 \n B-1923 \n C-1924 \n D-1926 \n Cevabınız: ");
            c1 = Convert.ToString(Console.ReadLine());  

            if (c1== "B")
            {
                dogru++;
                para = para + 100;
                Console.WriteLine("Tebrikler Doğru Cevapladınız...\n");
            }
            else
            {
                yanlis++; ;
                Console.WriteLine("Üzgünüm Yanlış Cevapladınız...\n");
            }


            string s2;
            Console.WriteLine("Soru-2: Türkiye nin başkenti hangi şehirdir? ");
            s2 = Convert.ToString(Console.ReadLine());
            String c2;
            Console.WriteLine(" A-Bursa \n B-Çanakkale \n C-Ankara \n D-Sakarya \n Cevabınız: ");
            c2 = Convert.ToString(Console.ReadLine());


            if (c2 == "C")
            {
                dogru++;
                para = para + 100;
                Console.WriteLine("Tebrikler Doğru Cevapladınız...\n");
            }

            else
            {
                yanlis++; ;
                Console.WriteLine("Üzgünüm Yanlış Cevapladınız...\n");
            }



            string s3;
            Console.WriteLine("Soru-3: Maki hangi bölgenin bitki örtüsüdür? ");
            s3 = Convert.ToString(Console.ReadLine());
            String c3;
            Console.WriteLine(" A-Akdeniz \n B-Marmara \n C-Ege \n D-Karadeniz \n Cevabınız: ");
            c3 = Convert.ToString(Console.ReadLine());



            if (c3 == "A")
            {
                dogru++;
                para = para + 100;
                Console.WriteLine("Tebrikler Doğru Cevapladınız...\n");
            }

            else
            {
                yanlis++; ;
                Console.WriteLine("Üzgünüm Yanlış Cevapladınız...\n");
            }




            string s4;
            Console.WriteLine("Soru-4: Hangisi İstanbul da bulunan bir semt değildir? ");
            s4 = Convert.ToString(Console.ReadLine());
            String c4;
            Console.WriteLine(" A-Pendik \n B-Sarıyer \n C-Üsküdar \n D-Urla \n Cevabınız: ");
            c4 = Convert.ToString(Console.ReadLine());



            if (c4 == "D")
            {
                dogru++;
                para = para + 100;
                Console.WriteLine("Tebrikler Doğru Cevapladınız...\n");
            }

            else
            {
                yanlis++; ;
                Console.WriteLine("Üzgünüm Yanlış Cevapladınız...\n");

            }



            string s5;
            Console.WriteLine("Soru-5: Avrupanın kullandığı ortak para birimi hangisidir? ");
            s5 = Convert.ToString(Console.ReadLine());
            String c5;
            Console.WriteLine(" A-Dolar \n B-Euro \n C-Tl \n D-Ruble \n Cevabınız: ");
            c5 = Convert.ToString(Console.ReadLine());



            if (c5 == "B")
            {
                dogru++;
                para = para + 100;
                Console.WriteLine("Tebrikler Doğru Cevapladınız...\n");
            }

            else
            {
                yanlis++; ;
                Console.WriteLine("Üzgünüm Yanlış Cevapladınız...\n");

            }



            Console.WriteLine("Adınız: " + ad);
            Console.WriteLine("Soyadınız: " + soyad);
            Console.WriteLine("Doğru Sayınız: " +dogru);
            Console.WriteLine("Yanlış Sayınız: " + yanlis);
            Console.WriteLine("Toplam Kazandığınız Para: " + para);
            Console.WriteLine();
            Console.WriteLine("****OYUN BİTTİ**** ");



            Console.ReadLine();




















































        }
    }
}
