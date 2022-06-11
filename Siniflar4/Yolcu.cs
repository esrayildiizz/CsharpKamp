using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar4
{
    internal class Yolcu
    {
        private string ad;
        private string soyad;
        private int yas;
        private string cinsiyet;

        public string Ad
        {
            get { return ad; }  
            set { ad = value.ToUpper(); } 
        }
        public string Soyad
        {
            get { return soyad; }   
            set { soyad = value.ToUpper(); }
        }
        public int Yas
        {
            get { return yas; } 
            set { yas = Math.Abs(value); }    
        }
        public string Cinsiyet
        {
            get { return cinsiyet; }    
            set { cinsiyet = value.ToLower(); }   
        }

    }
}
