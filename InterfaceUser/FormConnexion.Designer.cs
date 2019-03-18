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
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbMdp1 = new System.Windows.Forms.TextBox();
            this.btVal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbId
            // 
            this.tbId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbId.Location = new System.Drawing.Point(111, 186);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(83, 20);
            this.tbId.TabIndex = 0;
            // 
            // tbMdp1
            // 
            this.tbMdp1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbMdp1.Location = new System.Drawing.Point(283, 186);
            this.tbMdp1.Name = "tbMdp1";
            this.tbMdp1.Size = new System.Drawing.Size(83, 20);
            this.tbMdp1.TabIndex = 1;
            // 
            // btVal
            // 
            this.btVal.Location = new System.Drawing.Point(202, 232);
            this.btVal.Name = "btVal";
            this.btVal.Size = new System.Drawing.Size(75, 23);
            this.btVal.TabIndex = 2;
            this.btVal.Text = "Connexion";
            this.btVal.UseVisualStyleBackColor = true;
            this.btVal.Click += new System.EventHandler(this.btVal_Click);
            // 
            // FormConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(504, 290);
            this.Controls.Add(this.btVal);
            this.Controls.Add(this.tbMdp1);
            this.Controls.Add(this.tbId);
            this.Name = "FormConnexion";
            this.Text = "FormConnexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbMdp1;
        private System.Windows.Forms.Button btVal;
    }
}