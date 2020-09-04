using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMaandelijkseLoon
{
    public class Programmeur : Werknemer
    {
        public const double Startloon = 2200;

        public Programmeur(string naam, string geslacht, DateTime geboorteDatum, string rijksregisternummer,
                DateTime datumIndiensttreding, string iBANNummer, string functie, string contractType, 
                bool bedrijfsWagen = false, double startLoon = 2200) 
                : base(naam, geslacht, geboorteDatum, rijksregisternummer, datumIndiensttreding, 
                      iBANNummer, functie, contractType, bedrijfsWagen, startLoon)
        {
        
        }

        public override double CalculateBedrijfsvoorheffing()
        {
            double bedrijfsvoorheffing = 0;
            double taxPercentage = BedrijfsWagen ? 0.173 : 0.1368;
            double anciënniteit = CalculateAnciënniteit();

            double loonAfterSocialPay = (StartLoon + anciënniteit) - 200;
            bedrijfsvoorheffing = loonAfterSocialPay * taxPercentage;

            return Math.Round(bedrijfsvoorheffing, 2);
        }

    }
}
