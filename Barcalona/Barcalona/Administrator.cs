using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barcalona
{
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }

        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            txtKosten.Visible = false;
            TxtNaamAc.Visible = false;
            txtPlaatsen.Visible = false;
            btnVoegBegeleider.Visible = false;
            cmbBegeleiders.Visible = false;
            cldKiesDag.Visible = false;
        }

        private void dtvDagen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rdbNamiddag_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
