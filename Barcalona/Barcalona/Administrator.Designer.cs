namespace Barcalona
{
    partial class Administrator
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
            this.btnVullen = new System.Windows.Forms.Button();
            this.rdbVoormiddag = new System.Windows.Forms.RadioButton();
            this.rdbNamiddag = new System.Windows.Forms.RadioButton();
            this.cldKiesDag = new System.Windows.Forms.MonthCalendar();
            this.dtvDagen = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNaamAc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlaatsen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKosten = new System.Windows.Forms.TextBox();
            this.btnRegistreer = new System.Windows.Forms.Button();
            this.btnVoegBegeleider = new System.Windows.Forms.Button();
            this.cmbBegeleiders = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtvDagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVullen
            // 
            this.btnVullen.Location = new System.Drawing.Point(12, 12);
            this.btnVullen.Name = "btnVullen";
            this.btnVullen.Size = new System.Drawing.Size(120, 39);
            this.btnVullen.TabIndex = 12;
            this.btnVullen.Text = "Voeg activiteit toe";
            this.btnVullen.UseVisualStyleBackColor = true;
            // 
            // rdbVoormiddag
            // 
            this.rdbVoormiddag.AutoSize = true;
            this.rdbVoormiddag.Location = new System.Drawing.Point(547, 113);
            this.rdbVoormiddag.Name = "rdbVoormiddag";
            this.rdbVoormiddag.Size = new System.Drawing.Size(81, 17);
            this.rdbVoormiddag.TabIndex = 14;
            this.rdbVoormiddag.TabStop = true;
            this.rdbVoormiddag.Text = "Voormiddag";
            this.rdbVoormiddag.UseVisualStyleBackColor = true;
            // 
            // rdbNamiddag
            // 
            this.rdbNamiddag.AutoSize = true;
            this.rdbNamiddag.Location = new System.Drawing.Point(555, 136);
            this.rdbNamiddag.Name = "rdbNamiddag";
            this.rdbNamiddag.Size = new System.Drawing.Size(73, 17);
            this.rdbNamiddag.TabIndex = 15;
            this.rdbNamiddag.TabStop = true;
            this.rdbNamiddag.Text = "Namiddag";
            this.rdbNamiddag.UseVisualStyleBackColor = true;
            this.rdbNamiddag.CheckedChanged += new System.EventHandler(this.rdbNamiddag_CheckedChanged);
            // 
            // cldKiesDag
            // 
            this.cldKiesDag.Location = new System.Drawing.Point(144, 34);
            this.cldKiesDag.Name = "cldKiesDag";
            this.cldKiesDag.TabIndex = 16;
            // 
            // dtvDagen
            // 
            this.dtvDagen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvDagen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dtvDagen.Location = new System.Drawing.Point(12, 259);
            this.dtvDagen.Name = "dtvDagen";
            this.dtvDagen.Size = new System.Drawing.Size(635, 192);
            this.dtvDagen.TabIndex = 17;
            this.dtvDagen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvDagen_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Kies de dag";
            // 
            // TxtNaamAc
            // 
            this.TxtNaamAc.Location = new System.Drawing.Point(473, 32);
            this.TxtNaamAc.Name = "TxtNaamAc";
            this.TxtNaamAc.Size = new System.Drawing.Size(155, 20);
            this.TxtNaamAc.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Naam activiteit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Aantal plaatsen";
            // 
            // txtPlaatsen
            // 
            this.txtPlaatsen.Location = new System.Drawing.Point(574, 61);
            this.txtPlaatsen.Name = "txtPlaatsen";
            this.txtPlaatsen.Size = new System.Drawing.Size(54, 20);
            this.txtPlaatsen.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(377, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Kostprijs";
            // 
            // txtKosten
            // 
            this.txtKosten.Location = new System.Drawing.Point(574, 87);
            this.txtKosten.Name = "txtKosten";
            this.txtKosten.Size = new System.Drawing.Size(54, 20);
            this.txtKosten.TabIndex = 25;
            // 
            // btnRegistreer
            // 
            this.btnRegistreer.Location = new System.Drawing.Point(12, 68);
            this.btnRegistreer.Name = "btnRegistreer";
            this.btnRegistreer.Size = new System.Drawing.Size(120, 39);
            this.btnRegistreer.TabIndex = 27;
            this.btnRegistreer.Text = "Registreer begeleiders";
            this.btnRegistreer.UseVisualStyleBackColor = true;
            // 
            // btnVoegBegeleider
            // 
            this.btnVoegBegeleider.Location = new System.Drawing.Point(380, 159);
            this.btnVoegBegeleider.Name = "btnVoegBegeleider";
            this.btnVoegBegeleider.Size = new System.Drawing.Size(116, 23);
            this.btnVoegBegeleider.TabIndex = 28;
            this.btnVoegBegeleider.Text = "Voeg begeleider toe";
            this.btnVoegBegeleider.UseVisualStyleBackColor = true;
            // 
            // cmbBegeleiders
            // 
            this.cmbBegeleiders.FormattingEnabled = true;
            this.cmbBegeleiders.Location = new System.Drawing.Point(502, 161);
            this.cmbBegeleiders.Name = "cmbBegeleiders";
            this.cmbBegeleiders.Size = new System.Drawing.Size(126, 21);
            this.cmbBegeleiders.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Uurregeling";
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 463);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbBegeleiders);
            this.Controls.Add(this.btnVoegBegeleider);
            this.Controls.Add(this.btnRegistreer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKosten);
            this.Controls.Add(this.txtPlaatsen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNaamAc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtvDagen);
            this.Controls.Add(this.cldKiesDag);
            this.Controls.Add(this.rdbNamiddag);
            this.Controls.Add(this.rdbVoormiddag);
            this.Controls.Add(this.btnVullen);
            this.Name = "Administrator";
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.Administrator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvDagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVullen;
        private System.Windows.Forms.RadioButton rdbVoormiddag;
        private System.Windows.Forms.RadioButton rdbNamiddag;
        private System.Windows.Forms.MonthCalendar cldKiesDag;
        private System.Windows.Forms.DataGridView dtvDagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNaamAc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPlaatsen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKosten;
        private System.Windows.Forms.Button btnRegistreer;
        private System.Windows.Forms.Button btnVoegBegeleider;
        private System.Windows.Forms.ComboBox cmbBegeleiders;
        private System.Windows.Forms.Label label4;
    }
}