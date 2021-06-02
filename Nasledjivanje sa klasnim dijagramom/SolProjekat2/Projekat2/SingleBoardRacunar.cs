using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat2
{
    class SingleBoardRacunar : uredjaj, isingleBoardRacunar
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

        public string SurfujInternetom()
        {
            return "Surfuj-Single board racunar";
        }


    }
}
