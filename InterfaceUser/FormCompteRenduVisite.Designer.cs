namespace InterfaceUser
{
    partial class FormCompteRenduVisite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompteRenduVisite));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvVisite = new System.Windows.Forms.DataGridView();
            this.idVisite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idInfirmiere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_prevue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_reelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompteRenduInfi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbNotif = new System.Windows.Forms.Label();
            this.idComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tbHeure = new System.Windows.Forms.TextBox();
            this.tbMinute = new System.Windows.Forms.TextBox();
            this.tbCompteRendu = new System.Windows.Forms.TextBox();
            this.btValider = new System.Windows.Forms.Button();
            this.lbParametre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisite)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgvVisite);
            this.panel2.Location = new System.Drawing.Point(222, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(552, 376);
            this.panel2.TabIndex = 0;
            // 
            // dgvVisite
            // 
            this.dgvVisite.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVisite.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvVisite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvVisite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisite.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVisite,
            this.idPatient,
            this.idInfirmiere,
            this.date_prevue,
            this.date_reelle,
            this.Duree,
            this.CompteRenduInfi});
            this.dgvVisite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVisite.Location = new System.Drawing.Point(0, 0);
            this.dgvVisite.Name = "dgvVisite";
            this.dgvVisite.RowHeadersWidth = 4;
            this.dgvVisite.Size = new System.Drawing.Size(552, 376);
            this.dgvVisite.TabIndex = 1;
            // 
            // idVisite
            // 
            this.idVisite.HeaderText = "idVisite";
            this.idVisite.Name = "idVisite";
            // 
            // idPatient
            // 
            this.idPatient.HeaderText = "idPatient";
            this.idPatient.Name = "idPatient";
            // 
            // idInfirmiere
            // 
            this.idInfirmiere.HeaderText = "idInfirmiere";
            this.idInfirmiere.Name = "idInfirmiere";
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
            // Duree
            // 
            this.Duree.HeaderText = "Duree";
            this.Duree.Name = "Duree";
            // 
            // CompteRenduInfi
            // 
            this.CompteRenduInfi.HeaderText = "CompteRenduInfi";
            this.CompteRenduInfi.Name = "CompteRenduInfi";
            // 
            // lbNotif
            // 
            this.lbNotif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbNotif.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotif.Location = new System.Drawing.Point(12, 262);
            this.lbNotif.Name = "lbNotif";
            this.lbNotif.Size = new System.Drawing.Size(196, 49);
            this.lbNotif.TabIndex = 0;
            this.lbNotif.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idComboBox
            // 
            this.idComboBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idComboBox.FormattingEnabled = true;
            this.idComboBox.Location = new System.Drawing.Point(91, 66);
            this.idComboBox.Name = "idComboBox";
            this.idComboBox.Size = new System.Drawing.Size(121, 27);
            this.idComboBox.TabIndex = 1;
            this.idComboBox.SelectionChangeCommitted += new System.EventHandler(this.idComboBox_SelectionChangeCommitted);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(91, 113);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 21);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // tbHeure
            // 
            this.tbHeure.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHeure.Location = new System.Drawing.Point(91, 153);
            this.tbHeure.MaxLength = 2;
            this.tbHeure.Name = "tbHeure";
            this.tbHeure.Size = new System.Drawing.Size(45, 27);
            this.tbHeure.TabIndex = 2;
            this.tbHeure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbMinute
            // 
            this.tbMinute.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMinute.Location = new System.Drawing.Point(163, 153);
            this.tbMinute.MaxLength = 2;
            this.tbMinute.Name = "tbMinute";
            this.tbMinute.Size = new System.Drawing.Size(45, 27);
            this.tbMinute.TabIndex = 3;
            this.tbMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbCompteRendu
            // 
            this.tbCompteRendu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCompteRendu.Location = new System.Drawing.Point(12, 224);
            this.tbCompteRendu.Name = "tbCompteRendu";
            this.tbCompteRendu.Size = new System.Drawing.Size(196, 27);
            this.tbCompteRendu.TabIndex = 2;
            // 
            // btValider
            // 
            this.btValider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btValider.FlatAppearance.BorderSize = 0;
            this.btValider.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btValider.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btValider.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btValider.ForeColor = System.Drawing.Color.Black;
            this.btValider.Location = new System.Drawing.Point(-4, 315);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(233, 45);
            this.btValider.TabIndex = 2;
            this.btValider.Text = "Confirmer";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // lbParametre
            // 
            this.lbParametre.AutoSize = true;
            this.lbParametre.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbParametre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbParametre.Location = new System.Drawing.Point(6, 9);
            this.lbParametre.Name = "lbParametre";
            this.lbParametre.Size = new System.Drawing.Size(186, 27);
            this.lbParametre.TabIndex = 4;
            this.lbParametre.Text = "Compte rendu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "IdVisite :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Heure :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Commentaire :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(140, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = ":";
            // 
            // FormCompteRenduVisite
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(770, 372);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbParametre);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.tbCompteRendu);
            this.Controls.Add(this.tbMinute);
            this.Controls.Add(this.tbHeure);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.idComboBox);
            this.Controls.Add(this.lbNotif);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(786, 411);
            this.Name = "FormCompteRenduVisite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter un compte rendu";
            this.Load += new System.EventHandler(this.FormCompteRenduVisite_Load_1);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbNotif;
        private System.Windows.Forms.DataGridView dgvVisite;
        private System.Windows.Forms.ComboBox idComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tbHeure;
        private System.Windows.Forms.TextBox tbMinute;
        private System.Windows.Forms.TextBox tbCompteRendu;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVisite;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInfirmiere;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_prevue;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_reelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duree;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompteRenduInfi;
        private System.Windows.Forms.Label lbParametre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}