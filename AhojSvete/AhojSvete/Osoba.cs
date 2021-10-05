using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhojSvete
{
    class Osoba
    {
        public Osoba()
        {
            Jmeno = "nezadáno";
            Prijmeni = "nezadáno";
            Vek = 0;
        }
        public Osoba(string jmeno, string prijmeni)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = 0;
        }

        public Osoba(string jmeno, string prijmeni, int vek)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
        }

        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int Vek { get; set; }


        public override string ToString()
        {
            return Jmeno + "\t\t" + Prijmeni + "\t\t" + Vek;
        }
    }
}
