using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq;

namespace InterfaceUser
{
    public partial class FormConnexion : Form
    {
        public FormConnexion()
        {
            InitializeComponent();
        }

        private void btVal_Click(object sender, EventArgs e)
        {
            if (Model.connexionLocal(tbId.Text, tbMdp1.Text) != true)
            {
                if (Model.isConnected())
                {
                    if (Model.existLogin(tbId.Text) != true && Model.connexionWebService(tbId.Text, tbMdp1.Text))
                    {
                        Model.upDateConnexion(tbId.Text);
                        this.Hide();
                        FormAccueil accueil = new FormAccueil(Model.GetIdPersonneFromLogin(tbId.Text));
                        accueil.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        if (Model.existLogin(tbId.Text))
                        {
                            Model.nbErrorConnxionAdd(tbId.Text);
                        }
                        lbError.Visible = true;
                        lbError.Text = "Un ou plusieurs paramètre(s) est/sont incorrect(s)";
                        Model.Shake_Form(this);
                    }
                }
                else
                {
                    lbError.Visible = true;
                    lbError.Text = "Vous devez vous connecter à internet";
                    Model.Shake_Form(this);
                }
            }
            else
            {
                Model.upDateConnexion(tbId.Text);
                this.Hide();
                FormAccueil accueil = new FormAccueil(Model.GetIdPersonneFromLogin(tbId.Text));
                accueil.ShowDialog();
                this.Close();
            }
            
        }

        private void tbId_Enter(object sender, EventArgs e)
        {
            if(tbId.Text == "Utilisateur")
            {
                tbId.Clear();
                idLogo.Image = InterfaceUser.Properties.Resources.icons8_customer_321;
            }
            lbError.Visible = false;
        }

        private void tbMdp1_Enter(object sender, EventArgs e)
        {
            if(tbMdp1.Text =="Mot de passe")
            {
                tbMdp1.Clear();
                tbMdp1.PasswordChar = '•';
                MdpLogo.Image = InterfaceUser.Properties.Resources.icons8_password_321;
            }
            lbError.Visible = false;
        }

        private void tbId_Leave(object sender, EventArgs e)
        {
            if(tbId.TextLength == 0)
            {
                tbId.Text = "Utilisateur";
                idLogo.Image = InterfaceUser.Properties.Resources.icons8_customer_32;
            }
        }

        private void tbMdp1_Leave(object sender, EventArgs e)
        {
            if (tbMdp1.TextLength == 0)
            {
                tbMdp1.Text = "Mot de passe";
                MdpLogo.Image = InterfaceUser.Properties.Resources.icons8_password_32;
                tbMdp1.PasswordChar = '\0';
            }
        }

        private void tbMdp1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btVal_Click(sender, e);
            }
        }
    }
}
