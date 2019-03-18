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
            this.dgvVisite = new System.Windows.Forms.DataGridView();
            this.IdVisite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdInfirmiere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_prevue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_reelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compte_rendu_infirmiere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbBienvenue1 = new System.Windows.Forms.Label();
            this.btParam = new System.Windows.Forms.Button();
            this.btDeconnexion = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisite)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVisite
            // 
            this.dgvVisite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisite.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdVisite,
            this.IdPatient,
            this.IdInfirmiere,
            this.date_prevue,
            this.date_reelle,
            this.duree,
            this.compte_rendu_infirmiere});
            this.dgvVisite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVisite.Location = new System.Drawing.Point(0, 0);
            this.dgvVisite.Name = "dgvVisite";
            this.dgvVisite.Size = new System.Drawing.Size(678, 334);
            this.dgvVisite.TabIndex = 0;
            // 
            // IdVisite
            // 
            this.IdVisite.HeaderText = "IdVisite";
            this.IdVisite.Name = "IdVisite";
            // 
            // IdPatient
            // 
            this.IdPatient.HeaderText = "IdPatient";
            this.IdPatient.Name = "IdPatient";
            // 
            // IdInfirmiere
            // 
            this.IdInfirmiere.HeaderText = "IdInfirmiere";
            this.IdInfirmiere.Name = "IdInfirmiere";
            // 
            // date_prevue
            // 
            this.date_prevue.HeaderText = "date_prevue";
            this.date_prevue.Name = "date_prevue";
            // 
            // date_reelle
            // 
            this.date_reelle.HeaderText = "date_reelle";
            this.date_reelle.Name = "date_reelle";
            // 
            // duree
            // 
            this.duree.HeaderText = "duree";
            this.duree.Name = "duree";
            // 
            // compte_rendu_infirmiere
            // 
            this.compte_rendu_infirmiere.HeaderText = "compte_rendu_infirmiere";
            this.compte_rendu_infirmiere.Name = "compte_rendu_infirmiere";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgvVisite);
            this.panel2.Location = new System.Drawing.Point(172, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(678, 334);
            this.panel2.TabIndex = 1;
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
            this.panel3.Size = new System.Drawing.Size(850, 55);
            this.panel3.TabIndex = 2;
            // 
            // lbBienvenue1
            // 
            this.lbBienvenue1.AutoSize = true;
            this.lbBienvenue1.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBienvenue1.Location = new System.Drawing.Point(25, 18);
            this.lbBienvenue1.Name = "lbBienvenue1";
            this.lbBienvenue1.Size = new System.Drawing.Size(67, 25);
            this.lbBienvenue1.TabIndex = 5;
            this.lbBienvenue1.Text = "label1";
            // 
            // btParam
            // 
            this.btParam.FlatAppearance.BorderSize = 0;
            this.btParam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btParam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btParam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btParam.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btParam.Location = new System.Drawing.Point(588, 21);
            this.btParam.Name = "btParam";
            this.btParam.Size = new System.Drawing.Size(115, 33);
            this.btParam.TabIndex = 4;
            this.btParam.Text = "Paramètre";
            this.btParam.UseVisualStyleBackColor = true;
            this.btParam.Click += new System.EventHandler(this.btParam_Click);
            // 
            // btDeconnexion
            // 
            this.btDeconnexion.FlatAppearance.BorderSize = 0;
            this.btDeconnexion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btDeconnexion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btDeconnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeconnexion.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeconnexion.Location = new System.Drawing.Point(709, 18);
            this.btDeconnexion.Name = "btDeconnexion";
            this.btDeconnexion.Size = new System.Drawing.Size(125, 36);
            this.btDeconnexion.TabIndex = 3;
            this.btDeconnexion.Text = "Déconnexion";
            this.btDeconnexion.UseVisualStyleBackColor = true;
            this.btDeconnexion.Click += new System.EventHandler(this.btDeconnexion_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(-5, 72);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 51);
            this.button3.TabIndex = 5;
            this.button3.Text = "Ajouter un compte rendu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(-5, 120);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(182, 45);
            this.button4.TabIndex = 6;
            this.button4.Text = "Localition personne";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(-5, 321);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(182, 41);
            this.button5.TabIndex = 8;
            this.button5.Text = "Exporter";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(-2, 284);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(177, 40);
            this.button6.TabIndex = 7;
            this.button6.Text = "Importer";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(-5, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 45);
            this.button1.TabIndex = 9;
            this.button1.Text = "Ajouter un SoinsVisite";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormAccueil
            // 
            this.ClientSize = new System.Drawing.Size(846, 383);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel3);
            this.Name = "FormAccueil";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisite)).EndInit();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label lbBienvenue1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVisite;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdInfirmiere;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_prevue;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_reelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn duree;
        private System.Windows.Forms.DataGridViewTextBoxColumn compte_rendu_infirmiere;
    }
}