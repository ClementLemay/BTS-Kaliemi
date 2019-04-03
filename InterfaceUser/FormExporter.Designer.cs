namespace InterfaceUser
{
    partial class FormExporter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExporter));
            this.cbParam = new System.Windows.Forms.CheckBox();
            this.cbVisite = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbNotif = new System.Windows.Forms.Label();
            this.lbParametre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbParam
            // 
            this.cbParam.AutoSize = true;
            this.cbParam.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbParam.Location = new System.Drawing.Point(57, 80);
            this.cbParam.Name = "cbParam";
            this.cbParam.Size = new System.Drawing.Size(134, 23);
            this.cbParam.TabIndex = 0;
            this.cbParam.Text = "Mes paramètres";
            this.cbParam.UseVisualStyleBackColor = true;
            // 
            // cbVisite
            // 
            this.cbVisite.AutoSize = true;
            this.cbVisite.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVisite.Location = new System.Drawing.Point(57, 118);
            this.cbVisite.Name = "cbVisite";
            this.cbVisite.Size = new System.Drawing.Size(233, 23);
            this.cbVisite.TabIndex = 1;
            this.cbVisite.Text = "Changements relatifs aux visite";
            this.cbVisite.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(142, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Exporter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbNotif
            // 
            this.lbNotif.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNotif.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotif.ForeColor = System.Drawing.Color.Gray;
            this.lbNotif.Location = new System.Drawing.Point(88, 148);
            this.lbNotif.Name = "lbNotif";
            this.lbNotif.Size = new System.Drawing.Size(242, 33);
            this.lbNotif.TabIndex = 5;
            this.lbNotif.Text = "Toutes les données qui seront exportées ne seront plus disponible hors-connexion";
            this.lbNotif.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbParametre
            // 
            this.lbParametre.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbParametre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbParametre.Location = new System.Drawing.Point(12, 11);
            this.lbParametre.Name = "lbParametre";
            this.lbParametre.Size = new System.Drawing.Size(229, 54);
            this.lbParametre.TabIndex = 11;
            this.lbParametre.Text = "Exportation des données";
            this.lbParametre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormExporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(456, 241);
            this.Controls.Add(this.lbParametre);
            this.Controls.Add(this.lbNotif);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbVisite);
            this.Controls.Add(this.cbParam);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormExporter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exporter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbParam;
        private System.Windows.Forms.CheckBox cbVisite;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbNotif;
        private System.Windows.Forms.Label lbParametre;
    }
}