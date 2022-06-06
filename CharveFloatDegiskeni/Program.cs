using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharveFloatDegiskeni
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Proje1   // Char degiskeninde tek karakterli veriler kullanılır.


            //char harf;
            //harf = 'g';

            //Console.WriteLine("HARF: " + harf);
            //Console.ReadLine();









            //Proje2


            char cinsiyet;

            Console.WriteLine("***Cinsiyetinizi Giriniz***");
            

            cinsiyet = Convert.ToChar(Console.ReadLine());

            if(cinsiyet == 'e' || cinsiyet=='E')
            {
                Console.WriteLine("Cinsiyet Erkektir...");
            }

            else if(cinsiyet == 'k' || cinsiyet=='K')
            {
                Console.WriteLine("Cinsiyet Kadındır....");
            }


            else
            {
                Console.WriteLine("Hatalı Giriş Yaptınız");
            }
            Console.ReadLine();



























        }
    }
}
