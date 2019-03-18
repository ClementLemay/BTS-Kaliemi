using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceUser
{
    public partial class FormAccueil : Form
    {
        Form FormConnexion = new FormConnexion();
        string NomPrenom;
        int Id;
        public FormAccueil(Form FormConnexion, string NomPrenom, int unId)
        {
            InitializeComponent();
            this.Id = unId;
            this.NomPrenom = NomPrenom;
            lbBienvenue1.Text = "Bienvenue " + NomPrenom;
            var LQuery = Model.maConnexion.visite.ToList()
                            .Where(x => x.infirmiere == this.Id)
                            .Select(x => new { x.id, x.patient, x.infirmiere, x.date_prevue, x.date_reelle, x.duree, x.compte_rendu_infirmiere });
            foreach (var v in LQuery)
            {
                string[] LaVisite = { v.id.ToString(), v.patient.ToString(), v.infirmiere.ToString(), v.date_prevue.ToString(), v.date_reelle.ToString(), v.duree.ToString(), v.compte_rendu_infirmiere };
                dgvVisite.Rows.Add(LaVisite);
            }
        }

        private void lbBienvenue_Click(object sender, EventArgs e)
        {

        }

        private void btDeconnexion_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormConnexion FormConnexion = new FormConnexion();
            FormConnexion.ShowDialog();
            this.Close();
        }

        private void soins_visiteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void soinsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

        }

        private void FormAccueil_Load(object sender, EventArgs e)
        {
            var LQuery = Model.maConnexion.visite.ToList()
                            .Where(x => x.infirmiere == Id)
                            .Select(x => new { x.id, x.patient, x.infirmiere, x.date_prevue, x.date_reelle, x.duree, x.compte_rendu_infirmiere });
            foreach (var v in LQuery)
            {
                string[] LaVisite = { v.id.ToString(), v.patient.ToString(), v.infirmiere.ToString(), v.date_prevue.ToString(), v.date_reelle.ToString(), v.duree.ToString(), v.compte_rendu_infirmiere };
                dgvVisite.Rows.Add(LaVisite);
            }
        }

        private void btParam_Click(object sender, EventArgs e)
        {
            Form FormParamètre = new FormParamètre(this.Id, this);
            FormParamètre.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCompteRenduVisite FormCompteRenduVisite = new FormCompteRenduVisite(this.Id);
            FormCompteRenduVisite.Show();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            Model.ImportVisite(this.Id);
            dgvVisite.Rows.Clear();
            var LQuery = Model.maConnexion.visite.ToList()
                            .Where(x => x.infirmiere == this.Id)
                            .Select(x => new { x.id, x.patient, x.infirmiere, x.date_prevue, x.date_reelle, x.duree, x.compte_rendu_infirmiere });
            foreach (var v in LQuery)
            {
                string[] LaVisite = { v.id.ToString(), v.patient.ToString(), v.infirmiere.ToString(), v.date_prevue.ToString(), v.date_reelle.ToString(), v.duree.ToString(), v.compte_rendu_infirmiere };
                dgvVisite.Rows.Add(LaVisite);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAjoutSoinVisite FormAjoutSoinVisite = new FormAjoutSoinVisite(this.Id);
            FormAjoutSoinVisite.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormCarte FormCarte = new FormCarte();
            FormCarte.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
