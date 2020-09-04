using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMaandelijkseLoon
{
    public class ITSupport : Support
    {
        public ITSupport(string naam, string geslacht, DateTime geboorteDatum, string rijksregisternummer,
                    DateTime datumIndiensttreding, string iBANNummer, string functie, string contractType, 
                    bool bedrijfsWagen = false, double startLoon = 2050) 
                    : base(naam, geslacht, geboorteDatum, rijksregisternummer, datumIndiensttreding, 
                          iBANNummer, functie, contractType, bedrijfsWagen, startLoon)
        {

        }

        public override double CalculateAnciënniteit()
        {
            int experience = DateTime.Now.Year - DatumIndiensttreding.Year;
            double anciënniteit = 0;
            double salary = 0;
            double salITSupport = StartLoon - (StartLoon * 0.06);

            if (experience > 0)
            {
                salary = salITSupport;
                for (int i = 0; i < experience; i++)
                {
                    salary += salary * 0.01;
                }

                anciënniteit = salary - salITSupport;
            }

            return Math.Round(anciënniteit, 2);
        }
    }
}
