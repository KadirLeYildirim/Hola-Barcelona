namespace Barcelona
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
			this.txtVoornaam = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtGsmNummer = new System.Windows.Forms.TextBox();
			this.txtAchternaam = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblAchternaam = new System.Windows.Forms.Label();
			this.cmbKlas = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cmbKeuze = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnAdmin = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.btnVolgende = new System.Windows.Forms.Button();
			this.btnRegistreer = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtVoornaam
			// 
			this.txtVoornaam.Location = new System.Drawing.Point(147, 23);
			this.txtVoornaam.Name = "txtVoornaam";
			this.txtVoornaam.Size = new System.Drawing.Size(121, 20);
			this.txtVoornaam.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(29, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Voornaam";
			// 
			// txtGsmNummer
			// 
			this.txtGsmNummer.Location = new System.Drawing.Point(147, 75);
			this.txtGsmNummer.Name = "txtGsmNummer";
			this.txtGsmNummer.Size = new System.Drawing.Size(121, 20);
			this.txtGsmNummer.TabIndex = 3;
			// 
			// txtAchternaam
			// 
			this.txtAchternaam.Location = new System.Drawing.Point(147, 49);
			this.txtAchternaam.Name = "txtAchternaam";
			this.txtAchternaam.Size = new System.Drawing.Size(121, 20);
			this.txtAchternaam.TabIndex = 2;
			this.txtAchternaam.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(29, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(27, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Klas";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(29, 78);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Gsmnummer";
			// 
			// lblAchternaam
			// 
			this.lblAchternaam.AutoSize = true;
			this.lblAchternaam.Location = new System.Drawing.Point(29, 52);
			this.lblAchternaam.Name = "lblAchternaam";
			this.lblAchternaam.Size = new System.Drawing.Size(64, 13);
			this.lblAchternaam.TabIndex = 7;
			this.lblAchternaam.Text = "Achternaam";
			// 
			// cmbKlas
			// 
			this.cmbKlas.FormattingEnabled = true;
			this.cmbKlas.Items.AddRange(new object[] {
            "6AIT",
            "6ITN",
            "6MO1",
            "6MO2",
            "6OMC"});
			this.cmbKlas.Location = new System.Drawing.Point(195, 101);
			this.cmbKlas.Name = "cmbKlas";
			this.cmbKlas.Size = new System.Drawing.Size(73, 21);
			this.cmbKlas.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(287, 23);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(98, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Kies uw activiteiten";
			// 
			// cmbKeuze
			// 
			this.cmbKeuze.FormattingEnabled = true;
			this.cmbKeuze.Location = new System.Drawing.Point(333, 74);
			this.cmbKeuze.Name = "cmbKeuze";
			this.cmbKeuze.Size = new System.Drawing.Size(121, 21);
			this.cmbKeuze.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(287, 52);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Voor:";
			// 
			// btnAdmin
			// 
			this.btnAdmin.Location = new System.Drawing.Point(12, 171);
			this.btnAdmin.Name = "btnAdmin";
			this.btnAdmin.Size = new System.Drawing.Size(109, 59);
			this.btnAdmin.TabIndex = 12;
			this.btnAdmin.Text = "Administrator";
			this.btnAdmin.UseVisualStyleBackColor = true;
			this.btnAdmin.Click += new System.EventHandler(this.button1_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(355, 130);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(99, 38);
			this.button1.TabIndex = 8;
			this.button1.Text = "Bevestigen";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Visible = false;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// btnVolgende
			// 
			this.btnVolgende.Location = new System.Drawing.Point(355, 101);
			this.btnVolgende.Name = "btnVolgende";
			this.btnVolgende.Size = new System.Drawing.Size(99, 23);
			this.btnVolgende.TabIndex = 7;
			this.btnVolgende.Text = "Volgende";
			this.btnVolgende.UseVisualStyleBackColor = true;
			this.btnVolgende.Click += new System.EventHandler(this.btnVolgende_Click);
			// 
			// btnRegistreer
			// 
			this.btnRegistreer.Location = new System.Drawing.Point(130, 130);
			this.btnRegistreer.Name = "btnRegistreer";
			this.btnRegistreer.Size = new System.Drawing.Size(138, 38);
			this.btnRegistreer.TabIndex = 5;
			this.btnRegistreer.Text = "Voeg leerling toe";
			this.btnRegistreer.UseVisualStyleBackColor = true;
			this.btnRegistreer.Click += new System.EventHandler(this.btnRegistreer_Click);
			// 
			// VoegLeerlingToe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(470, 242);
			this.Controls.Add(this.btnRegistreer);
			this.Controls.Add(this.btnVolgende);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnAdmin);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cmbKeuze);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cmbKlas);
			this.Controls.Add(this.lblAchternaam);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtAchternaam);
			this.Controls.Add(this.txtGsmNummer);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtVoornaam);
			this.Name = "VoegLeerlingToe";
			this.Text = "Voeg een leerling toe";
			this.Load += new System.EventHandler(this.VoegLeerlingToe_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVoornaam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGsmNummer;
        private System.Windows.Forms.TextBox txtAchternaam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAchternaam;
        private System.Windows.Forms.ComboBox cmbKlas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbKeuze;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVolgende;
        private System.Windows.Forms.Button btnRegistreer;
    }
}

