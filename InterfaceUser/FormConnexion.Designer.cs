namespace InterfaceUser
{
    partial class FormConnexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConnexion));
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbMdp1 = new System.Windows.Forms.TextBox();
            this.btVal = new System.Windows.Forms.Button();
            this.lbBienvenue1 = new System.Windows.Forms.Label();
            this.MdpLogo = new System.Windows.Forms.PictureBox();
            this.idLogo = new System.Windows.Forms.PictureBox();
            this.mainLogo = new System.Windows.Forms.PictureBox();
            this.bottomLogo = new System.Windows.Forms.PictureBox();
            this.design1 = new System.Windows.Forms.Panel();
            this.design2 = new System.Windows.Forms.Panel();
            this.lbError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MdpLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tbId
            // 
            this.tbId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbId.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbId.Location = new System.Drawing.Point(123, 171);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(143, 26);
            this.tbId.TabIndex = 0;
            this.tbId.Text = "Utilisateur";
            this.tbId.Enter += new System.EventHandler(this.tbId_Enter);
            this.tbId.Leave += new System.EventHandler(this.tbId_Leave);
            // 
            // tbMdp1
            // 
            this.tbMdp1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbMdp1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMdp1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMdp1.Location = new System.Drawing.Point(413, 171);
            this.tbMdp1.Name = "tbMdp1";
            this.tbMdp1.Size = new System.Drawing.Size(143, 26);
            this.tbMdp1.TabIndex = 1;
            this.tbMdp1.Text = "Mot de passe";
            this.tbMdp1.Enter += new System.EventHandler(this.tbMdp1_Enter);
            this.tbMdp1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMdp1_KeyDown);
            this.tbMdp1.Leave += new System.EventHandler(this.tbMdp1_Leave);
            // 
            // btVal
            // 
            this.btVal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btVal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btVal.FlatAppearance.BorderSize = 3;
            this.btVal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btVal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btVal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVal.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btVal.Location = new System.Drawing.Point(245, 286);
            this.btVal.Name = "btVal";
            this.btVal.Size = new System.Drawing.Size(150, 38);
            this.btVal.TabIndex = 2;
            this.btVal.Text = "Connexion";
            this.btVal.UseVisualStyleBackColor = true;
            this.btVal.Click += new System.EventHandler(this.btVal_Click);
            // 
            // lbBienvenue1
            // 
            this.lbBienvenue1.AutoSize = true;
            this.lbBienvenue1.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBienvenue1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbBienvenue1.Location = new System.Drawing.Point(12, 9);
            this.lbBienvenue1.Name = "lbBienvenue1";
            this.lbBienvenue1.Size = new System.Drawing.Size(157, 37);
            this.lbBienvenue1.TabIndex = 6;
            this.lbBienvenue1.Text = "Kaliémie";
            // 
            // MdpLogo
            // 
            this.MdpLogo.Image = global::InterfaceUser.Properties.Resources.icons8_password_32;
            this.MdpLogo.Location = new System.Drawing.Point(375, 165);
            this.MdpLogo.Name = "MdpLogo";
            this.MdpLogo.Size = new System.Drawing.Size(32, 32);
            this.MdpLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.MdpLogo.TabIndex = 9;
            this.MdpLogo.TabStop = false;
            // 
            // idLogo
            // 
            this.idLogo.Image = global::InterfaceUser.Properties.Resources.icons8_customer_32;
            this.idLogo.Location = new System.Drawing.Point(85, 166);
            this.idLogo.Name = "idLogo";
            this.idLogo.Size = new System.Drawing.Size(32, 32);
            this.idLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.idLogo.TabIndex = 8;
            this.idLogo.TabStop = false;
            // 
            // mainLogo
            // 
            this.mainLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainLogo.Image = ((System.Drawing.Image)(resources.GetObject("mainLogo.Image")));
            this.mainLogo.Location = new System.Drawing.Point(215, -2);
            this.mainLogo.Name = "mainLogo";
            this.mainLogo.Size = new System.Drawing.Size(207, 249);
            this.mainLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainLogo.TabIndex = 3;
            this.mainLogo.TabStop = false;
            // 
            // bottomLogo
            // 
            this.bottomLogo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bottomLogo.Image = ((System.Drawing.Image)(resources.GetObject("bottomLogo.Image")));
            this.bottomLogo.Location = new System.Drawing.Point(-12, 242);
            this.bottomLogo.Name = "bottomLogo";
            this.bottomLogo.Size = new System.Drawing.Size(655, 164);
            this.bottomLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bottomLogo.TabIndex = 7;
            this.bottomLogo.TabStop = false;
            // 
            // design1
            // 
            this.design1.BackColor = System.Drawing.Color.DimGray;
            this.design1.Location = new System.Drawing.Point(85, 196);
            this.design1.Name = "design1";
            this.design1.Size = new System.Drawing.Size(176, 1);
            this.design1.TabIndex = 10;
            // 
            // design2
            // 
            this.design2.BackColor = System.Drawing.Color.DimGray;
            this.design2.Location = new System.Drawing.Point(375, 197);
            this.design2.Name = "design2";
            this.design2.Size = new System.Drawing.Size(176, 1);
            this.design2.TabIndex = 11;
            // 
            // lbError
            // 
            this.lbError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbError.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(177, 242);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(286, 41);
            this.lbError.TabIndex = 12;
            this.lbError.Text = "Un ou plusieurs paramètre(s) est/sont incorrect(s)";
            this.lbError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbError.Visible = false;
            // 
            // FormConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(642, 383);
            this.Controls.Add(this.design2);
            this.Controls.Add(this.design1);
            this.Controls.Add(this.MdpLogo);
            this.Controls.Add(this.tbMdp1);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.mainLogo);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.idLogo);
            this.Controls.Add(this.lbBienvenue1);
            this.Controls.Add(this.btVal);
            this.Controls.Add(this.bottomLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            ((System.ComponentModel.ISupportInitialize)(this.MdpLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbMdp1;
        private System.Windows.Forms.Button btVal;
        private System.Windows.Forms.PictureBox mainLogo;
        private System.Windows.Forms.Label lbBienvenue1;
        private System.Windows.Forms.PictureBox bottomLogo;
        private System.Windows.Forms.PictureBox idLogo;
        private System.Windows.Forms.PictureBox MdpLogo;
        private System.Windows.Forms.Panel design1;
        private System.Windows.Forms.Panel design2;
        private System.Windows.Forms.Label lbError;
    }
}