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
        public string Functie { get; set; }
        public string ContractType { get; set; }
        public double StartLoon { get; set; }

        public Werknemer(string naam, string geslacht, DateTime geboorteDatum, string rijksregisternummer, DateTime datumIndiensttreding, string iBANNummer, string functie, string contractType, bool bedrijfsWagen = false, double startLoon = 1900)
        {
            Naam = naam;
            Geslacht = geslacht;
            GeboorteDatum = geboorteDatum;
            Rijksregisternummer = rijksregisternummer;
            DatumIndiensttreding = datumIndiensttreding;
            IBANNummer = iBANNummer;
            Functie = functie;
            ContractType = contractType;
            BedrijfsWagen = bedrijfsWagen;
            StartLoon = contractType == "Voltijds" ? startLoon : Math.Round((startLoon / 38) * 25, 2);
        }

        public override string ToString()
        {
            return Naam;
        }

        public virtual double CalculateAnciënniteit()
        {
            int experience = DateTime.Now.Year - DatumIndiensttreding.Year;
            double anciënniteit = 0;
            double salary = 0;

            if (experience > 0)
            {
                salary = StartLoon;
                for (int i = 0; i < experience; i++)
                {
                    salary += salary * 0.01;
                }

                anciënniteit = salary - StartLoon;
            }

            return Math.Round(anciënniteit, 2);
        }

        public virtual double CalculateBedrijfsvoorheffing()
        {
            double bedrijfsvoorheffing;
            double taxPercentage = 0.1368;
            double anciënniteit = CalculateAnciënniteit();

            double loonAfterSocialPay = (StartLoon + anciënniteit) - 200;
            bedrijfsvoorheffing = loonAfterSocialPay * taxPercentage;

            return Math.Round(bedrijfsvoorheffing, 2);
        }

        public virtual double CalculateNetto()
        {
            double anciënniteit = CalculateAnciënniteit();
            double heffing = CalculateBedrijfsvoorheffing();

            double netto = StartLoon + anciënniteit - 200 - heffing;

            return netto;
        }
    }
}
