namespace Barcelona
{
    partial class Lijsten
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lijsten));
            this.btnTerug = new System.Windows.Forms.Button();
            this.cmbActiviteiten = new System.Windows.Forms.ComboBox();
            this.lstLijst = new System.Windows.Forms.ListBox();
            this.lstBegleider = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(12, 380);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(152, 60);
            this.btnTerug.TabIndex = 0;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // cmbActiviteiten
            // 
            this.cmbActiviteiten.FormattingEnabled = true;
            this.cmbActiviteiten.Location = new System.Drawing.Point(12, 12);
            this.cmbActiviteiten.Name = "cmbActiviteiten";
            this.cmbActiviteiten.Size = new System.Drawing.Size(153, 21);
            this.cmbActiviteiten.TabIndex = 1;
            this.cmbActiviteiten.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // lstLijst
            // 
            this.lstLijst.FormattingEnabled = true;
            this.lstLijst.Location = new System.Drawing.Point(170, 11);
            this.lstLijst.Name = "lstLijst";
            this.lstLijst.Size = new System.Drawing.Size(271, 433);
            this.lstLijst.TabIndex = 2;
            this.lstLijst.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lstBegleider
            // 
            this.lstBegleider.FormattingEnabled = true;
            this.lstBegleider.Location = new System.Drawing.Point(12, 175);
            this.lstBegleider.Name = "lstBegleider";
            this.lstBegleider.Size = new System.Drawing.Size(152, 199);
            this.lstBegleider.TabIndex = 3;
            // 
            // Lijsten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(451, 450);
            this.Controls.Add(this.lstBegleider);
            this.Controls.Add(this.lstLijst);
            this.Controls.Add(this.cmbActiviteiten);
            this.Controls.Add(this.btnTerug);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lijsten";
            this.Text = "Lijsten";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Lijsten_FormClosed);
            this.Load += new System.EventHandler(this.Lijsten_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.ComboBox cmbActiviteiten;
        private System.Windows.Forms.ListBox lstLijst;
        private System.Windows.Forms.ListBox lstBegleider;
    }
}