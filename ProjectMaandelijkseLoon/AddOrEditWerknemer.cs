using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMaandelijkseLoon
{
    public partial class AddOrEditWerknemer : Form
    {
        public AddOrEditWerknemer()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool isGeslacht = false;
            string errorMessage = "";
            if (rbMan.Checked  || rbVrouw.Checked)
            {
                isGeslacht = true;
            }
            
            if (txtNaam.Text.Trim().Length == 0)
            {
                epNaam.SetError(txtNaam, "Naam is niet ingevuld");
                errorMessage += "\r\n" + "Naam is niet ingevuld";
            }
            else
            {
                epNaam.Clear();
            }
            
            if (!isGeslacht)
            {
                epGeslacht.SetError(rbVrouw, "Geslacht is niet selecteerd");
                errorMessage += "\r\n" + "Geslacht is niet selecteerd";
            }
            else
            {
                epGeslacht.Clear();
            }

            if (dtpGeboorte.Value.Date == DateTime.Now.Date)
            {
                epGeboorte.SetError(dtpGeboorte, "Kies Geboortedatum");
                errorMessage += "\r\n" + "Kies Geboortedatum";
            }
            else
            {
                epGeboorte.Clear();
            }

            if (mtbRijksNummer.Text.Trim().Length < 12)
            {
                epRijks.SetError(mtbRijksNummer, "Rijksregisternummer is niet ingevuld");
                errorMessage += "\r\n" + "Rijksregisternummer is niet ingevuld";
            }
            else
            {
                epRijks.Clear();
            }

            if (mtbIban.Text.Trim().Length < 19)
            {
                epIban.SetError(mtbIban, "IBAN nummer is niet ingevuld");
                errorMessage += "\r\n" + "IBAN nummer is niet ingevuld";
            }
            else
            {
                epIban.Clear();
            }

            if (cbFuncties.SelectedIndex < 0)
            {
                epFunctie.SetError(cbFuncties, "Functies is niet geselecteerd");
                errorMessage += "\r\n" + "Functies is niet geselecteerd";
            }
            else
            {
                epFunctie.Clear();
            }

            if (cbContractType.SelectedIndex < 0)
            {
                epContract.SetError(cbContractType, "Contract type is niet geselecteerd");
                errorMessage += "\r\n" + "Contract type is niet geselecteerd";
            }
            else
            {
                epContract.Clear();
            }
            if (errorMessage.Trim().Length > 0)
            {
                MessageBox.Show(errorMessage);
            }

            if (txtNaam.Text.Trim().Length > 0 && isGeslacht && dtpGeboorte.Value.Date != DateTime.Now.Date
                && mtbRijksNummer.Text.Trim().Length == 12 && mtbIban.Text.Trim().Length == 19
                && cbFuncties.SelectedIndex >= 0 && cbContractType.SelectedIndex >= 0)
            {
                string naam = txtNaam.Text.Trim();
                string geslacht = "";
                if (rbMan.Checked)
                {
                    geslacht = rbMan.Text;
                }
                if (rbVrouw.Checked)
                {
                    geslacht = rbVrouw.Text;
                }
                DateTime geboorteDatum = dtpGeboorte.Value.Date;
                string rijksregisternummer = mtbRijksNummer.Text.Trim();
                DateTime indiensttredingDatum = dtpIndiensttreding.Value.Date;
                string ibanNummer = mtbIban.Text.Trim();
                string functie = cbFuncties.SelectedItem.ToString();
                string contractType = cbContractType.SelectedItem.ToString();
                bool bedrijfsWagen = false;

                if (Home.IsAdd)
                {
                    Werknemer newWerkNemer;
                    if (cbFuncties.SelectedItem.ToString() == "Standaard werknemer")
                    {
                        newWerkNemer = new StandardWerknemer(naam: naam, geslacht: geslacht, geboorteDatum: geboorteDatum,
                            rijksregisternummer: rijksregisternummer, datumIndiensttreding: indiensttredingDatum,
                            iBANNummer: ibanNummer, functie: functie, contractType: contractType);

                        Home.MijnCompany.WerknemerLijst.Add(newWerkNemer);

                       // double anni = newWerkNemer.CalculateAnciënniteit();

                    }
                    else if (cbFuncties.SelectedItem.ToString() == "Programmeur")
                    {
                        if (cbBedrijfsWagen.SelectedItem.ToString() == "Ja")
                        {
                            bedrijfsWagen = true;
                        }
                        newWerkNemer = new Programmeur(naam: naam, geslacht: geslacht, geboorteDatum: geboorteDatum,
                            rijksregisternummer: rijksregisternummer, datumIndiensttreding: indiensttredingDatum,
                            iBANNummer: ibanNummer, functie: functie, contractType: contractType, bedrijfsWagen: bedrijfsWagen);

                        Home.MijnCompany.WerknemerLijst.Add(newWerkNemer);
                    }
                    else if (cbFuncties.SelectedItem.ToString() == "Support")
                    {
                        newWerkNemer = new Support(naam: naam, geslacht: geslacht, geboorteDatum: geboorteDatum,
                            rijksregisternummer: rijksregisternummer, datumIndiensttreding: indiensttredingDatum,
                            iBANNummer: ibanNummer, functie: functie, contractType: contractType);

                        Home.MijnCompany.WerknemerLijst.Add(newWerkNemer);
                    }
                    else if (cbFuncties.SelectedItem.ToString() == "IT support")
                    {
                        newWerkNemer = new ITSupport(naam: naam, geslacht: geslacht, geboorteDatum: geboorteDatum,
                            rijksregisternummer: rijksregisternummer, datumIndiensttreding: indiensttredingDatum,
                            iBANNummer: ibanNummer, functie: functie, contractType: contractType);

                        Home.MijnCompany.WerknemerLijst.Add(newWerkNemer);
                    }
                    else if (cbFuncties.SelectedItem.ToString() == "Customer support")
                    {
                        newWerkNemer = new CustomerSupport(naam: naam, geslacht: geslacht, geboorteDatum: geboorteDatum,
                            rijksregisternummer: rijksregisternummer, datumIndiensttreding: indiensttredingDatum,
                            iBANNummer: ibanNummer, functie: functie, contractType: contractType);

                        Home.MijnCompany.WerknemerLijst.Add(newWerkNemer);
                    }
                    MessageBox.Show("Werknemer togevoegt");

                    

                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    int selectedIndex = Home.SelectedWerknemer;

                    if (functie == "Programmeur" && cbBedrijfsWagen.SelectedItem.ToString() == "Ja")
                    {
                        bedrijfsWagen = true;
                    }

                    Home.MijnCompany.EditWerknemerLijst(selectedIndex, naam, geslacht, geboorteDatum, rijksregisternummer,
                        indiensttredingDatum, ibanNummer, functie, contractType, bedrijfsWagen);
                                        
                    MessageBox.Show("Werknemer opgeslagd");

                    this.DialogResult = DialogResult.OK;
                }
            }            
        }

        private void AddOrEditWerknemer_Load(object sender, EventArgs e)
        {
            cbFuncties.Items.Add("Standaard werknemer");
            cbFuncties.Items.Add("Programmeur");
            cbFuncties.Items.Add("Support");
            cbFuncties.Items.Add("IT support");
            cbFuncties.Items.Add("Customer support");

            cbContractType.Items.Add("Voltijds");
            cbContractType.Items.Add("Deeltijds");

            cbBedrijfsWagen.Items.Add("Ja");
            cbBedrijfsWagen.Items.Add("Neen");

            lblBedrijfsWagen.Visible = false;
            cbBedrijfsWagen.Visible = false;

            if (Home.IsAdd)
            {
                txtNaam.Clear();
                rbMan.Checked = false;
                rbVrouw.Checked = false;
                dtpGeboorte.Value = DateTime.Now;
                mtbRijksNummer.Clear();
                dtpIndiensttreding.Value = DateTime.Now;
                mtbIban.Clear();
                cbFuncties.SelectedIndex = -1;
                cbContractType.SelectedIndex = -1;
            }
            else
            {
                int selectedIndex = Home.SelectedWerknemer;
                
                if (selectedIndex >= 0)
                {
                    Werknemer selectedWerknemer = Home.MijnCompany.WerknemerLijst[selectedIndex];

                    txtNaam.Text = selectedWerknemer.Naam;
                    if (selectedWerknemer.Geslacht == "Man")
                    {
                        rbMan.Checked = true;
                    }
                    else if (selectedWerknemer.Geslacht == "Vrouw")
                    {
                        rbVrouw.Checked = true;
                    }

                    dtpGeboorte.Value = selectedWerknemer.GeboorteDatum;
                    mtbRijksNummer.Text = selectedWerknemer.Rijksregisternummer;
                    dtpIndiensttreding.Value = selectedWerknemer.DatumIndiensttreding;
                    mtbIban.Text = selectedWerknemer.IBANNummer;
                    
                    foreach (var item in cbFuncties.Items)
                    {
                        if (item.ToString() == selectedWerknemer.Functie)
                        {
                            cbFuncties.SelectedItem = item.ToString();
                        }
                    }
                    foreach (var item in cbContractType.Items)
                    {
                        if (item.ToString() == selectedWerknemer.ContractType)
                        {
                            cbContractType.SelectedItem = item.ToString();
                        }
                    }

                    if (selectedWerknemer.Functie == "Programmeur")
                    {
                        lblBedrijfsWagen.Visible = true;
                        cbBedrijfsWagen.Visible = true;

                        if (selectedWerknemer.BedrijfsWagen)
                        {
                            cbBedrijfsWagen.SelectedIndex = 0;
                        }
                        else
                        {
                            cbBedrijfsWagen.SelectedIndex = 1;
                        }
                    }
                    else
                    {
                        lblBedrijfsWagen.Visible = false;
                        cbBedrijfsWagen.Visible = false;
                    }
                }
            }
        }
               
        private void cbFuncties_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFuncties.SelectedItem.ToString() == "Programmeur")
            {
                lblBedrijfsWagen.Visible = true;
                cbBedrijfsWagen.Visible = true;

                cbBedrijfsWagen.SelectedIndex = 0;
            }
            else
            {
                lblBedrijfsWagen.Visible = false;
                cbBedrijfsWagen.Visible = false;
            }

            if (cbFuncties.SelectedItem.ToString() == "IT support")
            {
                cbContractType.SelectedIndex = 0;
                cbContractType.Enabled = false;
            }
            else
            {
                cbContractType.SelectedIndex = -1;
                cbContractType.Enabled = true;
            }
        }
    }
}
