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
        public FormCarte()
        {
            InitializeComponent();
            cbNom.DataSource = Model.GetListNomPersonne();
            StringBuilder queryadress = new StringBuilder();
            queryadress.Append("https://www.google.com/maps?q");
            webBrowser1.Navigate(queryadress + "/");
        }

        private void cbNom_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string adresse = Model.GetAdresseComplete(cbNom.SelectedText.ToString());
            lbAdresse.Text = Model.GetAdresse(cbNom.SelectedText.ToString());
            lbVille.Text = Model.GetVille(cbNom.SelectedText.ToString());
            lbCp.Text = Model.GetCodePostale(cbNom.SelectedText.ToString());
            webBrowser1.Navigate("https://www.google.com/maps/place/" + adresse);
        }
    }
}
