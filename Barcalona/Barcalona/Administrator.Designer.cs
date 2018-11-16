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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.rdbVoormiddag.Location = new System.Drawing.Point(327, 11);
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
            this.rdbNamiddag.Location = new System.Drawing.Point(327, 34);
            this.rdbNamiddag.Name = "rdbNamiddag";
            this.rdbNamiddag.Size = new System.Drawing.Size(73, 17);
            this.rdbNamiddag.TabIndex = 15;
            this.rdbNamiddag.TabStop = true;
            this.rdbNamiddag.Text = "Namiddag";
            this.rdbNamiddag.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(144, 11);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(12, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 17;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 463);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.rdbNamiddag);
            this.Controls.Add(this.rdbVoormiddag);
            this.Controls.Add(this.btnVullen);
            this.Name = "Administrator";
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.Administrator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVullen;
        private System.Windows.Forms.RadioButton rdbVoormiddag;
        private System.Windows.Forms.RadioButton rdbNamiddag;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}