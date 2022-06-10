using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar3
{
    internal class Metotlar
    {
        int topla(int a, int b)
        {
            return a + b; //a ve b toplamını döndür.
        }
        static void Main(string[] args)
        {
            Metotlar mtr=new Metotlar(); //mtr adında  metotlar sınıfından türemiş bir nesne oluşturduk.
            int z;
            z = mtr.topla(1, 6);
            Console.WriteLine("Toplam: " + z);
            Console.ReadLine();
        }
    }
}
