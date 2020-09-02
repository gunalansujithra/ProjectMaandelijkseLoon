using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMaandelijkseLoon
{
    public class StandardWerknemer : Werknemer
    {
        
        public StandardWerknemer(string naam, string geslacht, DateTime geboorteDatum, string rijksregisternummer, 
                    DateTime datumIndiensttreding, string iBANNummer, string functie, string contractType, 
                    bool bedrijfsWagen = false, double startLoon = 1900) 
                    : base (naam, geslacht, geboorteDatum, rijksregisternummer, datumIndiensttreding, 
                          iBANNummer, functie, contractType, bedrijfsWagen, startLoon)
        {

        }

        //public static double CalculateAnciënniteit()
        //{
        //    int experience = DateTime.Now.Year - DatumIndiensttreding.Year;
        //    double anciënniteit = 0;
        //    double salary = 0;


        //    if (experience > 0)
        //    {
        //        salary = Startloon;
        //        for (int i=0; i < experience; i++)
        //        {
        //            salary += salary * 0.01;
        //        }

        //        anciënniteit = salary - Startloon;
        //    }

        //    return anciënniteit;
        //}
    }
}
