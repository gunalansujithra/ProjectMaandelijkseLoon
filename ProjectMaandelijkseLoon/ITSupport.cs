using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMaandelijkseLoon
{
    public class ITSupport : Werknemer
    {
        public ITSupport(string naam, string geslacht, DateTime geboorteDatum, string rijksregisternummer,
                    DateTime datumIndiensttreding, string iBANNummer, bool bedrijfsWagen) 
                    : base(naam, geslacht, geboorteDatum, rijksregisternummer, datumIndiensttreding, iBANNummer, bedrijfsWagen)
        {

        }
    }
}
