using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat2
{
    class MobilniTelefon : uredjaj, imobilniTelefon
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
                if (value != "SnapDragon" || value != "Exinos" || value != "Kirin")
                {
                    throw new Exception("Uneti proizvodjac procesora ne postoji");
                }
                else
                {
                    _Processor = value;
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
                if (value != "Amoled" || value != "LCD")
                {
                    throw new Exception("Uneti ekrani za tablet ne postoje");
                }
                else
                {
                    _tipEkrana = value;
                }
            }
        }

        private int _Punjac;

        public int Punjac
        {
            get
            {
                return _Punjac;
            }
            set
            {
                if(value < 5 || value > 120)
                {
                    throw new Exception("Uneti punjac ne postoji");
                }
                else
                {
                    _Punjac = value;
                }

            }
        }
        public string Poziv()
        {
            return "Pozovi - Mobilni telefon";

        }


    }
}
