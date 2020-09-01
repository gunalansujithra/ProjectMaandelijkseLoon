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
            if (rbMan.Checked  || rbVrouw.Checked)
            {
                isGeslacht = true;
            }

            if (txtNaam.Text.Trim().Length > 0 && isGeslacht && mtbRijksNummer.Text == string.Empty
                && mtbIban.Text.Trim().Length > 0 && cbFuncties.SelectedIndex >= 0 && cbContractType .SelectedIndex >= 0)
            {

            }
            else if (txtNaam.Text.Trim().Length == 0)
            {
                epAdd.SetError(txtNaam, "Naam is niet ingevuld");
            }
            else if (!isGeslacht)
            {
                epAdd.SetError(rbVrouw, "Geslacht is niet selecteerd");
            }
            else if (string.IsNullOrEmpty(mtbRijksNummer.Text.Trim()))
            {
                epAdd.SetError(mtbRijksNummer, "Rijksregisternummer is niet ingevuld");
            }
            else if (mtbIban.Text.Trim().Length == 0)
            {
                epAdd.SetError(mtbIban, "IBAN nummer is niet ingevuld");
            }
            else if (cbFuncties.SelectedIndex < 0)
            {
                epAdd.SetError(cbFuncties, "Functies is niet geselecteerd");
            }
            else if (cbContractType.SelectedIndex < 0)
            {
                epAdd.SetError(cbContractType, "Contract type is niet geselecteerd");
            }


            this.DialogResult = DialogResult.OK;
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
        }
    }
}
