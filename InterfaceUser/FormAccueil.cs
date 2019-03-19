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
        private delegate void SafeCallDelegate();
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

        private void btDeconnexion_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormConnexion FormConnexion = new FormConnexion();
            FormConnexion.ShowDialog();
            this.Close();
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
            /*
            Thread userThread = new Thread(new ThreadStart(dot));
            userThread.Start();
            */
            pictureBox1.Visible = true;
            dgvVisite.Rows.Clear();
            Model.ImportVisite(this.Id);
            var LQuery = Model.maConnexion.visite.ToList()
                            .Where(x => x.infirmiere == this.Id)
                            .Select(x => new { x.id, x.patient, x.infirmiere, x.date_prevue, x.date_reelle, x.duree, x.compte_rendu_infirmiere });
            foreach (var v in LQuery)
            {
                string[] LaVisite = { v.id.ToString(), v.patient.ToString(), v.infirmiere.ToString(), v.date_prevue.ToString(), v.date_reelle.ToString(), v.duree.ToString(), v.compte_rendu_infirmiere };
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
            FormAjoutSoinVisite FormAjoutSoinVisite = new FormAjoutSoinVisite(this.Id);
            FormAjoutSoinVisite.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormCarte FormCarte = new FormCarte();
            FormCarte.Show();
        }
    }
}
