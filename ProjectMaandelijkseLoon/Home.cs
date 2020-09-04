using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjectMaandelijkseLoon
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        public static bool IsAdd = false;
        public static int SelectedWerknemer;

        public static Company MijnCompany = new Company();
        
        private void Home_Load(object sender, EventArgs e)
        {
            try
            {
                btnEdit.Visible = false;
                btnDelete.Visible = false;
                if (MijnCompany.WerknemerLijst.Count > 0)
                {
                    lbWerknemer.DataSource = null;
                    lbWerknemer.DataSource = MijnCompany.WerknemerLijst;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Code to add a new werknemer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddWerknemer_Click(object sender, EventArgs e)
        {
            try
            {
                IsAdd = true;
                AddOrEditWerknemer addWerknemer = new AddOrEditWerknemer();
                if (addWerknemer.ShowDialog() == DialogResult.OK)
                {
                    lbWerknemer.DataSource = null;
                    lbWerknemer.DataSource = MijnCompany.WerknemerLijst;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbWerknemer_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEdit.Visible = true;
            btnDelete.Visible = true;
        }

        /// <summary>
        /// Code to edit a werknemer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                IsAdd = false;
                SelectedWerknemer = lbWerknemer.SelectedIndex;

                AddOrEditWerknemer addWerknemer = new AddOrEditWerknemer();
                if (addWerknemer.ShowDialog() == DialogResult.OK)
                {
                    lbWerknemer.DataSource = null;
                    lbWerknemer.DataSource = MijnCompany.WerknemerLijst;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Code to delete a werknemer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int index = lbWerknemer.SelectedIndex;
                MijnCompany.DeleteWerknemer(index);
                MessageBox.Show("Werknemer verwijderd");

                lbWerknemer.DataSource = null;
                lbWerknemer.DataSource = MijnCompany.WerknemerLijst;

                if (MijnCompany.WerknemerLijst.Count <= 0)
                {
                    btnEdit.Visible = false;
                    btnDelete.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Code to create report for all werknemers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {                
                if (MijnCompany.WerknemerLijst.Count > 0)
                {
                    foreach (var item in MijnCompany.WerknemerLijst)
                    {
                        string type;
                        string bedrijfsWagen = item.BedrijfsWagen ? "JA" : "NEEN";

                        if (item.ContractType == "Voltijds")
                        {
                            type = "38/38";
                        }
                        else
                        {
                            type = "25/38";
                        }

                        double startSalary = item.StartLoon;
                        double anciennitSalary = item.CalculateAnciënniteit();
                        double anciennitSalTotal = startSalary + anciennitSalary;
                        double socialeAmount = 200;
                        double socialeTotal = anciennitSalTotal - socialeAmount;
                        double heffingAmount = item.CalculateBedrijfsvoorheffing();
                        double nettoAmount = item.CalculateNetto();

                        string line = "--------------------------------------------------";
                        string header = "LOONBRIEF " + DateTime.Now.ToString("MMMM yyyy");
                        string naam = "NAAM \t\t\t" + " : " + item.Naam.ToUpper();
                        string rijks = "RIJKSREGISTERNUMMER \t" + " : " + item.Rijksregisternummer;

                        string gesclacht = "GESLACHT \t\t" + " : " + item.Geslacht.ToUpper();
                        string geboorte = "GEBOORTEDATUM \t\t" + " : " + item.GeboorteDatum.ToString("dd MMMM yyyy");
                        string indiensDatum = "DATUM INDIENSTTREDING \t" + " : " + item.DatumIndiensttreding.ToString("dd MMMM yyyy");
                        string functie = "FUNCTIE \t\t" + " : " + item.Functie.ToUpper();
                        string contract = "AANTAL GEPRESTEERDE UREN" + " : " + type;
                        string wagen = "BEDRIJFSWAGEN \t\t" + " : " + bedrijfsWagen;

                        string startloon = "STARTLOON \t\t" + " :   € " + startSalary;
                        string anci = "ANCIËNNITEIT \t\t" + " : + € " + anciennitSalary;
                        string anciTotal = "\t\t\t" + " :   € " + anciennitSalTotal;
                        string sociale = "SOCIALE ZEKERHEID \t" + " : - € " + socialeAmount;
                        string socialeTot = "\t\t\t" + " :   € " + socialeTotal;
                        string heffing = "BEDRIJFSVOORHEFFING \t" + " : - € " + heffingAmount;
                        string heffingTotal;
                        if (item.Functie == "Support" || item.Functie == "IT support" || item.Functie == "Customer support")
                        {
                            heffingTotal = "\t\t\t" + " :   € " + (nettoAmount - 50);
                        }
                        else
                        {
                            heffingTotal = "\t\t\t" + " :   € " + nettoAmount;
                        }
                        string support = "SUPPORTWERK \t\t" + " : + € 50.00";
                        string netto = "NETTOLOON \t\t" + " :   € " + nettoAmount;

                        string filenaam = "LOONBRIEF " + item.Naam + " " + item.Rijksregisternummer.ToString() + " " + DateTime.Now.ToString("MMMM yyyy") + ".txt";
                        if (!File.Exists(filenaam))
                        {
                            File.Delete(filenaam);
                        }
                        using (StreamWriter writer = new StreamWriter(filenaam))
                        {
                            writer.WriteLine(line);
                            writer.WriteLine(header.ToUpper());
                            writer.WriteLine(line);

                            writer.WriteLine(naam);
                            writer.WriteLine(rijks);
                            writer.WriteLine(gesclacht);
                            writer.WriteLine(geboorte.ToUpper());
                            writer.WriteLine(indiensDatum.ToUpper());
                            writer.WriteLine(functie);
                            writer.WriteLine(contract);
                            writer.WriteLine(wagen);
                            writer.WriteLine(line);

                            writer.WriteLine(startloon);
                            writer.WriteLine(anci);
                            writer.WriteLine(anciTotal);
                            writer.WriteLine(sociale);
                            writer.WriteLine(socialeTot);
                            writer.WriteLine(heffing);
                            writer.WriteLine(heffingTotal);

                            if (item.Functie == "Support" || item.Functie == "IT support" || item.Functie == "Customer support")
                                writer.WriteLine(support);

                            writer.WriteLine(netto);
                            writer.WriteLine(line);
                        }
                    }

                    MessageBox.Show("Maandelijkse loonfische voor alle werknemers wordt gegenereerd");
                }
                else
                {
                    MessageBox.Show("Maandelijkse loonfische wordt niet gegenereerd. Er zijn geen werknemers");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
