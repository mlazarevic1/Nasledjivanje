using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat2
{
    public class desktop : uredjaj, idesktop
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
                if (value.ToUpper() == "AMD" || value.ToUpper() == "INTEL")
                {
                    _Procesor = value;

                }
                else
                {
                    throw new Exception("Dostupni su samo AMD i INTEL konfiguracije.");
                    
                }

            }
        }

        private int _Napajanje;

        public int Napajanje
        {

            get
            {
                return _Napajanje;
            }
            set
            {
                if(value > 100 && value < 1000)
                {
                    _Napajanje = value;
                    
                }
                else
                {
                    throw new Exception("Uneto napajanje ne postoji");
                }
            }

        }
        public string PokreniVS()
        {
            return "Pokreni visual studio - DESKTOP";
        }

        public override string UnosTeksta()
        {
            return "Unos pomocu tastature-Desktop";
        }


    }
}
