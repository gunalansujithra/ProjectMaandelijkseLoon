using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMaandelijkseLoon
{
    public class Company
    {
        public List<Werknemer> WerknemerLijst = new List<Werknemer>();

        public void EditWerknemerLijst(int selectedIndex, string naam, string geslacht, DateTime geboorteDatum, string rijksregisternummer,
                    DateTime datumIndiensttreding, string iBANNummer, string functie, string contractType, bool bedrijfsWagen)
        {
            WerknemerLijst[selectedIndex].Naam = naam;
            WerknemerLijst[selectedIndex].Geslacht = geslacht;
            WerknemerLijst[selectedIndex].GeboorteDatum = geboorteDatum;
            WerknemerLijst[selectedIndex].Rijksregisternummer = rijksregisternummer;
            WerknemerLijst[selectedIndex].DatumIndiensttreding = datumIndiensttreding;
            WerknemerLijst[selectedIndex].IBANNummer = iBANNummer;
            WerknemerLijst[selectedIndex].Functie = functie;
            WerknemerLijst[selectedIndex].ContractType = contractType;
            WerknemerLijst[selectedIndex].BedrijfsWagen = bedrijfsWagen;
        }

        public void DeleteWerknemer(int selectedIndex)
        {
            WerknemerLijst.RemoveAt(selectedIndex);
        }
    }
}
