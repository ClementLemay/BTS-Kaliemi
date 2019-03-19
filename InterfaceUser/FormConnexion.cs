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
            if (tbId.TextLength >= 3 && tbMdp1.TextLength >= 3)
            {
                if (Model.connexionLocal(tbId.Text, tbMdp1.Text) != true)
                {
                    if (Model.existLogin(tbId.Text) != true && Model.connexionWebService(tbId.Text, tbMdp1.Text) )
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
                        FormErreur erreur = new FormErreur(this);
                        erreur.Show();
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
            else
            {
                FormErreur erreur = new FormErreur(this);
                erreur.Show();
            }


        }
        private void personne_loginBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
        }

        private void FormConnexion_Load(object sender, EventArgs e)
        {
        }
    }
}
