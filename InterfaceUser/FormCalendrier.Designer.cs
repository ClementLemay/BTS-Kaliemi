namespace InterfaceUser
{
    partial class FormCalendrier
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lbBienvenue1 = new System.Windows.Forms.Label();
            this.btAjouterSV = new System.Windows.Forms.Button();
            this.lbEvent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.White;
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(3, 2);
            this.monthCalendar1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.monthCalendar1.Location = new System.Drawing.Point(139, 59);
            this.monthCalendar1.MaxSelectionCount = 999;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // lbBienvenue1
            // 
            this.lbBienvenue1.AutoSize = true;
            this.lbBienvenue1.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBienvenue1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbBienvenue1.Location = new System.Drawing.Point(12, 9);
            this.lbBienvenue1.Name = "lbBienvenue1";
            this.lbBienvenue1.Size = new System.Drawing.Size(173, 27);
            this.lbBienvenue1.TabIndex = 6;
            this.lbBienvenue1.Text = "Mon agenda ";
            // 
            // btAjouterSV
            // 
            this.btAjouterSV.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btAjouterSV.FlatAppearance.BorderSize = 0;
            this.btAjouterSV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btAjouterSV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btAjouterSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAjouterSV.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAjouterSV.Location = new System.Drawing.Point(5, 68);
            this.btAjouterSV.Name = "btAjouterSV";
            this.btAjouterSV.Size = new System.Drawing.Size(141, 48);
            this.btAjouterSV.TabIndex = 10;
            this.btAjouterSV.Text = "Afficher la prochaine visite";
            this.btAjouterSV.UseVisualStyleBackColor = true;
            this.btAjouterSV.Click += new System.EventHandler(this.btAjouterSV_Click);
            // 
            // lbEvent
            // 
            this.lbEvent.Location = new System.Drawing.Point(9, 141);
            this.lbEvent.Name = "lbEvent";
            this.lbEvent.Size = new System.Drawing.Size(134, 32);
            this.lbEvent.TabIndex = 11;
            this.lbEvent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCalendrier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(826, 370);
            this.Controls.Add(this.lbEvent);
            this.Controls.Add(this.btAjouterSV);
            this.Controls.Add(this.lbBienvenue1);
            this.Controls.Add(this.monthCalendar1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormCalendrier";
            this.Text = "Mon agenda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lbBienvenue1;
        private System.Windows.Forms.Button btAjouterSV;
        private System.Windows.Forms.Label lbEvent;
    }
}