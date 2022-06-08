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


            //Proje1

            //2x2 lik bir matris 
            // Matrisi okutmak için döngü oluşturmamız gerekiyor.
            // Satır için ayrı döngü, sütun için ayrı döngü.


            //int[,] dizi = new int[2, 2];
            //dizi[0, 0] = 25;
            //dizi[1, 0] = 35;
            //dizi[0, 1] = 17;
            //dizi[1, 1] = 16;


            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 2; j++)

            //        Console.Write(" {0} ", dizi[i, j]);
            //       //Üst satırda WriteLine yazma! yoksa matris formatına gelmiyor. Aksi halde değerleri alt alta yazıyor.
            //        Console.WriteLine();

            //}
            //Console.Read();






            //Proje2


            //Console.WriteLine("Matrislerde Toplama");

            //int[,] matris1 = { { 10, 12, 16, 13 }, { 21, 25, 28, 23 }, { 45, 15, 19, 46 }, { 58, 86, 47, 69 } };
            //int[,] matris2 = { { 1, 2, 3, 4 }, { 25, 24, 28, 26 }, { 12, 6, 45, 36 }, { 9, 8, 7, 6 } };
            //int[,] toplam = new int[4, 4];

            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j=0; j < 4; j++)
            //    {
            //        toplam[i, j] = matris1[i, j] + matris2[i, j];
            //    }

            //}

            //for (int k = 0; k < 4; k++)
            //{
            //    Console.WriteLine();
            //    for(int m = 0; m < 4; m++)
            //    {
            //        Console.Write(toplam[k,m] + "  ");
            //    }
            //}


            //Console.ReadLine();








            //Proje3

            //int satir, sutun;
            //Console.WriteLine("Satır sayısını girin: ");
            //satir=Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Sütün sayısını girin: ");
            //sutun = Convert.ToInt32(Console.ReadLine());

            //int[,] matris= new int[satir, sutun];   


            //for(int i = 0; i < satir; i++)
            //{
            //    for( int j=0; j < sutun; j++)
            //    {
            //        Console.Write("Matrisin {0} x {1} Değeri: " , i+1,j+1);  //{0} satıra karşılık gelicek, {1} sütüna karşılık gelicek.
            //        matris[i,j] = Convert.ToInt32(Console.ReadLine());
            //    }

            //}
            //Console.WriteLine();
            //Console.WriteLine("Matris: ");

            ////Matrisi Yazdırma komutları

            //for (int k = 0; k <satir; k++)
            //{
            //    for(int n=0; n<sutun; n++)
            //    {
            //        Console.Write(matris[k,n]+ " " );
               
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("Matris Transpoze: ");

            //// Matris Transpoze 
            ////Kare matris için geçerli.

            //for(int x=0; x<satir; x++)
            //{
            //    for (int y=0 ; y< sutun; y++)
            //    {
            //        Console.Write(matris[y,x] + " ");
            //    }
            //    Console.WriteLine();
            //}



            //Console.ReadLine();












        }
    }
}
