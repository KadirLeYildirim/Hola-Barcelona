namespace Barcelona
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
            this.dgvKalender = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVoegLeerkrachtToe = new System.Windows.Forms.Button();
            this.mclDag = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAantalPlaatsen = new System.Windows.Forms.TextBox();
            this.txtPrijs = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rdbVoormiddag = new System.Windows.Forms.RadioButton();
            this.rdbNamiddag = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.clbBegeleiders = new System.Windows.Forms.CheckedListBox();
            this.lstNamen = new System.Windows.Forms.ListBox();
            this.txtOmschrijving = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKalender)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKalender
            // 
            this.dgvKalender.AllowUserToOrderColumns = true;
            this.dgvKalender.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKalender.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvKalender.Location = new System.Drawing.Point(12, 305);
            this.dgvKalender.Name = "dgvKalender";
            this.dgvKalender.Size = new System.Drawing.Size(655, 208);
            this.dgvKalender.TabIndex = 1;
            this.dgvKalender.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // btnVoegLeerkrachtToe
            // 
            this.btnVoegLeerkrachtToe.Location = new System.Drawing.Point(12, 12);
            this.btnVoegLeerkrachtToe.Name = "btnVoegLeerkrachtToe";
            this.btnVoegLeerkrachtToe.Size = new System.Drawing.Size(100, 41);
            this.btnVoegLeerkrachtToe.TabIndex = 10;
            this.btnVoegLeerkrachtToe.Text = "Voeg een begeleider toe";
            this.btnVoegLeerkrachtToe.UseVisualStyleBackColor = true;
            this.btnVoegLeerkrachtToe.Click += new System.EventHandler(this.btnVoegLeerkrachtToe_Click);
            // 
            // mclDag
            // 
            this.mclDag.Location = new System.Drawing.Point(145, 31);
            this.mclDag.Name = "mclDag";
            this.mclDag.TabIndex = 1;
            this.mclDag.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mclDag_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kies de dag";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Uurregeling";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Prijs per persoon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Naam";
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(567, 13);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(100, 20);
            this.txtNaam.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(384, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Aantal plaatsen";
            // 
            // txtAantalPlaatsen
            // 
            this.txtAantalPlaatsen.Location = new System.Drawing.Point(567, 65);
            this.txtAantalPlaatsen.Name = "txtAantalPlaatsen";
            this.txtAantalPlaatsen.Size = new System.Drawing.Size(100, 20);
            this.txtAantalPlaatsen.TabIndex = 4;
            // 
            // txtPrijs
            // 
            this.txtPrijs.Location = new System.Drawing.Point(567, 39);
            this.txtPrijs.Name = "txtPrijs";
            this.txtPrijs.Size = new System.Drawing.Size(100, 20);
            this.txtPrijs.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(384, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Omschrijving";
            // 
            // rdbVoormiddag
            // 
            this.rdbVoormiddag.AutoSize = true;
            this.rdbVoormiddag.Location = new System.Drawing.Point(567, 91);
            this.rdbVoormiddag.Name = "rdbVoormiddag";
            this.rdbVoormiddag.Size = new System.Drawing.Size(81, 17);
            this.rdbVoormiddag.TabIndex = 5;
            this.rdbVoormiddag.TabStop = true;
            this.rdbVoormiddag.Text = "Voormiddag";
            this.rdbVoormiddag.UseVisualStyleBackColor = true;
            // 
            // rdbNamiddag
            // 
            this.rdbNamiddag.AutoSize = true;
            this.rdbNamiddag.Location = new System.Drawing.Point(567, 114);
            this.rdbNamiddag.Name = "rdbNamiddag";
            this.rdbNamiddag.Size = new System.Drawing.Size(73, 17);
            this.rdbNamiddag.TabIndex = 6;
            this.rdbNamiddag.TabStop = true;
            this.rdbNamiddag.Text = "Namiddag";
            this.rdbNamiddag.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Kies een begeleider";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(387, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 63);
            this.button1.TabIndex = 9;
            this.button1.Text = "Bevestig";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clbBegeleiders
            // 
            this.clbBegeleiders.FormattingEnabled = true;
            this.clbBegeleiders.Location = new System.Drawing.Point(507, 199);
            this.clbBegeleiders.Name = "clbBegeleiders";
            this.clbBegeleiders.Size = new System.Drawing.Size(160, 94);
            this.clbBegeleiders.TabIndex = 8;
            this.clbBegeleiders.SelectedIndexChanged += new System.EventHandler(this.clbBegeleiders_SelectedIndexChanged);
            // 
            // lstNamen
            // 
            this.lstNamen.FormattingEnabled = true;
            this.lstNamen.Location = new System.Drawing.Point(93, 202);
            this.lstNamen.Name = "lstNamen";
            this.lstNamen.Size = new System.Drawing.Size(197, 56);
            this.lstNamen.TabIndex = 22;
            // 
            // txtOmschrijving
            // 
            this.txtOmschrijving.Location = new System.Drawing.Point(493, 134);
            this.txtOmschrijving.Multiline = true;
            this.txtOmschrijving.Name = "txtOmschrijving";
            this.txtOmschrijving.Size = new System.Drawing.Size(174, 59);
            this.txtOmschrijving.TabIndex = 7;
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 525);
            this.Controls.Add(this.txtOmschrijving);
            this.Controls.Add(this.lstNamen);
            this.Controls.Add(this.clbBegeleiders);
            this.Controls.Add(this.button1);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mclDag);
            this.Controls.Add(this.btnVoegLeerkrachtToe);
            this.Controls.Add(this.dgvKalender);
            this.Name = "Administrator";
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.Administrator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKalender)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvKalender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btnVoegLeerkrachtToe;
        private System.Windows.Forms.MonthCalendar mclDag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAantalPlaatsen;
        private System.Windows.Forms.TextBox txtPrijs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdbVoormiddag;
        private System.Windows.Forms.RadioButton rdbNamiddag;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox clbBegeleiders;
        private System.Windows.Forms.ListBox lstNamen;
        private System.Windows.Forms.TextBox txtOmschrijving;
    }
}