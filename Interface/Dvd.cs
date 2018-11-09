using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Dvd : Interface1, IComparable<Dvd>
    {
        string cim;
        int hossz;

        public string Cim
        {
            get
            {
                return cim;
            }

            set
            {
                cim = value;
            }
        }

        public Dvd(string cim, int hossz)
        {
            this.cim = cim;
            this.hossz = hossz;

        }

        public string MegjelenitendoNev()
        {

            return this.cim
                ;
        }

        public int MeddigKolcsonozheto()
        {
            return 7;
        }

        public double FutasIdoOra() {
                return hossz/60.0;
        }

        public int CompareTo(Dvd other)
        {
            if (this.hossz < other.hossz)
            {
                return -1;
            }
            else if (this.hossz > other.hossz)
            {
                return 1;
            }
            else {
                return 0;
            }
                
        }
    }
}
