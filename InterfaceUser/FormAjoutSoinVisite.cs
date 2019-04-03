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
    public partial class FormAjoutSoinVisite : Form
    {
        int id;
        public FormAjoutSoinVisite(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void FormAjoutSoinVisite_Load(object sender, EventArgs e)
        {

            cbSoins.DataSource = Model.GetListLibelleSoins();
            cbIdVisite.DataSource = Model.GetListIdVisite(this.id);
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            if (cbIdVisite.Items.Count != 0)
            {
                int etatRealise = 0;
                int etatPrevu = 0;
                if (cbPrévu.Checked)
                {
                    etatPrevu = 1;
                }
                if (cbPrévu.Checked)
                {
                    etatRealise = 1;
                }
                int idVisite = int.Parse(cbIdVisite.SelectedItem.ToString());                
                string labelleSoins = cbSoins.SelectedItem.ToString();
                if (etatPrevu == 0)
                {
                    label5.ForeColor = Color.Orange;
                    label5.Text = "Un soins non-prévu ne peut être non-réaliser, par conséquent il a été modifier à 1";
                    cbPrévu.Checked = true;
                    DateTime Tthen = DateTime.Now;
                    do
                    {
                        Application.DoEvents();
                    } while (Tthen.AddSeconds(4) > DateTime.Now);
                    etatRealise = 1;
                }

                if (Model.addSoinsVisite(idVisite, etatPrevu, etatRealise, labelleSoins))
                {
                    label5.Text = "Ajout prit en compte par la base de données";
                    label5.ForeColor = Color.Green;
                    label5.Visible = true;
                    dgvVisite.Rows.Clear();
                    var LQuery1 = Model.maConnexion.soins_visite.ToList()
                                    .Where(x => x.visite == int.Parse(cbIdVisite.SelectedItem.ToString()))
                                    .Select(x => new { x.visite, x.id_categ_soins, x.id_type_soins, x.id_soins, x.prevu, x.realise });
                    foreach (var v in LQuery1)
                    {
                        var LQuery2 = Model.maConnexion.soins.ToList()
                                    .Where(x => x.id_categ_soins == v.id_categ_soins)
                                    .Where(x => x.id_type_soins == v.id_type_soins)
                                    .Where(x => x.id == v.id_soins)
                                    .Select(x => new { x.libel });
                        foreach (var x in LQuery2)
                        {
                            string[] LaVisite = { v.visite.ToString(), x.libel.ToString(), v.id_categ_soins.ToString(), v.id_type_soins.ToString(), v.id_soins.ToString(), v.prevu.ToString(), v.realise.ToString() };
                            dgvVisite.Rows.Add(LaVisite);
                        }
                    }
                }
                else
                {
                    label5.Text = "Erreur, ce soin est déjà existant dans la base de données";
                    label5.ForeColor = Color.Red;
                    label5.Visible = true;
                }
            }
            else
            {
                label5.Text = "Vous n'avez aucune visite";
                label5.ForeColor = Color.Red;
                label5.Visible = true;
            }
        }

        private void cbIdVisite_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvVisite.Rows.Clear();
            var LQuery1 = Model.maConnexion.soins_visite.ToList()
                                    .Where(x => x.visite == int.Parse(cbIdVisite.SelectedItem.ToString()))
                                    .Select(x => new { x.visite, x.id_categ_soins, x.id_type_soins, x.id_soins, x.prevu, x.realise });
            foreach (var v in LQuery1)
            {
                var LQuery2 = Model.maConnexion.soins.ToList()
                            .Where(x => x.id_categ_soins == v.id_categ_soins)
                            .Where(x => x.id_type_soins == v.id_type_soins)
                            .Where(x => x.id == v.id_soins)
                            .Select(x => new { x.libel });
                foreach (var x in LQuery2)
                {
                    string[] LaVisite = { v.visite.ToString(), x.libel.ToString(), v.id_categ_soins.ToString(), v.id_type_soins.ToString(), v.id_soins.ToString(), v.prevu.ToString(), v.realise.ToString() };
                    dgvVisite.Rows.Add(LaVisite);
                }
            }
        }
    }
}
