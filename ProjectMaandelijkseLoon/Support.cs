using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMaandelijkseLoon
{
    public class Support : Werknemer
    {
        public Support(string naam, string geslacht, DateTime geboorteDatum, string rijksregisternummer,
                    DateTime datumIndiensttreding, string iBANNummer, string functie, string contractType, 
                    bool bedrijfsWagen = false, double startLoon = 2050) 
                    : base(naam, geslacht, geboorteDatum, rijksregisternummer, datumIndiensttreding, iBANNummer, 
                          functie, contractType, bedrijfsWagen, startLoon)
        {

        }

        public override double CalculateNetto()
        {
            double anciënniteit = CalculateAnciënniteit();
            double heffing = CalculateBedrijfsvoorheffing();

            double netto = StartLoon + anciënniteit - 200 - heffing + 50;

            return netto;
        }
    }
}
