using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class KontoLoomine
    {
        string eesnimi, perekonnanimi, sünniküüpäev, telefoninumber;
        int pin = 100, kontonumber = 1234;

        protected static List<KontoLoomine> date = new List<KontoLoomine>();

        protected string Eesnimi
        {
            get { return this.eesnimi; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new Exception();
                else eesnimi = value;
            }
        }

        protected string Perekonnanimi
        {
            get { return this.perekonnanimi; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new Exception();
                else perekonnanimi = value;
            }
        }

        protected string Sünnikuupäev
        {
            get { return this.sünniküüpäev; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new Exception();
                else sünniküüpäev = value;
            }
        }

        protected string Telefoninumber
        {
            get { return this.telefoninumber; }
            set
            {
                if ((string.IsNullOrEmpty(value)) || value.Length != 11)
                    throw new Exception();
                else
                    telefoninumber = value;
            }

        }

        protected int Pin
        {
            get { return this.pin; }
        }

        protected int Kontonumber
        {
            get { return this.kontonumber; }
        }

        public void LooKonto()
        {
            date.Add(this);
        }
    }
}
