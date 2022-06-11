using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar4
{

    //Kalıtım nasıl yapılır bunun örneğini gösterdim.Ucak:Yolcu şeklinde
    internal class Ucak:Yolcu
    {
        private string marka;
        private string kalkis;
        private string varis;

        public string Marka
        {
            get { return marka; }   
            set { marka = value.ToUpper(); }
        }

        public string Kalkis
        {
            get { return kalkis; }  
            set { kalkis = value.ToUpper(); }   
        }

        public string Varis
        {
            get { return varis; }   
            set { varis = value.ToUpper(); }    
        }
    }
}
