namespace TelethonSystem
{
    partial class ETSTelethonSystem
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
            this.sponsorForm_btn = new System.Windows.Forms.Button();
            this.prizesForm_btn = new System.Windows.Forms.Button();
            this.donorsForm_btn = new System.Windows.Forms.Button();
            this.donationsForm_btn = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sponsorForm_btn
            // 
            this.sponsorForm_btn.BackColor = System.Drawing.Color.RosyBrown;
            this.sponsorForm_btn.Location = new System.Drawing.Point(217, 65);
            this.sponsorForm_btn.Name = "sponsorForm_btn";
            this.sponsorForm_btn.Size = new System.Drawing.Size(662, 80);
            this.sponsorForm_btn.TabIndex = 0;
            this.sponsorForm_btn.Text = "Sponsors";
            this.sponsorForm_btn.UseVisualStyleBackColor = false;
            this.sponsorForm_btn.Click += new System.EventHandler(this.sponsorForm_btn_Click);
            // 
            // prizesForm_btn
            // 
            this.prizesForm_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.prizesForm_btn.Location = new System.Drawing.Point(217, 290);
            this.prizesForm_btn.Name = "prizesForm_btn";
            this.prizesForm_btn.Size = new System.Drawing.Size(662, 80);
            this.prizesForm_btn.TabIndex = 1;
            this.prizesForm_btn.Text = "Prizes";
            this.prizesForm_btn.UseVisualStyleBackColor = false;
            this.prizesForm_btn.Click += new System.EventHandler(this.prizesForm_btn_Click);
            // 
            // donorsForm_btn
            // 
            this.donorsForm_btn.BackColor = System.Drawing.Color.SandyBrown;
            this.donorsForm_btn.Location = new System.Drawing.Point(217, 176);
            this.donorsForm_btn.Name = "donorsForm_btn";
            this.donorsForm_btn.Size = new System.Drawing.Size(662, 80);
            this.donorsForm_btn.TabIndex = 2;
            this.donorsForm_btn.Text = "Donors";
            this.donorsForm_btn.UseVisualStyleBackColor = false;
            this.donorsForm_btn.Click += new System.EventHandler(this.donorsForm_btn_Click);
            // 
            // donationsForm_btn
            // 
            this.donationsForm_btn.Location = new System.Drawing.Point(217, 398);
            this.donationsForm_btn.Name = "donationsForm_btn";
            this.donationsForm_btn.Size = new System.Drawing.Size(662, 80);
            this.donationsForm_btn.TabIndex = 3;
            this.donationsForm_btn.Text = "Donations";
            this.donationsForm_btn.UseVisualStyleBackColor = true;
            this.donationsForm_btn.Click += new System.EventHandler(this.donationsForm_btn_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.Khaki;
            this.logout_btn.Location = new System.Drawing.Point(217, 516);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(662, 80);
            this.logout_btn.TabIndex = 4;
            this.logout_btn.Text = "Log out";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // ETSTelethonSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1103, 680);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.donationsForm_btn);
            this.Controls.Add(this.donorsForm_btn);
            this.Controls.Add(this.prizesForm_btn);
            this.Controls.Add(this.sponsorForm_btn);
            this.Name = "ETSTelethonSystem";
            this.Text = "ETSTelethonSystem";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sponsorForm_btn;
        private System.Windows.Forms.Button prizesForm_btn;
        private System.Windows.Forms.Button donorsForm_btn;
        private System.Windows.Forms.Button donationsForm_btn;
        private System.Windows.Forms.Button logout_btn;
    }
}