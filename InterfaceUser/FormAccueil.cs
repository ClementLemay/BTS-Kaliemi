using System;
using System.Threading;
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
                            .Select(x => new { x.id, x.patient, x.infirmiere, x.date_prevue, x.date_reelle, x.duree, x.compte_rendu_infirmiere });
            foreach (var v in LQuery)
            {
                String NomPrenomPatient = Model.GetNomPersonneFromId(v.patient) + " " + Model.GetPrenomPersonneFromId(v.patient);
                string[] LaVisite = { v.id.ToString(), NomPrenomPatient, v.infirmiere.ToString(), v.date_prevue.ToString(), v.date_reelle.ToString(), v.duree.ToString(), v.compte_rendu_infirmiere };
                dgvVisite.Rows.Add(LaVisite);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            /*
            Thread userThread = new Thread(new ThreadStart(dot));
            userThread.Start();
            */
            pictureBox1.Visible = true;
            dgvVisite.Rows.Clear();
            Model.ImportVisite(Personne.getId());
            var LQuery = Model.maConnexion.visite.ToList()
                            .Where(x => x.infirmiere == Personne.getId())
                            .Select(x => new { x.id, x.patient, x.infirmiere, x.date_prevue, x.date_reelle, x.duree, x.compte_rendu_infirmiere });
            foreach (var v in LQuery)
            {
                String NomPrenomPatient = Model.GetNomPersonneFromId(v.patient) + " " + Model.GetPrenomPersonneFromId(v.patient);
                string[] LaVisite = { v.id.ToString(), NomPrenomPatient, v.infirmiere.ToString(), v.date_prevue.ToString(), v.date_reelle.ToString(), v.duree.ToString(), v.compte_rendu_infirmiere };
                dgvVisite.Rows.Add(LaVisite);
            }
            /*userThread.Abort();
             */
            pictureBox1.Visible = false;
        }
        /*
        private  void doSomeWork()
        {
            if (pictureBox1.InvokeRequired)
            {
                var d = new SafeCallDelegate(doSomeWork);
                Invoke(d);
            }
            else
            {
                pictureBox1.Visible = true;
            }
           
        }
        private void dot()
        {
            doSomeWork();
        }
        */
        private void button2_Click(object sender, EventArgs e)
        {
            FormAjoutSoinVisite FormAjoutSoinVisite = new FormAjoutSoinVisite(Personne.getId());
            FormAjoutSoinVisite.Show();
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
            FormParamètre.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCompteRenduVisite FormCompteRenduVisite = new FormCompteRenduVisite(Personne.getId());
            FormCompteRenduVisite.Show();
        }

        private void btExporter_Click(object sender, EventArgs e)
        {
            FormExporter FormExporter = new FormExporter(dgvVisite, idInfirmiere);
            FormExporter.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dgvVisite.Rows.Clear();
            var LQuery = Model.maConnexion.visite.ToList()
                            .Where(x => x.infirmiere == Personne.getId())
                            .Select(x => new { x.id, x.patient, x.infirmiere, x.date_prevue, x.date_reelle, x.duree, x.compte_rendu_infirmiere });
            foreach (var v in LQuery)
            {
                String NomPrenomPatient = Model.GetNomPersonneFromId(v.patient) + " " + Model.GetPrenomPersonneFromId(v.patient);
                string[] LaVisite = { v.id.ToString(), NomPrenomPatient, v.infirmiere.ToString(), v.date_prevue.ToString(), v.date_reelle.ToString(), v.duree.ToString(), v.compte_rendu_infirmiere };
                dgvVisite.Rows.Add(LaVisite);
            }
        }
    }
}
