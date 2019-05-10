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
                if (bus.getDatumKeuzeActiviteiten(lblDatum.Text)== "1/01/0001  - ")
                {
                    lblDatum.Text = "Dat was alles";
                }
                else
                {

                    lblDatum.Text = bus.getDatumKeuzeActiviteiten(lblDatum.Text);                   
                    cmbKeuze.Items.Clear();
                    foreach (string item in bus.getKeuzeActiviteiten(lblDatum.Text))
                    {
                        cmbKeuze.Items.Add(item);
                    }
                }
                if (lblDatum.Text != "Dat was alles")
                {
                    if (lblDatum.Text != "_" || lblDatum.Text != "1/01/0001  - ")
                    {
                        lstOudeDatums.Items.Add(lblDatum.Text);
                    }
                    else { }
                }
                else { }
                if (cmbKeuze.Text == "")
                {
                    MessageBox.Show("U bent uw keuze vergeten ingeven", "Opgelet", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btnVorige.PerformClick();
                }
                else
                {
                    lstAlleKeuzeActiviteiten.Items.Add(cmbKeuze.Text);
                    cmbKeuze.SelectedText = "";
                    cmbKeuze.Text = "";
                }

            }



        }
        private static int intteller = 0;
		private void btnRegistreer_Click(object sender, EventArgs e)
		{

            if (txtVoornaam.Text != "" || txtAchternaam.Text != "" || txtGsmNummer.Text != ""|| cmbKlas.Text == "")
            {
                int intLaatste = lstAlleKeuzeActiviteiten.Items.Count - 1;
                if (cmbKeuze.Text != lstAlleKeuzeActiviteiten.Items[intLaatste].ToString())
                {
                    lstAlleKeuzeActiviteiten.Items.Add(cmbKeuze.Text);
                }
                else { }
                List<string> keuzeActiviteiten = new List<string>();
                bus.addLeerling(txtVoornaam.Text, txtAchternaam.Text, txtGsmNummer.Text, Convert.ToString(cmbKlas.Text));
                bus.AddAutoActiviteitLeerlingConnectie(txtVoornaam.Text, txtAchternaam.Text);
                foreach (string item in lstAlleKeuzeActiviteiten.Items)
                {
                    keuzeActiviteiten.Add(item);
                }
                bus.addKeuzeActivteitLeerlingConnectie(keuzeActiviteiten, txtVoornaam.Text, txtAchternaam.Text);
                lstAlleKeuzeActiviteiten.Items.Clear();
                lstOudeDatums.Items.Clear();
                txtGsmNummer.Text = "";
                txtVoornaam.Text = "";
                txtAchternaam.Text = "";
                cmbKlas.Text = "";
                lblDatum.Text = "_";
                btnVolgende.PerformClick();

            }
            else
            {
                if (intteller == 0)
                {
                    intteller++;
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
            if (lstOudeDatums.Items.Count > 1)
            {
                lstOudeDatums.Items.RemoveAt(lstOudeDatums.Items.Count - 1);
            }
            else { }

            if (lstAlleKeuzeActiviteiten.Items.Count > 0)
            {
                lstAlleKeuzeActiviteiten.Items.RemoveAt(lstOudeDatums.Items.Count - 1);
            }
            else { }
            cmbKeuze.Text = "";
            cmbKeuze.Items.Clear();
            lblDatum.Text = lstOudeDatums.Items[lstOudeDatums.Items.Count - 1].ToString();
            foreach (string item in bus.getKeuzeActiviteiten(lblDatum.Text))
            {
                cmbKeuze.Items.Add(item);
            }

        }

        private void pcbURL_Click(object sender, EventArgs e)
        {

        }
    }
}
