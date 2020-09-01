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
                DateTime datumIndiensttreding, string iBANNummer, bool bedrijfsWagen) 
                : base(naam, geslacht, geboorteDatum, rijksregisternummer, datumIndiensttreding, iBANNummer, bedrijfsWagen)
        {
            //IsCar = isCar;
        }
    }
}
