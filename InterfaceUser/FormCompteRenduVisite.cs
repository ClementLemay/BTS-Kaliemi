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
    public partial class FormCompteRenduVisite : Form
    {
        int idInfimiere;
        public FormCompteRenduVisite(int idInfirmiere)
        {
            InitializeComponent();
            this.idInfimiere = idInfirmiere;
            idComboBox.DataSource = Model.GetListIdVisite(idInfirmiere);
        }

        private void brRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            try
            {
                int unId = Convert.ToInt32(idComboBox.SelectedValue);
                string stringDateReel = dateTimePicker1.Text + " " + tbHeure.Text + ":" + tbMinute.Text;
                DateTime dateReel = DateTime.Parse(stringDateReel);
                Model.upDateCompteRenduFromInfirmiere(unId, tbCompteRendu.Text, dateReel);
                lbNotif.Visible = true;
                lbNotif.ForeColor = Color.Green;
                lbNotif.Text = "Requete reçu par le serveur";
                dgvVisite.Rows.Clear();
                var LQuery = Model.maConnexion.visite.ToList()
                                .Where(x => x.infirmiere == idInfimiere)
                                .Where(x => x.id == int.Parse(idComboBox.SelectedValue.ToString()))
                                .Select(x => new { x.id, x.patient, x.infirmiere, x.date_prevue, x.date_reelle, x.duree, x.compte_rendu_infirmiere });
                foreach (var v in LQuery)
                {
                    string[] LaVisite = { v.id.ToString(), v.patient.ToString(), v.infirmiere.ToString(), v.date_prevue.ToString(), v.date_reelle.ToString(), v.duree.ToString(), v.compte_rendu_infirmiere };
                    dgvVisite.Rows.Add(LaVisite);
                }

            }
            catch (Exception)
            {
                lbNotif.Visible = true;
                lbNotif.ForeColor = Color.Red;
                lbNotif.Text = "Erreur dans l'écriture d'un des paramétres";
            }
        }

        private void idComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dgvVisite.Rows.Clear();
            var LQuery = Model.maConnexion.visite.ToList()
                            .Where(x => x.infirmiere == idInfimiere)
                            .Where(x => x.id == int.Parse(idComboBox.SelectedValue.ToString()))
                            .Select(x => new { x.id, x.patient, x.infirmiere, x.date_prevue, x.date_reelle, x.duree, x.compte_rendu_infirmiere });
            foreach (var v in LQuery)
            {
                string[] LaVisite = { v.id.ToString(), v.patient.ToString(), v.infirmiere.ToString(), v.date_prevue.ToString(), v.date_reelle.ToString(), v.duree.ToString(), v.compte_rendu_infirmiere };
                dgvVisite.Rows.Add(LaVisite);
                var dateVisite = DateTime.Parse(v.date_prevue.ToString());
                dateTimePicker1.Value = dateVisite;
                tbHeure.Text = dateVisite.Hour.ToString();
                tbMinute.Text = dateVisite.Minute.ToString();
            }
        }

        private void FormCompteRenduVisite_Load_1(object sender, EventArgs e)
        {

            var LQuery = Model.maConnexion.visite.ToList()
                            .Where(x => x.infirmiere == idInfimiere)
                            .Select(x => new { x.id, x.patient, x.infirmiere, x.date_prevue, x.date_reelle, x.duree, x.compte_rendu_infirmiere });
            foreach (var v in LQuery)
            {
                string[] LaVisite = { v.id.ToString(), v.patient.ToString(), v.infirmiere.ToString(), v.date_prevue.ToString(), v.date_reelle.ToString(), v.duree.ToString(), v.compte_rendu_infirmiere };
                dgvVisite.Rows.Add(LaVisite);
            }
        }
    }
}
