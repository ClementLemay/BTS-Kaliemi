using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceUser
{
    public partial class FormImage : Form
    {
        string path;
        int id;
        bool isChanged;

        public FormImage(int id)
        {
            InitializeComponent();
            this.id = id;
            this.isChanged = false;
        }

        private void FormImage_Load(object sender, EventArgs e)
        {
            pictureBox1.AllowDrop = true;
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop,false))
            {
                e.Effect = DragDropEffects.All;
                this.isChanged = true;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
                
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] droppedfiles = (string[])e.Data.GetData(DataFormats.FileDrop);
            try
            {
                foreach (string file in droppedfiles)
                {
                    string filename = getFileName(file);
                    label2.ForeColor = Color.Black;
                    label2.Text = filename.ToUpper();
                    label1.Visible = false;

                    pictureBox1.Image = Image.FromFile(file);
                    pictureBox1.BackColor = Color.White;
                }
            }
            catch (Exception)
            {
                pictureBox1.Image = null;
                label2.ForeColor = Color.Red;
                label2.Text = "Ce fichier n'est pas dans un format compatible";
            }
        }

        private string getFileName(string path)
        {
            this.path = path;
            return Path.GetFileNameWithoutExtension(path);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            
                if (e.Button == MouseButtons.Left)
            {
                pictureBox1.DoDragDrop(pictureBox1.Image, DragDropEffects.All);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                ImageConverter converter = new ImageConverter();
                byte[] Image =  (byte[])converter.ConvertTo(pictureBox1.Image, typeof(byte[]));
                if(isChanged)
                {
                    var dep = Model.maConnexion.infirmiere.Where(d => d.id == this.id).First();
                    dep.fichier_photo = Image;
                    Model.maConnexion.SaveChanges();

                    label2.ForeColor = Color.Green;
                    label2.Text = "Image modifiée";

                    DateTime Tthen = DateTime.Now;
                    do
                    {
                        Application.DoEvents();
                    } while (Tthen.AddSeconds(1.5) > DateTime.Now);
                    this.Close();
                }
                else
                {
                    label2.ForeColor = Color.Red;
                    label2.Text = "Veuillez selectionner une image";
                }
            }
            catch
            {
                
            }
            
        }
    }
}
