using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CokBoyutluDiziler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //2x2 lik bir matris 
            // Matrisi okutmak için döngü oluşturmamız gerekiyor.
            // Satır için ayrı döngü, sütun için ayrı döngü.


            int[,] dizi = new int[2, 2];
            dizi[0, 0] = 25;
            dizi[1, 0] = 35;
            dizi[0, 1] = 17;
            dizi[1, 1] = 16;


            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                
                    Console.Write(" {0} ", dizi[i, j]);
                   //Üst satırda WriteLine yazma! yoksa matris formatına gelmiyor. Aksi halde değerleri alt alta yazıyor.
                    Console.WriteLine();
                
            }
            Console.Read();



        }
    }
}
