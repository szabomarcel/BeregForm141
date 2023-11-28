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

        public int Termek_nev { get => termek_nev; set => termek_nev = value; }
        public int Ar { get => ar; set => ar = value; }
        public int Db { get => db; set => db = value; }
        public override string ToString()
        {
            return termek_nev;
        }
    }
}
