using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiunePortofoliuActiuni
{
    public class DateActionari
    {
        private string nume;
        private string prenume;
        private string CNP;
        private string tipActiune;

        public DateActionari(string n, string p, string c,string t)
        {
            nume = n;
            prenume = p;
            CNP = c;
            tipActiune = t;
        }

        public string Nume
        {
            get { return nume; }
            set { nume = value; }

        }

        public string Prenume
        {
            get { return prenume; }
            set { prenume = value; }
        }

        public string Cnp
        {
            get { return CNP; }
            set { CNP = value; }
        }

        public string TipActiune
        {
            get { return tipActiune; }
            set { tipActiune = value; }
        }


    }
}
