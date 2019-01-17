namespace Barcelona
{
    partial class BegeleiderAanpassen
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
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.lstBegeleiders = new System.Windows.Forms.ListBox();
            this.btnAnnuleren = new System.Windows.Forms.Button();
            this.txtAchternaam = new System.Windows.Forms.TextBox();
            this.txtGsmNummer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAanpassen = new System.Windows.Forms.Button();
            this.txtVoornaam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.Location = new System.Drawing.Point(106, 236);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(91, 57);
            this.btnVerwijderen.TabIndex = 22;
            this.btnVerwijderen.Text = "Verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = true;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // lstBegeleiders
            // 
            this.lstBegeleiders.FormattingEnabled = true;
            this.lstBegeleiders.Location = new System.Drawing.Point(12, 12);
            this.lstBegeleiders.Name = "lstBegeleiders";
            this.lstBegeleiders.Size = new System.Drawing.Size(275, 134);
            this.lstBegeleiders.TabIndex = 21;
            this.lstBegeleiders.SelectedIndexChanged += new System.EventHandler(this.lstBegeleiders_SelectedIndexChanged);
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.Location = new System.Drawing.Point(12, 236);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(88, 57);
            this.btnAnnuleren.TabIndex = 19;
            this.btnAnnuleren.Text = "Terug naar administator";
            this.btnAnnuleren.UseVisualStyleBackColor = true;
            this.btnAnnuleren.Click += new System.EventHandler(this.btnAnnuleren_Click);
            // 
            // txtAchternaam
            // 
            this.txtAchternaam.Location = new System.Drawing.Point(140, 178);
            this.txtAchternaam.Name = "txtAchternaam";
            this.txtAchternaam.Size = new System.Drawing.Size(147, 20);
            this.txtAchternaam.TabIndex = 15;
            // 
            // txtGsmNummer
            // 
            this.txtGsmNummer.Location = new System.Drawing.Point(140, 204);
            this.txtGsmNummer.Name = "txtGsmNummer";
            this.txtGsmNummer.Size = new System.Drawing.Size(147, 20);
            this.txtGsmNummer.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Achternaam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Gsm nummer";
            // 
            // btnAanpassen
            // 
            this.btnAanpassen.Location = new System.Drawing.Point(203, 236);
            this.btnAanpassen.Name = "btnAanpassen";
            this.btnAanpassen.Size = new System.Drawing.Size(84, 57);
            this.btnAanpassen.TabIndex = 18;
            this.btnAanpassen.Text = "Aanpassen";
            this.btnAanpassen.UseVisualStyleBackColor = true;
            this.btnAanpassen.Click += new System.EventHandler(this.btnAanpassen_Click);
            // 
            // txtVoornaam
            // 
            this.txtVoornaam.Location = new System.Drawing.Point(140, 152);
            this.txtVoornaam.Name = "txtVoornaam";
            this.txtVoornaam.Size = new System.Drawing.Size(147, 20);
            this.txtVoornaam.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Voornaam";
            // 
            // BegeleiderAanpassen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 302);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.lstBegeleiders);
            this.Controls.Add(this.btnAnnuleren);
            this.Controls.Add(this.txtAchternaam);
            this.Controls.Add(this.txtGsmNummer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAanpassen);
            this.Controls.Add(this.txtVoornaam);
            this.Controls.Add(this.label1);
            this.Name = "BegeleiderAanpassen";
            this.Text = "BegeleiderAanpassen";
            this.Load += new System.EventHandler(this.BegeleiderAanpassen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerwijderen;
        private System.Windows.Forms.ListBox lstBegeleiders;
        private System.Windows.Forms.Button btnAnnuleren;
        private System.Windows.Forms.TextBox txtAchternaam;
        private System.Windows.Forms.TextBox txtGsmNummer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAanpassen;
        private System.Windows.Forms.TextBox txtVoornaam;
        private System.Windows.Forms.Label label1;
    }
}