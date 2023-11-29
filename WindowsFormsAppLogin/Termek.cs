using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppLogin
{
    internal class Termek
    {
        public int termek_id;
        public int termek_nev;
        public int ar;
        public int db;

        public Termek(int termek_id, int termek_nev, int ar, int db)
        {
            this.termek_id = termek_id;
            this.termek_nev = termek_nev;
            this.ar = ar;
            this.db = db;
        }
        public override string ToString()
        {
            return this.termek_id+ "" + this.termek_nev + "" + this.ar + "" + this.db + "darab";
        }
    }
}
