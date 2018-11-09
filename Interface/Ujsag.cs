using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Ujsag : Interface1
    {
        string cim;
        int kiadasEv;
        int kiadasHonap;


        public Ujsag(string cim, int kiadasEv, int kiadasHonap) {
            this.cim = cim;
            this.kiadasEv = kiadasEv;
            this.kiadasHonap = kiadasHonap;
            
        }

        public string MegjelenitendoNev()
        {

            return string.Format("{0} {1} / {2}"), cim , kiadasEv , kiadasHonap);
        }

        public int MeddigKolcsonozheto()
        {
            return 0;
        }
    }
}
