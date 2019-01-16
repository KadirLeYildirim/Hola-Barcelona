using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barcelona
{
    public partial class VoegLeerlingToe : Form
    {
		Business bus = new Business();

		public VoegLeerlingToe()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Administrator admin = new Administrator();
            admin.Show();

            
        }

        private void VoegLeerlingToe_Load(object sender, EventArgs e)
        {
			vullen(cmbKeuze);
			string strdate = Convert.ToString(DateTime.Now);
			label5.Text += "   " + strdate;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

		public void vullen(ComboBox cmbKeuze)
		{
			cmbKeuze.Text = Convert.ToString(bus.getNaamActiviteiten());
		}

		private void btnVolgende_Click(object sender, EventArgs e)
		{
				button1.Show();
		}

		private void btnRegistreer_Click(object sender, EventArgs e)
		{
			bus.addLeerling(txtVoornaam.Text, txtAchternaam.Text, txtGsmNummer.Text, Convert.ToString(cmbKlas.SelectedItem));
		}
	}

	//test
}
