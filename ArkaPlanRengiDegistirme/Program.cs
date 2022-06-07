using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkaPlanRengiDegistirme
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Arka ekranı siyah olmasını istemediğimizde aşağıdaki komutlarla farklı bir renk yapabiliriz.

            //Console.BackgroundColor= ConsoleColor.Green;
            //Console.Clear();
            //Console.WriteLine("Nasılsınız.");
            //Console.ReadLine();


            //Eğerki rengini değiştiğiniz  arka ekranın  yazı rengini de değişmek isterseniz aşağıdaki komutu ekleriz.


            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine("Nasılsınız.");
            Console.ReadLine();











        }
    }
}
