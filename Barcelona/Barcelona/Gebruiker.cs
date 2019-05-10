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
            this.Close();
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
            if (lblDatum.Text== "1/01/0001  - " || lblDatum.Text== "Dat was alles")
            {
                lblDatum.Text = "Dat was alles";
                cmbKeuze.Items.Clear();
                cmbKeuze.SelectedItem = "";
            }
            else
            {
                cmbKeuze.Items.Clear();
                foreach (string item in bus.getKeuzeActiviteiten(lblDatum.Text))
                {
                cmbKeuze.Items.Add(item);
                }
                if (lblDatum.Text != "_")
                {
                    lstOudeDatums.Items.Add(lblDatum.Text);
                }
                else { }
                lblDatum.Text = bus.getDatumKeuzeActiviteiten(lblDatum.Text);

                if (cmbKeuze.SelectedItem != null)
                {
                    lstAlleKeuzeActiviteiten.Items.Add(cmbKeuze.SelectedItem.ToString());
                    cmbKeuze.Items.Clear();
                    cmbKeuze.SelectedText = "";
                }
                else { }
            }



        }

		private void btnRegistreer_Click(object sender, EventArgs e)
		{
            if (cmbKlas.SelectedItem == null)
            {
                MessageBox.Show("U bent een veld vergeten invullen", "Opgelet", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (txtVoornaam.Text != "" || strnaam.Text != "" || txtGsmNummer.Text != "")
                {
                    if (lstAlleKeuzeActiviteiten.Items.Count >= 1)
                    {
                        List<string> keuzeActiviteiten = new List<string>();
                        bus.addLeerling(txtVoornaam.Text, strnaam.Text, txtGsmNummer.Text, Convert.ToString(cmbKlas.SelectedItem));
                        bus.AddAutoActiviteitLeerlingConnectie(txtVoornaam.Text, strnaam.Text);
                        if (cmbKeuze.SelectedItem != null)
                        {
                            lstAlleKeuzeActiviteiten.Items.Add(cmbKeuze.SelectedItem.ToString());
                        }
                        else { }
                        if (lstAlleKeuzeActiviteiten.Items.Count > 1)
                        {
                            foreach (string item in lstAlleKeuzeActiviteiten.Items)
                            {
                                keuzeActiviteiten.Add(item);
                            }
                            bus.addKeuzeActivteitLeerlingConnectie(keuzeActiviteiten, txtVoornaam.Text, strnaam.Text);
                        }
                        else { }
                    }
                    else
                    {
                        MessageBox.Show("U bent uw keuzes vergeten ingeven", "Opgelet", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("U bent een veld vergeten invullen", "Opgelet", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Gebruiker_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmStartscherm startscherm = new frmStartscherm();
            startscherm.Show();
        }

        private void cmbKeuze_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKeuze.SelectedItem != null)
            {
                pcbURL.ImageLocation = bus.getWantedFotoActiviteiten(cmbKeuze.SelectedItem.ToString());
            }
            else
            {

            }
        }

        private void test_Click(object sender, EventArgs e)
        {

        }

        private void lstOudeDatums_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVorige_Click(object sender, EventArgs e)
        {

        }
    }
}
