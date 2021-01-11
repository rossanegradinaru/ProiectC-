using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiunePortofoliuActiuni
{
    public class Actiuni
    {
        private string denumireSocietate;
        private int numarActiuni;
        private double valoareNominala;
        private double pretVanzare;

        public Actiuni(string d, int n, double v, double p)
        {
            denumireSocietate = d;
            numarActiuni = n;
            valoareNominala = v;
            pretVanzare = p;
        }

        public Actiuni()
        {
            denumireSocietate = "";
            numarActiuni = 0;
            valoareNominala = 0.0F;
            pretVanzare = 0.0F;
        }

        public string DenumireSocietate
        {
            get { return denumireSocietate; }
            set { denumireSocietate = value; }
        }

        public int NumarActiuni
        {
            get { return numarActiuni; }
            set
            { if (value >= 0)
                    numarActiuni = value;
              else
                {
                    throw new InvalidOperationException("Numarul de actiuni nu poate fi negativ!");
                }

                 }
        }

        public double ValoareNominala
        {
            get { return valoareNominala; }
            set
            {
                if (value >= 0)
                    valoareNominala = value;
                else
                {
                    throw new InvalidOperationException("Valoarea nominala nu poate fi negativa!");
                }
            }
        }

        public double PretVanzare
        {
            get { return pretVanzare; }
            set
            {
                if (value >= 0)
                    pretVanzare = value;
                else
                {
                    throw new InvalidOperationException("Pretul de vanzare nu poate fi negativ!");
                }

            }
        }
    }
}

