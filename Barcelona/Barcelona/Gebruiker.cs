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
    public partial class Gebruiker : Form
    {
		Business bus = new Business();

		public Gebruiker()
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
            btnVolgende.PerformClick();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

		private void btnVolgende_Click(object sender, EventArgs e)
		{
            cmbKeuze.Items.Clear();
            lblDatum.Text = bus.getDatumKeuzeActiviteiten(lblDatum.Text);
            foreach (string item in bus.getKeuzeActiviteiten(lblDatum.Text))
            {
                cmbKeuze.Items.Add(item);
            }
            cmbAlleKeuzes.Items.Add(cmbKeuze.SelectedItem);

        }

		private void btnRegistreer_Click(object sender, EventArgs e)
		{
            List<string> keuzeActiviteiten = new List<string>();
			bus.addLeerling(txtVoornaam.Text, txtAchternaam.Text, txtGsmNummer.Text, Convert.ToString(cmbKlas.SelectedItem));
            bus.AddAutoActiviteitLeerlingConnectie(txtVoornaam.Text,txtAchternaam.Text);
            cmbAlleKeuzes.Items.Add(cmbKeuze.SelectedItem);
            foreach(string item in cmbAlleKeuzes.ToString())
            bus.addKeuzeActivteitLeerlingConnectie(keuzeActiviteiten, txtVoornaam.Text, txtAchternaam.Text);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }

	//test
}
