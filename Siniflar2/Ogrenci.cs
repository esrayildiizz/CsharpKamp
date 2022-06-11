using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar2
{
    internal class Ogrenci
    {
        private string ad;
        private string soyad;
        private int yas;
        private string alan;

        public string Adı
        {
            get { return ad; }  //Bana klavyeden girilen ad değerini döndür, bana geri getir.
            set { ad = value; }  //Klavyeden girilen ad değerini set ile aktardım. Artık benim değerim olarak gözükecektir.Private olmaktan çıkar.

        }
        public string Soyadı
        {
            get { return soyad; }   
            set { soyad = value; }  
        } 
        public string Alanı
        {
            get { return alan; }
            set { alan = value; }   
        }
         public int Yası
        {
            get { return yas; }
            set
            {
                if (value < 18)
                {
                    yas = 18;
                }
                else
                {
                    yas = value;
                }
            }


        }

    }
}
