using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat2
{
    class Tablet : uredjaj, itablet
    {
        private int _Baterija;

        public int Baterija
        {
            get
            {
                return _Baterija;
            }
            set
            {
                if (value < 2000 || value > 5000)
                {
                    throw new Exception("Baterija sa toliko MAH ne postoji");
                }
                else
                {
                    _Baterija = value;
                }

            }
        }

        private string _tipEkrana;

        public string tipEkrana
        {
            get
            {
                return _tipEkrana;
            }
            set
            {
                if(value != "Amoled" || value != "LCD")
                {
                    throw new Exception("Uneti ekrani za tablet ne postoje");
                }
                else
                {
                    _tipEkrana = value;
                }
            }
        }

        public string Crtanje()
        {
            return "Crtanje - Tablet";
        }

        public override string UnosTeksta()
        {
            return "Unos pomocu tastature ili tac skrina-Tablet";
        }




    }
}
