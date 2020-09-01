using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMaandelijkseLoon
{
    public class CustomerSupport : Werknemer
    {
        public CustomerSupport(string naam, string geslacht, DateTime geboorteDatum, string rijksregisternummer,
                    DateTime datumIndiensttreding, string iBANNummer, bool bedrijfsWagen) 
                    : base(naam, geslacht, geboorteDatum, rijksregisternummer, datumIndiensttreding, iBANNummer, bedrijfsWagen)
        {

        }
    }
}
