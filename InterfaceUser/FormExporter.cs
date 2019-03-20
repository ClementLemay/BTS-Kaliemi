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
    public partial class FormExporter : Form
    {
        DataGridView dgvVisite;
        int idInfirmiere;
        public FormExporter(DataGridView dgvVisite, int idInfirmiere)
        {
            InitializeComponent();
            this.dgvVisite = dgvVisite;
            this.idInfirmiere = idInfirmiere;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool requetteAnnulé = false;
            if (cbVisite.Checked == false && cbParam.Checked == false)
            {
                lbNotif.ForeColor = Color.Orange;
                lbNotif.Text = "Veuillez séléctionner au moins une option";
            }
            else
            {
                if (cbVisite.Checked)
                {
                    if (Model.deleteDataVisite(this.idInfirmiere) == false)
                    {
                        requetteAnnulé = true;
                    }
                    else { dgvVisite.Rows.Clear(); }
                }

                if (cbParam.Checked)
                {
                    if (Model.sendDataInfirmiere(this.idInfirmiere) == false)
                    {
                        requetteAnnulé = true;
                    }
                }

                if (requetteAnnulé == true)
                {
                    lbNotif.ForeColor = Color.Red;
                    lbNotif.Text = "Echec de l'envoi des données";
                }
                else
                {
                    lbNotif.ForeColor = Color.Green;
                    lbNotif.Text = "Données envoyé au serveur";
                }
            }
        }
    }
}
