using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat2
{
    interface iuredjaj
    {

        int memorija { get; set; }
        int ramMemorija { get; set; }
        string Proizvodjac { get; set; }
        string model { get; set; }
        int cena { get; set; }

        string Prodaj();
        string Dostava();
        string Promocije();
        string UnosTeksta();


    }

    interface idesktop
    {
        string Procesor { get; set; }
        int Napajanje { get; set; }

        string PokreniVS();

    }


    interface ilaptop
    {
        string Procesor { get; set; }
        int Baterija { get; set; }

        string PokreniPrezentaciju();

    }

    interface itablet
    {

        int Baterija { get; set; }
        string tipEkrana { get; set; }

        string Crtanje();

    }

    interface imobilniTelefon
    {
        string Procesor { get; set; }
        string tipEkrana { get; set; }
        int Punjac { get; set; }

        string Poziv();

    }

    interface iGejmingKonzola
    {
        string Procesor { get; set; }
        int BrojDzojstika { get; set; }

        string UpaliIgricu();
    }

    interface isingleBoardRacunar
    {
        string Procesor { get; set; }

        string SurfujInternetom();

    }


    

}
