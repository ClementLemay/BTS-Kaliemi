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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbId
            // 
            this.tbId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbId.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbId.Location = new System.Drawing.Point(85, 185);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(143, 33);
            this.tbId.TabIndex = 0;
            this.tbId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbMdp1
            // 
            this.tbMdp1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMdp1.Location = new System.Drawing.Point(257, 185);
            this.tbMdp1.Name = "tbMdp1";
            this.tbMdp1.PasswordChar = '•';
            this.tbMdp1.Size = new System.Drawing.Size(143, 33);
            this.tbMdp1.TabIndex = 1;
            this.tbMdp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btVal
            // 
            this.btVal.FlatAppearance.BorderSize = 0;
            this.btVal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btVal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btVal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVal.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVal.Location = new System.Drawing.Point(167, 240);
            this.btVal.Name = "btVal";
            this.btVal.Size = new System.Drawing.Size(150, 38);
            this.btVal.TabIndex = 2;
            this.btVal.Text = "Connexion";
            this.btVal.UseVisualStyleBackColor = true;
            this.btVal.Click += new System.EventHandler(this.btVal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(177, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(504, 290);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btVal);
            this.Controls.Add(this.tbMdp1);
            this.Controls.Add(this.tbId);
            this.Name = "FormConnexion";
            this.Text = "FormConnexion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbMdp1;
        private System.Windows.Forms.Button btVal;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}