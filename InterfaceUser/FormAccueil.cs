using System;
using System.Threading;
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
    public partial class FormAccueil : Form
    {
        //private delegate void SafeCallDelegate();

        ClassPersonne Personne;
        int idInfirmiere;
        Form FormConnexion = new FormConnexion();

        public FormAccueil(int unId)
        {
            InitializeComponent();
            this.Personne = new ClassPersonne(unId);
            this.idInfirmiere = unId;
        }

        

        private void FormAccueil_Load(object sender, EventArgs e)
        {
            lbBienvenue1.Text = "Bienvenue " +  Personne.getNom()+ " " + Personne.getPrenom();

            var LQuery = Model.maConnexion.visite.ToList()
                            .Where(x => x.infirmiere == Personne.getId())
                            .Select(x => new { x.id, x.patient, x.date_prevue, x.date_reelle, x.duree, x.compte_rendu_infirmiere });
            foreach (var v in LQuery)
            {
                String NomPrenomPatient = Model.GetNomPersonneFromId(v.patient) + " " + Model.GetPrenomPersonneFromId(v.patient);
                string[] LaVisite = { v.id.ToString(), NomPrenomPatient, v.date_prevue.ToString(), v.date_reelle.ToString(), v.duree.ToString(), v.compte_rendu_infirmiere };
                dgvVisite.Rows.Add(LaVisite);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            if (Model.isConnected()== true)
            {
                dgvVisite.Rows.Clear();
                Model.ImportVisite(Personne.getId());
                var LQuery = Model.maConnexion.visite.ToList()
                                .Where(x => x.infirmiere == Personne.getId())
                                .Select(x => new { x.id, x.patient, x.date_prevue, x.date_reelle, x.duree, x.compte_rendu_infirmiere });
                foreach (var v in LQuery)
                {
                    String NomPrenomPatient = Model.GetNomPersonneFromId(v.patient) + " " + Model.GetPrenomPersonneFromId(v.patient);
                    string[] LaVisite = { v.id.ToString(), NomPrenomPatient, v.date_prevue.ToString(), v.date_reelle.ToString(), v.duree.ToString(), v.compte_rendu_infirmiere };
                    dgvVisite.Rows.Add(LaVisite);
                }
            }
            else
            {
                Form404 Form404 = new Form404();
                Form404.Show();
            }
            pictureBox1.Visible = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvVisite.RowCount > 1)
            {
                FormAjoutSoinVisite FormAjoutSoinVisite = new FormAjoutSoinVisite(Personne.getId());
                FormAjoutSoinVisite.Show();
            }
            else
            {
                Model.Shake_Form(this);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormCarte FormCarte = new FormCarte(this.idInfirmiere);
            FormCarte.Show();
        }
        private void btDeconnexion_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormConnexion FormConnexion = new FormConnexion();
            FormConnexion.ShowDialog();
            this.Close();
        }
        private void btParam_Click(object sender, EventArgs e)
        {
            Form FormParamètre = new FormParamètre(Personne.getId(), this);
            FormParamètre.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvVisite.RowCount > 0)
            {
                FormCompteRenduVisite FormCompteRenduVisite = new FormCompteRenduVisite(Personne.getId(),dgvVisite, Personne);
                FormCompteRenduVisite.Show();
            }
            else
            {
                Model.Shake_Form(this);
            }

        }

        private void btExporter_Click(object sender, EventArgs e)
        {
            if (dgvVisite.RowCount > 0)
            {
                if (Model.isConnected() == true)
                {
                    FormExporter FormExporter = new FormExporter(dgvVisite, idInfirmiere);
                    FormExporter.Show();
                }
                else
                {
                    Form404 Form404 = new Form404();
                    Form404.Show();
                }
            }
            else
            {
                Model.Shake_Form(this);
            }
        }

        private void btParam_Enter(object sender, EventArgs e)
        {
            btParam.ForeColor = Color.White;
        }

        private void btParam_Leave(object sender, EventArgs e)
        {
            btParam.ForeColor = Color.Black;
        }

        private void btDeconnexion_MouseEnter(object sender, EventArgs e)
        {
            btDeconnexion.ForeColor = Color.White;
        }

        private void btDeconnexion_MouseLeave(object sender, EventArgs e)
        {
            btDeconnexion.ForeColor = Color.Black;
        }
    }
}