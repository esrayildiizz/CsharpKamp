using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar5
{

    //Çok  Biçimlilik Örneği (içinde kalıtım da kullandım)
    class insan
    {
        public virtual void selamver()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Title = "Örnek Haziran 2022";
            Console.WriteLine("Merhaba Yağmurlu Yaz Günleri");
        }
    }

    class Türk : insan
    {
        public override void selamver()
        {
            Console.WriteLine("Esenlikler");
        }
    }


    class Fransız : insan
    {
        public override void selamver()
        {
            Console.WriteLine("Bonjour");
        }
    }


    class İngiliz:insan
    {
        public override void selamver()
        {
            Console.WriteLine("Hi");
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            İngiliz inglz=new İngiliz();   //En son hangi class'ı tanımladıysan ona göre yazılır.
            inglz.selamver();
            Console.Read();
        }
    }
}
