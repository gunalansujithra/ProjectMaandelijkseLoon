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

        //public bool IsCar { get; set; }

        public Programmeur(string naam, string geslacht, DateTime geboorteDatum, string rijksregisternummer,
                DateTime datumIndiensttreding, string iBANNummer, string functie, string contractType, 
                bool bedrijfsWagen = false, double startLoon = 2200) 
                : base(naam, geslacht, geboorteDatum, rijksregisternummer, datumIndiensttreding, 
                      iBANNummer, functie, contractType, bedrijfsWagen, startLoon)
        {
            //IsCar = isCar;
        }
    }
}
