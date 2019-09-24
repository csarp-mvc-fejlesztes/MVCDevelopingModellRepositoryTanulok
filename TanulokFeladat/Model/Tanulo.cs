using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanulokFeladat.model
{
    class Tanulo
    {
        private string nev;
        private int osztalyzat;

        public Tanulo(string fajlsor)
        {
            string[] adat = fajlsor.Split(';');
            this.nev = adat[0];
            this.osztalyzat = Convert.ToInt32(adat[1]);
        }

        public string getNev()
        {
            return nev;
        }

        public int getOsztalyzat()
        {
            return osztalyzat;
        }

        public void setOsztalyzat(int osztalyzat)
        {
            this.osztalyzat = osztalyzat;
        }

        public void setNev(string tanulonev)
        {
            this.nev = tanulonev;
        }

        public bool OtosE()
        {
            if (getOsztalyzat() ==5)
            {
                return true;
            }
            else
                return false;            
        }

        public override string ToString()
        {
            return nev+" tanuló "+osztalyzat + " osztályzatot kapott";
        }
    }
}
