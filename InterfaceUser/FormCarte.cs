using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceUser
{
    public partial class FormCarte : Form
    {
        int idInfirmiere;
        public FormCarte(int idInfirmiere)
        {
            InitializeComponent();
            this.idInfirmiere = idInfirmiere;
        }

        private void cbNomPersonne_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNomPersonne.SelectedValue.ToString() != "")
            {
                string adresse = Model.GetAdresseComplete(cbNomPersonne.SelectedValue.ToString());
                lbAdresse.Text = Model.GetAdresse(cbNomPersonne.SelectedValue.ToString());
                lbVille.Text = Model.GetVille(cbNomPersonne.SelectedValue.ToString());
                lbCp.Text = Model.GetCodePostale(cbNomPersonne.SelectedValue.ToString());
                webBrowser1.Navigate("https://www.google.com/maps?q=" + adresse);
            }
        }

        private void FormCarte_Load(object sender, EventArgs e)
        {

            cbNomPersonne.DataSource = Model.GetListNomPatient(this.idInfirmiere);
            StringBuilder queryadress = new StringBuilder();
            queryadress.Append("https://www.google.com/maps?q");
            webBrowser1.Navigate(queryadress + "/");
        }
    }
}
