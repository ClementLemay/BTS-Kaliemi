namespace InterfaceUser
{
    partial class FormCarte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.cbNom = new System.Windows.Forms.ComboBox();
            this.lbAdresse = new System.Windows.Forms.Label();
            this.lbVille = new System.Windows.Forms.Label();
            this.lbCp = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.webBrowser1);
            this.panel1.Location = new System.Drawing.Point(186, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 455);
            this.panel1.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(619, 455);
            this.webBrowser1.TabIndex = 0;
            // 
            // cbNom
            // 
            this.cbNom.FormattingEnabled = true;
            this.cbNom.Location = new System.Drawing.Point(46, 39);
            this.cbNom.Name = "cbNom";
            this.cbNom.Size = new System.Drawing.Size(121, 21);
            this.cbNom.TabIndex = 1;
            // 
            // lbAdresse
            // 
            this.lbAdresse.AutoSize = true;
            this.lbAdresse.Location = new System.Drawing.Point(43, 124);
            this.lbAdresse.Name = "lbAdresse";
            this.lbAdresse.Size = new System.Drawing.Size(35, 13);
            this.lbAdresse.TabIndex = 2;
            this.lbAdresse.Text = "label1";
            // 
            // lbVille
            // 
            this.lbVille.AutoSize = true;
            this.lbVille.Location = new System.Drawing.Point(43, 152);
            this.lbVille.Name = "lbVille";
            this.lbVille.Size = new System.Drawing.Size(35, 13);
            this.lbVille.TabIndex = 3;
            this.lbVille.Text = "label1";
            // 
            // lbCp
            // 
            this.lbCp.AutoSize = true;
            this.lbCp.Location = new System.Drawing.Point(43, 180);
            this.lbCp.Name = "lbCp";
            this.lbCp.Size = new System.Drawing.Size(35, 13);
            this.lbCp.TabIndex = 4;
            this.lbCp.Text = "label2";
            // 
            // FormCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbCp);
            this.Controls.Add(this.lbVille);
            this.Controls.Add(this.lbAdresse);
            this.Controls.Add(this.cbNom);
            this.Controls.Add(this.panel1);
            this.Name = "FormCarte";
            this.Text = "FormCarte";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ComboBox cbNom;
        private System.Windows.Forms.Label lbAdresse;
        private System.Windows.Forms.Label lbVille;
        private System.Windows.Forms.Label lbCp;
    }
}