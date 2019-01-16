namespace Barcelona
{
    partial class ActiviteitAanpassen
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
            this.lstActiviteiten = new System.Windows.Forms.ListBox();
            this.txtOmschrijving = new System.Windows.Forms.TextBox();
            this.clbBegeleiders = new System.Windows.Forms.CheckedListBox();
            this.btnBevestigen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbNamiddag = new System.Windows.Forms.RadioButton();
            this.rdbVoormiddag = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrijs = new System.Windows.Forms.TextBox();
            this.txtAantalPlaatsen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTerug = new System.Windows.Forms.Button();
            this.txtDeelnemers = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.g = new System.Windows.Forms.Label();
            this.lstGekozenBegeleiders = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstActiviteiten
            // 
            this.lstActiviteiten.FormattingEnabled = true;
            this.lstActiviteiten.Location = new System.Drawing.Point(12, 12);
            this.lstActiviteiten.Name = "lstActiviteiten";
            this.lstActiviteiten.Size = new System.Drawing.Size(329, 394);
            this.lstActiviteiten.TabIndex = 0;
            this.lstActiviteiten.SelectedIndexChanged += new System.EventHandler(this.lstActiviteiten_SelectedIndexChanged);
            // 
            // txtOmschrijving
            // 
            this.txtOmschrijving.Location = new System.Drawing.Point(459, 185);
            this.txtOmschrijving.Multiline = true;
            this.txtOmschrijving.Name = "txtOmschrijving";
            this.txtOmschrijving.Size = new System.Drawing.Size(174, 59);
            this.txtOmschrijving.TabIndex = 28;
            // 
            // clbBegeleiders
            // 
            this.clbBegeleiders.FormattingEnabled = true;
            this.clbBegeleiders.Location = new System.Drawing.Point(501, 270);
            this.clbBegeleiders.Name = "clbBegeleiders";
            this.clbBegeleiders.Size = new System.Drawing.Size(132, 94);
            this.clbBegeleiders.TabIndex = 30;
            // 
            // btnBevestigen
            // 
            this.btnBevestigen.Location = new System.Drawing.Point(542, 370);
            this.btnBevestigen.Name = "btnBevestigen";
            this.btnBevestigen.Size = new System.Drawing.Size(91, 56);
            this.btnBevestigen.TabIndex = 32;
            this.btnBevestigen.Text = "Bevestig";
            this.btnBevestigen.UseVisualStyleBackColor = true;
            this.btnBevestigen.Click += new System.EventHandler(this.btnBevestigen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(533, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Kies een begeleider";
            // 
            // rdbNamiddag
            // 
            this.rdbNamiddag.AutoSize = true;
            this.rdbNamiddag.Location = new System.Drawing.Point(533, 165);
            this.rdbNamiddag.Name = "rdbNamiddag";
            this.rdbNamiddag.Size = new System.Drawing.Size(73, 17);
            this.rdbNamiddag.TabIndex = 27;
            this.rdbNamiddag.TabStop = true;
            this.rdbNamiddag.Text = "Namiddag";
            this.rdbNamiddag.UseVisualStyleBackColor = true;
            // 
            // rdbVoormiddag
            // 
            this.rdbVoormiddag.AutoSize = true;
            this.rdbVoormiddag.Location = new System.Drawing.Point(533, 142);
            this.rdbVoormiddag.Name = "rdbVoormiddag";
            this.rdbVoormiddag.Size = new System.Drawing.Size(81, 17);
            this.rdbVoormiddag.TabIndex = 25;
            this.rdbVoormiddag.TabStop = true;
            this.rdbVoormiddag.Text = "Voormiddag";
            this.rdbVoormiddag.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(350, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Omschrijving";
            // 
            // txtPrijs
            // 
            this.txtPrijs.Location = new System.Drawing.Point(533, 38);
            this.txtPrijs.Name = "txtPrijs";
            this.txtPrijs.Size = new System.Drawing.Size(100, 20);
            this.txtPrijs.TabIndex = 22;
            // 
            // txtAantalPlaatsen
            // 
            this.txtAantalPlaatsen.Location = new System.Drawing.Point(533, 64);
            this.txtAantalPlaatsen.Name = "txtAantalPlaatsen";
            this.txtAantalPlaatsen.Size = new System.Drawing.Size(100, 20);
            this.txtAantalPlaatsen.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Aantal plaatsen";
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(533, 12);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(100, 20);
            this.txtNaam.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Naam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Prijs per persoon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Uurregeling";
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(353, 371);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(91, 56);
            this.btnTerug.TabIndex = 36;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // txtDeelnemers
            // 
            this.txtDeelnemers.Location = new System.Drawing.Point(533, 90);
            this.txtDeelnemers.Name = "txtDeelnemers";
            this.txtDeelnemers.Size = new System.Drawing.Size(100, 20);
            this.txtDeelnemers.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(350, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Aantal deelnemers";
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(533, 116);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(100, 20);
            this.txtDatum.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Datum";
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.Location = new System.Drawing.Point(450, 370);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(86, 57);
            this.btnVerwijderen.TabIndex = 41;
            this.btnVerwijderen.Text = "Activiteit verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = true;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // g
            // 
            this.g.AutoSize = true;
            this.g.Location = new System.Drawing.Point(350, 254);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(107, 13);
            this.g.TabIndex = 43;
            this.g.Text = "Gekozen begeleiders";
            // 
            // lstGekozenBegeleiders
            // 
            this.lstGekozenBegeleiders.FormattingEnabled = true;
            this.lstGekozenBegeleiders.Location = new System.Drawing.Point(353, 270);
            this.lstGekozenBegeleiders.Name = "lstGekozenBegeleiders";
            this.lstGekozenBegeleiders.Size = new System.Drawing.Size(117, 95);
            this.lstGekozenBegeleiders.TabIndex = 44;
            // 
            // ActiviteitAanpassen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 438);
            this.Controls.Add(this.lstGekozenBegeleiders);
            this.Controls.Add(this.g);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDeelnemers);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.txtOmschrijving);
            this.Controls.Add(this.clbBegeleiders);
            this.Controls.Add(this.btnBevestigen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdbNamiddag);
            this.Controls.Add(this.rdbVoormiddag);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrijs);
            this.Controls.Add(this.txtAantalPlaatsen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstActiviteiten);
            this.Name = "ActiviteitAanpassen";
            this.Text = "ActiviteitAanpassen";
            this.Load += new System.EventHandler(this.ActiviteitAanpassen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstActiviteiten;
        private System.Windows.Forms.TextBox txtOmschrijving;
        private System.Windows.Forms.CheckedListBox clbBegeleiders;
        private System.Windows.Forms.Button btnBevestigen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbNamiddag;
        private System.Windows.Forms.RadioButton rdbVoormiddag;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrijs;
        private System.Windows.Forms.TextBox txtAantalPlaatsen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.TextBox txtDeelnemers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerwijderen;
        private System.Windows.Forms.Label g;
        private System.Windows.Forms.ListBox lstGekozenBegeleiders;
    }
}