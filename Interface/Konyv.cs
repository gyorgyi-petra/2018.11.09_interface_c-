using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Konyv : Interface1
    {

        string cim;
        string szerzo;
        string isbn;


        public Konyv(string cim, string szerzo, string isbn)
        {
            this.cim = cim;
            this.szerzo = szerzo;
            this.isbn = isbn;

        }

        public string MegjelenitendoNev()
        {

            return szerzo + ": " + cim;
        }

        public int MeddigKolcsonozheto()
        {
            return 14;
        }

    }
}
