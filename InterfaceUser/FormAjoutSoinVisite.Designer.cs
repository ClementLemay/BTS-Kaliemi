namespace InterfaceUser
{
    partial class FormAjoutSoinVisite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAjoutSoinVisite));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvVisite = new System.Windows.Forms.DataGridView();
            this.IdVisite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelSoins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_categ_soins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_type_soins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_soins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prevu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.realise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbSoins = new System.Windows.Forms.ComboBox();
            this.cbIdVisite = new System.Windows.Forms.ComboBox();
            this.cbRealise = new System.Windows.Forms.ComboBox();
            this.cbPrevu = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btValider = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbParametre = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisite)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvVisite);
            this.panel1.Location = new System.Drawing.Point(245, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 404);
            this.panel1.TabIndex = 0;
            // 
            // dgvVisite
            // 
            this.dgvVisite.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVisite.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvVisite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvVisite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisite.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdVisite,
            this.libelSoins,
            this.id_categ_soins,
            this.id_type_soins,
            this.id_soins,
            this.prevu,
            this.realise});
            this.dgvVisite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVisite.Location = new System.Drawing.Point(0, 0);
            this.dgvVisite.Name = "dgvVisite";
            this.dgvVisite.Size = new System.Drawing.Size(558, 404);
            this.dgvVisite.TabIndex = 0;
            // 
            // IdVisite
            // 
            this.IdVisite.HeaderText = "IdVisite";
            this.IdVisite.Name = "IdVisite";
            // 
            // libelSoins
            // 
            this.libelSoins.HeaderText = "libelSoins";
            this.libelSoins.Name = "libelSoins";
            // 
            // id_categ_soins
            // 
            this.id_categ_soins.HeaderText = "id_categ_soins";
            this.id_categ_soins.Name = "id_categ_soins";
            // 
            // id_type_soins
            // 
            this.id_type_soins.HeaderText = "id_type_soins";
            this.id_type_soins.Name = "id_type_soins";
            // 
            // id_soins
            // 
            this.id_soins.HeaderText = "id_soins";
            this.id_soins.Name = "id_soins";
            // 
            // prevu
            // 
            this.prevu.HeaderText = "prevu";
            this.prevu.Name = "prevu";
            // 
            // realise
            // 
            this.realise.HeaderText = "realise";
            this.realise.Name = "realise";
            // 
            // cbSoins
            // 
            this.cbSoins.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSoins.FormattingEnabled = true;
            this.cbSoins.Location = new System.Drawing.Point(18, 227);
            this.cbSoins.Name = "cbSoins";
            this.cbSoins.Size = new System.Drawing.Size(207, 21);
            this.cbSoins.TabIndex = 0;
            // 
            // cbIdVisite
            // 
            this.cbIdVisite.FormattingEnabled = true;
            this.cbIdVisite.Location = new System.Drawing.Point(83, 85);
            this.cbIdVisite.Name = "cbIdVisite";
            this.cbIdVisite.Size = new System.Drawing.Size(142, 21);
            this.cbIdVisite.TabIndex = 1;
            this.cbIdVisite.SelectedIndexChanged += new System.EventHandler(this.cbIdVisite_SelectedIndexChanged);
            // 
            // cbRealise
            // 
            this.cbRealise.FormattingEnabled = true;
            this.cbRealise.Location = new System.Drawing.Point(83, 125);
            this.cbRealise.Name = "cbRealise";
            this.cbRealise.Size = new System.Drawing.Size(142, 21);
            this.cbRealise.TabIndex = 2;
            // 
            // cbPrevu
            // 
            this.cbPrevu.FormattingEnabled = true;
            this.cbPrevu.Location = new System.Drawing.Point(83, 170);
            this.cbPrevu.Name = "cbPrevu";
            this.cbPrevu.Size = new System.Drawing.Size(142, 21);
            this.cbPrevu.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 280);
            this.label5.MinimumSize = new System.Drawing.Size(137, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 48);
            this.label5.TabIndex = 4;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btValider
            // 
            this.btValider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btValider.FlatAppearance.BorderSize = 0;
            this.btValider.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btValider.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btValider.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btValider.Location = new System.Drawing.Point(-3, 331);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(253, 60);
            this.btValider.TabIndex = 5;
            this.btValider.Text = "Confirmer";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Label :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "IdVisite :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Prévu :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Realisé :";
            // 
            // lbParametre
            // 
            this.lbParametre.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbParametre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbParametre.Location = new System.Drawing.Point(5, 4);
            this.lbParametre.Name = "lbParametre";
            this.lbParametre.Size = new System.Drawing.Size(229, 54);
            this.lbParametre.TabIndex = 10;
            this.lbParametre.Text = "Ajouter un soin à une visite";
            this.lbParametre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAjoutSoinVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 403);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbParametre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbPrevu);
            this.Controls.Add(this.cbRealise);
            this.Controls.Add(this.cbIdVisite);
            this.Controls.Add(this.cbSoins);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAjoutSoinVisite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajout soin visite";
            this.Load += new System.EventHandler(this.FormAjoutSoinVisite_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbSoins;
        private System.Windows.Forms.ComboBox cbIdVisite;
        private System.Windows.Forms.ComboBox cbRealise;
        private System.Windows.Forms.ComboBox cbPrevu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvVisite;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVisite;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelSoins;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_categ_soins;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_type_soins;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_soins;
        private System.Windows.Forms.DataGridViewTextBoxColumn prevu;
        private System.Windows.Forms.DataGridViewTextBoxColumn realise;
        private System.Windows.Forms.Label lbParametre;
    }
}