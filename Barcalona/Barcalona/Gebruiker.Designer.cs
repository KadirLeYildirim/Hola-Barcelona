﻿namespace Barcalona
{
    partial class Gebruiker
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
            this.btnVolgende = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbActiviteit = new System.Windows.Forms.ComboBox();
            this.cmbKlas = new System.Windows.Forms.ComboBox();
            this.txtGSM = new System.Windows.Forms.TextBox();
            this.txtKlasnummer = new System.Windows.Forms.TextBox();
            this.txtAchternaam = new System.Windows.Forms.TextBox();
            this.txtVoornaam = new System.Windows.Forms.TextBox();
            this.lblPlaatsen = new System.Windows.Forms.Label();
            this.btnBevestigen = new System.Windows.Forms.Button();
            this.xd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVolgende
            // 
            this.btnVolgende.Location = new System.Drawing.Point(334, 98);
            this.btnVolgende.Name = "btnVolgende";
            this.btnVolgende.Size = new System.Drawing.Size(75, 23);
            this.btnVolgende.TabIndex = 0;
            this.btnVolgende.Text = "Volgende";
            this.btnVolgende.UseVisualStyleBackColor = true;
            this.btnVolgende.Click += new System.EventHandler(this.btnVolgende_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Voornaam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Klas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Achternaam:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "GSM nummer:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Klasnummer: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(331, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Activiteit keuze:";
            // 
            // cmbActiviteit
            // 
            this.cmbActiviteit.Enabled = false;
            this.cmbActiviteit.FormattingEnabled = true;
            this.cmbActiviteit.Location = new System.Drawing.Point(452, 27);
            this.cmbActiviteit.Name = "cmbActiviteit";
            this.cmbActiviteit.Size = new System.Drawing.Size(121, 21);
            this.cmbActiviteit.TabIndex = 7;
            // 
            // cmbKlas
            // 
            this.cmbKlas.FormattingEnabled = true;
            this.cmbKlas.Items.AddRange(new object[] {
            "6ITN",
            "6MO1",
            "6MO2",
            "6AIT"});
            this.cmbKlas.Location = new System.Drawing.Point(172, 195);
            this.cmbKlas.Name = "cmbKlas";
            this.cmbKlas.Size = new System.Drawing.Size(121, 21);
            this.cmbKlas.TabIndex = 8;
            // 
            // txtGSM
            // 
            this.txtGSM.Location = new System.Drawing.Point(172, 145);
            this.txtGSM.Name = "txtGSM";
            this.txtGSM.Size = new System.Drawing.Size(121, 20);
            this.txtGSM.TabIndex = 9;
            // 
            // txtKlasnummer
            // 
            this.txtKlasnummer.Location = new System.Drawing.Point(172, 105);
            this.txtKlasnummer.Name = "txtKlasnummer";
            this.txtKlasnummer.Size = new System.Drawing.Size(121, 20);
            this.txtKlasnummer.TabIndex = 10;
            // 
            // txtAchternaam
            // 
            this.txtAchternaam.Location = new System.Drawing.Point(172, 65);
            this.txtAchternaam.Name = "txtAchternaam";
            this.txtAchternaam.Size = new System.Drawing.Size(121, 20);
            this.txtAchternaam.TabIndex = 11;
            // 
            // txtVoornaam
            // 
            this.txtVoornaam.Location = new System.Drawing.Point(172, 25);
            this.txtVoornaam.Name = "txtVoornaam";
            this.txtVoornaam.Size = new System.Drawing.Size(121, 20);
            this.txtVoornaam.TabIndex = 12;
            // 
            // lblPlaatsen
            // 
            this.lblPlaatsen.AutoSize = true;
            this.lblPlaatsen.Location = new System.Drawing.Point(331, 68);
            this.lblPlaatsen.Name = "lblPlaatsen";
            this.lblPlaatsen.Size = new System.Drawing.Size(99, 13);
            this.lblPlaatsen.TabIndex = 13;
            this.lblPlaatsen.Text = "Aantal plaatsen vrij:";
            // 
            // btnBevestigen
            // 
            this.btnBevestigen.Enabled = false;
            this.btnBevestigen.Location = new System.Drawing.Point(334, 134);
            this.btnBevestigen.Name = "btnBevestigen";
            this.btnBevestigen.Size = new System.Drawing.Size(75, 23);
            this.btnBevestigen.TabIndex = 14;
            this.btnBevestigen.Text = "Bevestigen";
            this.btnBevestigen.UseVisualStyleBackColor = true;
            this.btnBevestigen.Click += new System.EventHandler(this.btnBevestigen_Click);
            // 
            // xd
            // 
            this.xd.Location = new System.Drawing.Point(490, 198);
            this.xd.Name = "xd";
            this.xd.Size = new System.Drawing.Size(75, 23);
            this.xd.TabIndex = 15;
            this.xd.Text = "xd";
            this.xd.UseVisualStyleBackColor = true;
            this.xd.Click += new System.EventHandler(this.xd_Click);
            // 
            // Gebruiker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 229);
            this.Controls.Add(this.xd);
            this.Controls.Add(this.btnBevestigen);
            this.Controls.Add(this.lblPlaatsen);
            this.Controls.Add(this.txtVoornaam);
            this.Controls.Add(this.txtAchternaam);
            this.Controls.Add(this.txtKlasnummer);
            this.Controls.Add(this.txtGSM);
            this.Controls.Add(this.cmbKlas);
            this.Controls.Add(this.cmbActiviteit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolgende);
            this.Name = "Gebruiker";
            this.Text = "Barcalona";
            this.Load += new System.EventHandler(this.Gebruiker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolgende;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbActiviteit;
        private System.Windows.Forms.ComboBox cmbKlas;
        private System.Windows.Forms.TextBox txtGSM;
        private System.Windows.Forms.TextBox txtKlasnummer;
        private System.Windows.Forms.TextBox txtAchternaam;
        private System.Windows.Forms.TextBox txtVoornaam;
        private System.Windows.Forms.Label lblPlaatsen;
        private System.Windows.Forms.Button btnBevestigen;
        private System.Windows.Forms.Button xd;
    }
}
