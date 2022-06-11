using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar3
{
    internal class Emlak
    {

        //Kapsülleme  Get, Set Kullanımı Örneği

        private string semt;
        private string renk;
        private int odasayisi;
        private int katno;
        private double alan;

        public string Semt
        {
            get { return semt; }
            set { semt = value.ToUpper(); }
        }
        public string Renk
        {
            get { return renk; }
            set { renk = value.ToUpper(); } 
        }
        public int OdaSayısı
        {
            get { return odasayisi; }   
            set { odasayisi = Math.Abs(value); }  
        }
        public int KatNo
        {
            get { return katno; }   
            set { katno = Math.Abs(value); } 
        }
        public double Alan
        {
            get { return alan; }
            set {  alan = Math.Abs(value); }    
            
        }
        
    }
}
