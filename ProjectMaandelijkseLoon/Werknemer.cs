using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMaandelijkseLoon
{
    public class Werknemer
    {
        public string Naam { get; set; }
        public string Geslacht { get; set; }
        public DateTime GeboorteDatum { get; set; }
        public string Rijksregisternummer { get; set; }
        public DateTime DatumIndiensttreding { get; set; }
        public string IBANNummer { get; set; }
        public bool BedrijfsWagen { get; set; }

        public Werknemer(string naam, string geslacht, DateTime geboorteDatum, string rijksregisternummer, DateTime datumIndiensttreding, string iBANNummer, bool bedrijfsWagen)
        {
            Naam = naam;
            Geslacht = geslacht;
            GeboorteDatum = geboorteDatum;
            Rijksregisternummer = rijksregisternummer;
            DatumIndiensttreding = datumIndiensttreding;
            IBANNummer = iBANNummer;
            BedrijfsWagen = bedrijfsWagen;
        }
    }
}
