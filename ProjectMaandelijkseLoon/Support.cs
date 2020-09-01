using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMaandelijkseLoon
{
    public class Support : Werknemer
    {
        public const double Startloon = 2050;

        public Support(string naam, string geslacht, DateTime geboorteDatum, string rijksregisternummer,
                    DateTime datumIndiensttreding, string iBANNummer, bool bedrijfsWagen) 
                    : base(naam, geslacht, geboorteDatum, rijksregisternummer, datumIndiensttreding, iBANNummer, bedrijfsWagen)
        {

        }
    }
}
