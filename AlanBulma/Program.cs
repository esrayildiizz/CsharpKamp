using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlanBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int kenar, karealan, karecevre;


            Console.WriteLine("*****Karenin Alanını Ve Çevresini Bulma*****");
            Console.WriteLine();

            Console.WriteLine("Karenin Bir Kenarını Giriniz: ");
         
            kenar=Convert.ToInt32(Console.ReadLine());

            karealan = kenar * kenar;
            karecevre =kenar*4;

            Console.WriteLine("Kare Alan: " + karealan);
            Console.WriteLine("Kare Çevre: " + karecevre);


            Console.ReadLine(  );
            


        }
    }
}
