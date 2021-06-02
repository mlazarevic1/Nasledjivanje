using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat2
{
    class Laptop : uredjaj, ilaptop
    {
        private string _Processor;

        public string Procesor
        {
            get
            {
                return _Processor;
            }
            set
            {
                if(value != "AMD" || value != "Intel")
                {
                    throw new Exception("Uneti proizvodjac procesora ne postoji");
                }
                else
                {
                    _Processor = value;
                }
            }
        }

        private int _Baterija;

        public int Baterija
        {
            get
            {
                return _Baterija;
            }
            set
            {
                if(value < 2000 || value > 10000)
                {
                    throw new Exception("Baterija sa toliko MAH ne postoji");
                }
                else
                {
                    _Baterija = value;
                }
            }
        }
        public string PokreniPrezentaciju()
        {

            return "Pokreni Prezentaciju - Laptop";

        }

        public override string UnosTeksta()
        {
            return "Unos pomocu tastature ili tac skrina-Laptop";
        }
    }
}
