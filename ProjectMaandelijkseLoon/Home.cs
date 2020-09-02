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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        //public static List<Werknemer> WerknemerLijst = new List<Werknemer>();
        public static bool IsAdd = false;
        public static int SelectedWerknemer;

        public static Company MijnCompany = new Company();
        
        private void Home_Load(object sender, EventArgs e)
        {
            btnEdit.Visible = false;
            btnDelete.Visible = false;
            if (MijnCompany.WerknemerLijst.Count > 0)
            {
                lbWerknemer.DataSource = null;
                lbWerknemer.DataSource = MijnCompany.WerknemerLijst;
            }
        }

        private void btnAddWerknemer_Click(object sender, EventArgs e)
        {
            IsAdd = true;
            AddOrEditWerknemer addWerknemer = new AddOrEditWerknemer();
            if (addWerknemer.ShowDialog() == DialogResult.OK)
            {
                lbWerknemer.DataSource = null;
                lbWerknemer.DataSource = MijnCompany.WerknemerLijst;
            }

            //addWerknemer.Show();
        }

        private void lbWerknemer_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEdit.Visible = true;
            btnDelete.Visible = true;

            if (lbWerknemer.SelectedIndex >= 0)
            {
                double ann = MijnCompany.WerknemerLijst[lbWerknemer.SelectedIndex].CalculateAnciënniteit();
                label1.Text = ann.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
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

        private void btnDelete_Click(object sender, EventArgs e)
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
    }
}
