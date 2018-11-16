using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.VisualBasic;

namespace Barcalona
{
    public partial class Gebruiker : Form
    {
        public Gebruiker()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Gebruiker_Load(object sender, EventArgs e)
        {

        }

        private void btnVolgende_Click(object sender, EventArgs e)
        {            
            cmbActiviteit.Enabled = true;
            btnBevestigen.Enabled = true;
        }

        private void btnBevestigen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("U bent geregistreed in het systeem!", "Voltooid", MessageBoxButtons.OKCancel);
            Close();
        }
    }
}
