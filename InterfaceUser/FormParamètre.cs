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
        int id;
        public FormParamètre(int id, Form uneFormAccueil)
        {
            InitializeComponent();
            
            this.FormAccueil = uneFormAccueil;
            this.id = id;
        }

        private void FormParamètre_Load(object sender, EventArgs e)
        {
            lbId.Text = Model.GetLoginPersonneFromId(id);
            try
            {
                var LQuery = Model.maConnexion.infirmiere.ToList()
                           .Where(x => x.id == this.id)
                           .Select(x => new { x.fichier_photo });
                foreach (var v in LQuery)
                {
                    byte[] byteImage = v.fichier_photo;
                    Image x = (Bitmap)((new ImageConverter()).ConvertFrom(byteImage));
                    pictureBox1.Image = x;
                }
                btAjouterPhoto.Text = "Modifier la photo";
            }
            catch (Exception) { }
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

        private void btAjouterPhoto_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormImage FormImage = new FormImage(id);
            FormImage.ShowDialog();
            this.Close();
        }
    }
}
