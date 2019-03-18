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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvVisite = new System.Windows.Forms.DataGridView();
            this.lbNotif = new System.Windows.Forms.Label();
            this.idComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tbHeure = new System.Windows.Forms.TextBox();
            this.tbMinute = new System.Windows.Forms.TextBox();
            this.tbCompteRendu = new System.Windows.Forms.TextBox();
            this.btValider = new System.Windows.Forms.Button();
            this.idVisite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idInfirmiere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_prevue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_reelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompteRenduInfi = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel2.Size = new System.Drawing.Size(546, 307);
            this.panel2.TabIndex = 0;
            // 
            // dgvVisite
            // 
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
            this.dgvVisite.Size = new System.Drawing.Size(546, 307);
            this.dgvVisite.TabIndex = 1;
            // 
            // lbNotif
            // 
            this.lbNotif.AutoSize = true;
            this.lbNotif.Location = new System.Drawing.Point(72, 222);
            this.lbNotif.Name = "lbNotif";
            this.lbNotif.Size = new System.Drawing.Size(0, 13);
            this.lbNotif.TabIndex = 0;
            // 
            // idComboBox
            // 
            this.idComboBox.FormattingEnabled = true;
            this.idComboBox.Location = new System.Drawing.Point(75, 66);
            this.idComboBox.Name = "idComboBox";
            this.idComboBox.Size = new System.Drawing.Size(121, 21);
            this.idComboBox.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Location = new System.Drawing.Point(75, 113);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(141, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // tbHeure
            // 
            this.tbHeure.Location = new System.Drawing.Point(75, 153);
            this.tbHeure.Name = "tbHeure";
            this.tbHeure.Size = new System.Drawing.Size(45, 20);
            this.tbHeure.TabIndex = 2;
            // 
            // tbMinute
            // 
            this.tbMinute.Location = new System.Drawing.Point(162, 153);
            this.tbMinute.Name = "tbMinute";
            this.tbMinute.Size = new System.Drawing.Size(45, 20);
            this.tbMinute.TabIndex = 3;
            // 
            // tbCompteRendu
            // 
            this.tbCompteRendu.Location = new System.Drawing.Point(75, 199);
            this.tbCompteRendu.Name = "tbCompteRendu";
            this.tbCompteRendu.Size = new System.Drawing.Size(100, 20);
            this.tbCompteRendu.TabIndex = 2;
            // 
            // btValider
            // 
            this.btValider.Location = new System.Drawing.Point(75, 241);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(75, 28);
            this.btValider.TabIndex = 2;
            this.btValider.Text = "button1";
            this.btValider.UseVisualStyleBackColor = true;
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
            // FormCompteRenduVisite
            // 
            this.ClientSize = new System.Drawing.Size(764, 303);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.tbCompteRendu);
            this.Controls.Add(this.tbMinute);
            this.Controls.Add(this.tbHeure);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.idComboBox);
            this.Controls.Add(this.lbNotif);
            this.Controls.Add(this.panel2);
            this.MinimumSize = new System.Drawing.Size(780, 342);
            this.Name = "FormCompteRenduVisite";
            this.Text = "FormCompteRenduVisite";
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
    }
}