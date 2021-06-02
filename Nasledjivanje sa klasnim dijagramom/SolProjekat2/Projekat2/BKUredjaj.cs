using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat2
{
    public class uredjaj : iuredjaj
    {
       private int _memorija;

        public int memorija
        {
            get
            {
                return _memorija;
            }
            set
            {
                if (value < 1 || value > 4)
                {

                    throw new Exception("Uneta memorija vam nije u opsegu izmedju 1 i 4 terabajta");

                }
                else
                {
                    _memorija = value;
                }

            }
        }

        private int _ramMemorija;

        public int ramMemorija
        {
            get
            {
                return _ramMemorija;
            }
            set
            {
                if (value < 8 || value > 128)
                {

                    throw new Exception("Uneta ram memorija vam nije u opsegu izmedju 8 i 128 gigabajta");

                }
                else
                {
                    _ramMemorija = value;
                }

            }

        }

        private string _Proizvodjac;
        public string Proizvodjac
        {

            get
            {
                return _Proizvodjac;
            }
            set
            {
                if(value.Trim().Length > 0 && value.Trim().Length <= 20)
                {
                    
                    _Proizvodjac = value;
                }
                else 
                {
                    throw new Exception("Proizvodjac sa vise od 20 karaktera ne postoji");
                }

            }
        }

        private string _model;
        public string model
        {
            get
            {
                return _model;
            }
            set
            {
                if (value.Trim().Length > 0 && value.Trim().Length <= 20)
                {
                    _model = value;
                    
                }
                else
                {
                    throw new Exception("Model sa vise od 20 karaktera ne postoji");
                }
            }

        }


        private int _cena;

        public int cena
        {
            get
            {
                return _cena;
            }
            set
            {
                if (value > 0 && value < 100000)
                {
                    _cena = value;

                }
                else
                {
                    throw new Exception("Ne postoji uredjaj sa tolikom cenom");
                }

            }

        }


        public string Prodaj()
        {
            return "Prodaj - Uredjaj";
        }
        public string Dostava()
        {
            return "Uredjaj-Dostava";
        }
        public string Promocije()
        {
            return "Uredjaj-Promocije";
        }
        public virtual string UnosTeksta()
        {
            return "Uredjaj-Unos";
        }

    }
}
