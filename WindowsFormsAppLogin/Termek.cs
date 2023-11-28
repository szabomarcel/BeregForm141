using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppLogin
{
    internal class Termek
    {
        int termek_nev;
        int ar;
        int db;

        public Termek(int termek_nev, int ar, int db)
        {
            this.termek_nev = termek_nev;
            this.ar = ar;
            this.db = db;
        }
        public override string ToString()
        {
            return this.termek_nev + "" + this.ar + "" + this.db + "darab";
        }
    }
}
