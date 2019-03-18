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
    public partial class FormParamètre : Form
    {
        Form FormAccueil = new Form();
        public FormParamètre(int id, Form uneFormAccueil)
        {
            InitializeComponent();
            lbId.Text = Model.GetLoginPersonneFromId(id);
            this.FormAccueil = uneFormAccueil;
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            if (tbNouMdp.Text == tbConfMdp.Text && Model.compareMdp(lbId.Text, tbAncMdp.Text) /*&& tbNouMdp.TextLength>4*/)
            {
                Model.changeMp(lbId.Text, tbNouMdp.Text);
                label5.Text = "Mot de passe modifié, vous allez être déconnecté";
                label5.ForeColor = Color.Green;
                label5.Visible = true;
                DateTime Tthen = DateTime.Now;
                do
                {
                    Application.DoEvents();
                } while (Tthen.AddSeconds(3) > DateTime.Now);
                this.Hide();
                FormAccueil.Hide();
                FormConnexion FormConnexion = new FormConnexion();
                FormConnexion.ShowDialog();
                FormAccueil.Close();
                this.Close();
            }
            else
            {
                label5.Text = "Un ou plusieurs champ(s) n'est pas identique ou pas suffisament long";
                label5.ForeColor = Color.Red;
                label5.Visible = true;
            }

        }
    }
}
