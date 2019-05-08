namespace Barcelona
{
    partial class frmStartscherm
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
            this.btnAdministrator = new System.Windows.Forms.Button();
            this.btnGebruiker = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdministrator
            // 
            this.btnAdministrator.Location = new System.Drawing.Point(388, 136);
            this.btnAdministrator.Name = "btnAdministrator";
            this.btnAdministrator.Size = new System.Drawing.Size(178, 71);
            this.btnAdministrator.TabIndex = 0;
            this.btnAdministrator.Text = "Administrator";
            this.btnAdministrator.UseVisualStyleBackColor = true;
            this.btnAdministrator.Click += new System.EventHandler(this.btnAdministrator_Click);
            // 
            // btnGebruiker
            // 
            this.btnGebruiker.Location = new System.Drawing.Point(204, 136);
            this.btnGebruiker.Name = "btnGebruiker";
            this.btnGebruiker.Size = new System.Drawing.Size(178, 71);
            this.btnGebruiker.TabIndex = 1;
            this.btnGebruiker.Text = "Gebruiker";
            this.btnGebruiker.UseVisualStyleBackColor = true;
            this.btnGebruiker.Click += new System.EventHandler(this.btnGebruiker_Click);
            // 
            // frmStartscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGebruiker);
            this.Controls.Add(this.btnAdministrator);
            this.Name = "frmStartscherm";
            this.Text = "Activiteiten Barcelona";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdministrator;
        private System.Windows.Forms.Button btnGebruiker;
    }
}