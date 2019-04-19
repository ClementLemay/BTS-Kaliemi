namespace InterfaceUser
{
    partial class FormAccueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccueil));
            this.dgvVisite = new System.Windows.Forms.DataGridView();
            this.IdVisite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_prevue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_reelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compte_rendu_infirmiere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbBienvenue1 = new System.Windows.Forms.Label();
            this.btParam = new System.Windows.Forms.Button();
            this.btDeconnexion = new System.Windows.Forms.Button();
            this.btAjouterCR = new System.Windows.Forms.Button();
            this.btLocalisation = new System.Windows.Forms.Button();
            this.btExporter = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btAjouterSV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisite)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVisite
            // 
            this.dgvVisite.AllowUserToAddRows = false;
            this.dgvVisite.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVisite.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvVisite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvVisite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisite.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdVisite,
            this.Patient,
            this.date_prevue,
            this.date_reelle,
            this.duree,
            this.compte_rendu_infirmiere});
            this.dgvVisite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVisite.Location = new System.Drawing.Point(0, 0);
            this.dgvVisite.Name = "dgvVisite";
            this.dgvVisite.ReadOnly = true;
            this.dgvVisite.RowHeadersVisible = false;
            this.dgvVisite.ShowCellErrors = false;
            this.dgvVisite.ShowCellToolTips = false;
            this.dgvVisite.ShowEditingIcon = false;
            this.dgvVisite.ShowRowErrors = false;
            this.dgvVisite.Size = new System.Drawing.Size(647, 334);
            this.dgvVisite.TabIndex = 0;
            // 
            // IdVisite
            // 
            this.IdVisite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.IdVisite.HeaderText = "IdVisite";
            this.IdVisite.Name = "IdVisite";
            this.IdVisite.ReadOnly = true;
            this.IdVisite.Width = 66;
            // 
            // Patient
            // 
            this.Patient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Patient.HeaderText = "Patient";
            this.Patient.Name = "Patient";
            this.Patient.ReadOnly = true;
            this.Patient.Width = 65;
            // 
            // date_prevue
            // 
            this.date_prevue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.date_prevue.HeaderText = "date_prevue";
            this.date_prevue.Name = "date_prevue";
            this.date_prevue.ReadOnly = true;
            this.date_prevue.Width = 92;
            // 
            // date_reelle
            // 
            this.date_reelle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.date_reelle.HeaderText = "date_reelle";
            this.date_reelle.Name = "date_reelle";
            this.date_reelle.ReadOnly = true;
            this.date_reelle.Width = 84;
            // 
            // duree
            // 
            this.duree.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.duree.HeaderText = "duree";
            this.duree.Name = "duree";
            this.duree.ReadOnly = true;
            this.duree.Width = 59;
            // 
            // compte_rendu_infirmiere
            // 
            this.compte_rendu_infirmiere.HeaderText = "compte_rendu_infirmiere";
            this.compte_rendu_infirmiere.Name = "compte_rendu_infirmiere";
            this.compte_rendu_infirmiere.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.dgvVisite);
            this.panel2.Location = new System.Drawing.Point(172, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(647, 334);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(643, 330);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.lbBienvenue1);
            this.panel3.Controls.Add(this.btParam);
            this.panel3.Controls.Add(this.btDeconnexion);
            this.panel3.Location = new System.Drawing.Point(0, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(819, 55);
            this.panel3.TabIndex = 2;
            // 
            // lbBienvenue1
            // 
            this.lbBienvenue1.AutoSize = true;
            this.lbBienvenue1.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBienvenue1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbBienvenue1.Location = new System.Drawing.Point(25, 18);
            this.lbBienvenue1.Name = "lbBienvenue1";
            this.lbBienvenue1.Size = new System.Drawing.Size(85, 27);
            this.lbBienvenue1.TabIndex = 5;
            this.lbBienvenue1.Text = "label1";
            // 
            // btParam
            // 
            this.btParam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btParam.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btParam.FlatAppearance.BorderSize = 0;
            this.btParam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btParam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btParam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btParam.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btParam.Location = new System.Drawing.Point(574, 18);
            this.btParam.Name = "btParam";
            this.btParam.Size = new System.Drawing.Size(115, 35);
            this.btParam.TabIndex = 4;
            this.btParam.Text = "Paramètre";
            this.btParam.UseVisualStyleBackColor = true;
            this.btParam.Click += new System.EventHandler(this.btParam_Click);
            this.btParam.MouseEnter += new System.EventHandler(this.btParam_Enter);
            this.btParam.MouseLeave += new System.EventHandler(this.btParam_Leave);
            // 
            // btDeconnexion
            // 
            this.btDeconnexion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDeconnexion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btDeconnexion.FlatAppearance.BorderSize = 0;
            this.btDeconnexion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btDeconnexion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btDeconnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeconnexion.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeconnexion.Location = new System.Drawing.Point(690, 18);
            this.btDeconnexion.Name = "btDeconnexion";
            this.btDeconnexion.Size = new System.Drawing.Size(125, 35);
            this.btDeconnexion.TabIndex = 3;
            this.btDeconnexion.Text = "Déconnexion";
            this.btDeconnexion.UseVisualStyleBackColor = true;
            this.btDeconnexion.Click += new System.EventHandler(this.btDeconnexion_Click);
            this.btDeconnexion.MouseEnter += new System.EventHandler(this.btDeconnexion_MouseEnter);
            this.btDeconnexion.MouseLeave += new System.EventHandler(this.btDeconnexion_MouseLeave);
            // 
            // btAjouterCR
            // 
            this.btAjouterCR.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btAjouterCR.FlatAppearance.BorderSize = 0;
            this.btAjouterCR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btAjouterCR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btAjouterCR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAjouterCR.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAjouterCR.Location = new System.Drawing.Point(-5, 53);
            this.btAjouterCR.Name = "btAjouterCR";
            this.btAjouterCR.Size = new System.Drawing.Size(182, 51);
            this.btAjouterCR.TabIndex = 5;
            this.btAjouterCR.Text = "Ajouter un compte rendu";
            this.btAjouterCR.UseVisualStyleBackColor = true;
            this.btAjouterCR.Click += new System.EventHandler(this.button1_Click);
            // 
            // btLocalisation
            // 
            this.btLocalisation.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btLocalisation.FlatAppearance.BorderSize = 0;
            this.btLocalisation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btLocalisation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btLocalisation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLocalisation.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLocalisation.Location = new System.Drawing.Point(-5, 148);
            this.btLocalisation.Name = "btLocalisation";
            this.btLocalisation.Size = new System.Drawing.Size(182, 45);
            this.btLocalisation.TabIndex = 6;
            this.btLocalisation.Text = "Localisation patient";
            this.btLocalisation.UseVisualStyleBackColor = true;
            this.btLocalisation.Click += new System.EventHandler(this.button3_Click);
            // 
            // btExporter
            // 
            this.btExporter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btExporter.FlatAppearance.BorderSize = 0;
            this.btExporter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btExporter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btExporter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExporter.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExporter.Image = ((System.Drawing.Image)(resources.GetObject("btExporter.Image")));
            this.btExporter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExporter.Location = new System.Drawing.Point(-5, 321);
            this.btExporter.Name = "btExporter";
            this.btExporter.Size = new System.Drawing.Size(182, 41);
            this.btExporter.TabIndex = 8;
            this.btExporter.Text = "Exporter";
            this.btExporter.UseVisualStyleBackColor = true;
            this.btExporter.Click += new System.EventHandler(this.btExporter_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(-2, 280);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(177, 40);
            this.button6.TabIndex = 7;
            this.button6.Text = "Importer";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.UseWaitCursor = true;
            this.button6.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btAjouterSV
            // 
            this.btAjouterSV.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btAjouterSV.FlatAppearance.BorderSize = 0;
            this.btAjouterSV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btAjouterSV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btAjouterSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAjouterSV.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAjouterSV.Location = new System.Drawing.Point(-5, 102);
            this.btAjouterSV.Name = "btAjouterSV";
            this.btAjouterSV.Size = new System.Drawing.Size(182, 45);
            this.btAjouterSV.TabIndex = 9;
            this.btAjouterSV.Text = "Ajouter un SoinsVisite";
            this.btAjouterSV.UseVisualStyleBackColor = true;
            this.btAjouterSV.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormAccueil
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(815, 383);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btAjouterSV);
            this.Controls.Add(this.btExporter);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btLocalisation);
            this.Controls.Add(this.btAjouterCR);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.FormAccueil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisite)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lbBienvenue;
        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.Button btAjVisite;
        private System.Windows.Forms.Button btDeco;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btParamètre;
        private System.Windows.Forms.BindingSource soinsvisitesoinsvisiteibfk1BindingSource;
        private System.Windows.Forms.BindingSource personne_loginBindingSource;
        private System.Windows.Forms.DataGridView personne_loginDataGridView;
        private System.Windows.Forms.Button btCompteRendu;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn derniereconnexionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbtentativeerreurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvVisite;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btParam;
        private System.Windows.Forms.Button btDeconnexion;
        private System.Windows.Forms.Button btAjouterCR;
        private System.Windows.Forms.Button btLocalisation;
        private System.Windows.Forms.Button btExporter;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label lbBienvenue1;
        private System.Windows.Forms.Button btAjouterSV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVisite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patient;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_prevue;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_reelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn duree;
        private System.Windows.Forms.DataGridViewTextBoxColumn compte_rendu_infirmiere;
    }
}