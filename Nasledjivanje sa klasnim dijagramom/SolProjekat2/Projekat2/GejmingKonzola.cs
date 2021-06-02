using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat2
{
    class GejmingKonzola : uredjaj, iGejmingKonzola
    {
        private string _Procesor;

        public string Procesor
        {
            get
            {
                return _Procesor;
            }
            set
            {
                if (value != "AMD" || value != "INTEL")
                {
                    throw new Exception("Dostupni su samo AMD i INTEL konfiguracije.");

                }
                else
                {
                    _Procesor = value;
                }

            }
        }

        private int _BrojDzojstika;
        public int BrojDzojstika 
        {
            get
            {
                return _BrojDzojstika; 
            }
            set
            {
                if(value < 1 || value > 5)
                {
                    throw new Exception("Nijedna gejming konzola ne nudi toliko dzojstika");
                }
                else
                {
                    _BrojDzojstika = value;
                }

            }


        }

        public string UpaliIgricu()
        {
            return "Upali igricu - Gejming Konzola";
        }

        public override string UnosTeksta()
        {
            return "Unos pomocu dzojstika-Gejming konzola";
        }

    }
}
