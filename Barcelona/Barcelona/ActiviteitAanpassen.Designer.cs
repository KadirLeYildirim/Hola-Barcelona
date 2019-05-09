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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActiviteitAanpassen));
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
            this.btnVerwijderBegeleider = new System.Windows.Forms.Button();
            this.btnVerwijderBegleider = new System.Windows.Forms.Button();
            this.txtURLFoto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstActiviteiten
            // 
            this.lstActiviteiten.FormattingEnabled = true;
            this.lstActiviteiten.ItemHeight = 16;
            this.lstActiviteiten.Location = new System.Drawing.Point(16, 15);
            this.lstActiviteiten.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstActiviteiten.Name = "lstActiviteiten";
            this.lstActiviteiten.Size = new System.Drawing.Size(437, 532);
            this.lstActiviteiten.TabIndex = 0;
            this.lstActiviteiten.SelectedIndexChanged += new System.EventHandler(this.lstActiviteiten_SelectedIndexChanged);
            // 
            // txtOmschrijving
            // 
            this.txtOmschrijving.Location = new System.Drawing.Point(613, 256);
            this.txtOmschrijving.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOmschrijving.Multiline = true;
            this.txtOmschrijving.Name = "txtOmschrijving";
            this.txtOmschrijving.Size = new System.Drawing.Size(231, 72);
            this.txtOmschrijving.TabIndex = 28;
            // 
            // clbBegeleiders
            // 
            this.clbBegeleiders.FormattingEnabled = true;
            this.clbBegeleiders.Location = new System.Drawing.Point(669, 352);
            this.clbBegeleiders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clbBegeleiders.Name = "clbBegeleiders";
            this.clbBegeleiders.Size = new System.Drawing.Size(175, 106);
            this.clbBegeleiders.TabIndex = 30;
            // 
            // btnBevestigen
            // 
            this.btnBevestigen.Location = new System.Drawing.Point(724, 507);
            this.btnBevestigen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBevestigen.Name = "btnBevestigen";
            this.btnBevestigen.Size = new System.Drawing.Size(121, 69);
            this.btnBevestigen.TabIndex = 32;
            this.btnBevestigen.Text = "Aanpassen";
            this.btnBevestigen.UseVisualStyleBackColor = true;
            this.btnBevestigen.Click += new System.EventHandler(this.btnBevestigen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(712, 332);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Kies een begeleider";
            // 
            // rdbNamiddag
            // 
            this.rdbNamiddag.AutoSize = true;
            this.rdbNamiddag.Location = new System.Drawing.Point(712, 231);
            this.rdbNamiddag.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbNamiddag.Name = "rdbNamiddag";
            this.rdbNamiddag.Size = new System.Drawing.Size(93, 21);
            this.rdbNamiddag.TabIndex = 27;
            this.rdbNamiddag.TabStop = true;
            this.rdbNamiddag.Text = "Namiddag";
            this.rdbNamiddag.UseVisualStyleBackColor = true;
            // 
            // rdbVoormiddag
            // 
            this.rdbVoormiddag.AutoSize = true;
            this.rdbVoormiddag.Location = new System.Drawing.Point(712, 203);
            this.rdbVoormiddag.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbVoormiddag.Name = "rdbVoormiddag";
            this.rdbVoormiddag.Size = new System.Drawing.Size(105, 21);
            this.rdbVoormiddag.TabIndex = 25;
            this.rdbVoormiddag.TabStop = true;
            this.rdbVoormiddag.Text = "Voormiddag";
            this.rdbVoormiddag.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(468, 259);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Omschrijving";
            // 
            // txtPrijs
            // 
            this.txtPrijs.Location = new System.Drawing.Point(669, 47);
            this.txtPrijs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrijs.Name = "txtPrijs";
            this.txtPrijs.Size = new System.Drawing.Size(175, 22);
            this.txtPrijs.TabIndex = 22;
            // 
            // txtAantalPlaatsen
            // 
            this.txtAantalPlaatsen.Location = new System.Drawing.Point(669, 79);
            this.txtAantalPlaatsen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAantalPlaatsen.Name = "txtAantalPlaatsen";
            this.txtAantalPlaatsen.Size = new System.Drawing.Size(175, 22);
            this.txtAantalPlaatsen.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(467, 82);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Aantal plaatsen";
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(669, 15);
            this.txtNaam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(175, 22);
            this.txtNaam.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(467, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Naam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(467, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Prijs per persoon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(468, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Uurregeling";
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(472, 507);
            this.btnTerug.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(121, 70);
            this.btnTerug.TabIndex = 36;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // txtDeelnemers
            // 
            this.txtDeelnemers.Location = new System.Drawing.Point(669, 109);
            this.txtDeelnemers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDeelnemers.Name = "txtDeelnemers";
            this.txtDeelnemers.Size = new System.Drawing.Size(175, 22);
            this.txtDeelnemers.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(467, 114);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 17);
            this.label8.TabIndex = 38;
            this.label8.Text = "Aantal deelnemers";
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(669, 143);
            this.txtDatum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(175, 22);
            this.txtDatum.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(467, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Datum";
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.Location = new System.Drawing.Point(601, 507);
            this.btnVerwijderen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(115, 70);
            this.btnVerwijderen.TabIndex = 41;
            this.btnVerwijderen.Text = "Activiteit verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = true;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // g
            // 
            this.g.AutoSize = true;
            this.g.Location = new System.Drawing.Point(468, 332);
            this.g.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(143, 17);
            this.g.TabIndex = 43;
            this.g.Text = "Gekozen begeleiders";
            // 
            // lstGekozenBegeleiders
            // 
            this.lstGekozenBegeleiders.FormattingEnabled = true;
            this.lstGekozenBegeleiders.ItemHeight = 16;
            this.lstGekozenBegeleiders.Location = new System.Drawing.Point(472, 352);
            this.lstGekozenBegeleiders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstGekozenBegeleiders.Name = "lstGekozenBegeleiders";
            this.lstGekozenBegeleiders.Size = new System.Drawing.Size(175, 116);
            this.lstGekozenBegeleiders.TabIndex = 44;
            this.lstGekozenBegeleiders.SelectedIndexChanged += new System.EventHandler(this.lstGekozenBegeleiders_SelectedIndexChanged);
            // 
            // btnVerwijderBegeleider
            // 
            this.btnVerwijderBegeleider.Location = new System.Drawing.Point(669, 475);
            this.btnVerwijderBegeleider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVerwijderBegeleider.Name = "btnVerwijderBegeleider";
            this.btnVerwijderBegeleider.Size = new System.Drawing.Size(176, 28);
            this.btnVerwijderBegeleider.TabIndex = 45;
            this.btnVerwijderBegeleider.Text = "Voeg begeleider toe";
            this.btnVerwijderBegeleider.UseVisualStyleBackColor = true;
            this.btnVerwijderBegeleider.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVerwijderBegleider
            // 
            this.btnVerwijderBegleider.Location = new System.Drawing.Point(472, 476);
            this.btnVerwijderBegleider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVerwijderBegleider.Name = "btnVerwijderBegleider";
            this.btnVerwijderBegleider.Size = new System.Drawing.Size(176, 28);
            this.btnVerwijderBegleider.TabIndex = 46;
            this.btnVerwijderBegleider.Text = "Verwijder begeleider";
            this.btnVerwijderBegleider.UseVisualStyleBackColor = true;
            this.btnVerwijderBegleider.Click += new System.EventHandler(this.btnVerwijderBegleider_Click);
            // 
            // txtURLFoto
            // 
            this.txtURLFoto.Location = new System.Drawing.Point(669, 173);
            this.txtURLFoto.Margin = new System.Windows.Forms.Padding(4);
            this.txtURLFoto.Name = "txtURLFoto";
            this.txtURLFoto.Size = new System.Drawing.Size(175, 22);
            this.txtURLFoto.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(467, 176);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 17);
            this.label9.TabIndex = 48;
            this.label9.Text = "Url voor foto";
            // 
            // ActiviteitAanpassen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(860, 619);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtURLFoto);
            this.Controls.Add(this.btnVerwijderBegleider);
            this.Controls.Add(this.btnVerwijderBegeleider);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ActiviteitAanpassen";
            this.Text = "ActiviteitAanpassen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ActiviteitAanpassen_FormClosed);
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
        private System.Windows.Forms.Button btnVerwijderBegeleider;
        private System.Windows.Forms.Button btnVerwijderBegleider;
        private System.Windows.Forms.TextBox txtURLFoto;
        private System.Windows.Forms.Label label9;
    }
}