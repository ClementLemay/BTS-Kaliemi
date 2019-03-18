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
            this.id = id;
            InitializeComponent();
            cbSoins.DataSource = Model.GetListLibelleSoins();
            cbIdVisite.DataSource = Model.GetListIdVisite(this.id);
            cbRealise.DataSource = new List<string>() { "0", "1" };
            cbPrevu.DataSource = new List<string>() { "0", "1" };
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            if (cbIdVisite.Items.Count != 0)
            {
                int idVisite = int.Parse(cbIdVisite.SelectedItem.ToString());
                int etatPrevu = int.Parse(cbPrevu.SelectedItem.ToString());
                int etatRealise = int.Parse(cbRealise.SelectedItem.ToString());
                if (etatPrevu == 0)
                {
                    MessageBox.Show("Un soin imprévu ne peut être non réalisé, par conséquent, réalisé a été définie à 1");
                    etatRealise = 1;
                }

                string labelleSoins = cbSoins.SelectedItem.ToString();

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
