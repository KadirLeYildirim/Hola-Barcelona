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

        public List<string> lstDatums = new List<string>();
        public List<string> lstKeuzes = new List<string>();
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
            //vult de de datums in een lijst en weergeeft dan de eerste
            foreach (string lijn in bus.getDatumsKeuzeActiviteiten())
            {
                lstDatums.Add(lijn);
            }
            lblDatum.Text = lstDatums[0];
            lblGetal.Text = "Keuze 1 van de " + lstDatums.Count;
            foreach (string lijn in bus.getKeuzeActiviteiten(lblDatum.Text))
            {
                cmbKeuze.Items.Add(lijn);
            }
        }

        private void btnVolgende_Click(object sender, EventArgs e)
		{
            if (cmbKeuze.Text == ""|| lblDatum.Text == lstDatums[lstDatums.Count-1])
            {
                if(lblDatum.Text == lstDatums[lstDatums.Count - 1])
                {
                    if (lstDatums.Count == lstKeuzes.Count)
                    {
                        cmbKeuze.Text = "";
                        cmbKeuze.Items.Clear();
                    }
                    else
                    {
                        lstKeuzes.Add(cmbKeuze.Text);
                        txtOmschrijving.Text = "";
                        pcbURL.InitialImage = null;
                        cmbKeuze.Text = "";
                        cmbKeuze.Items.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("U moet eerst een keuze maken", "Opgelet", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                if (lstKeuzes.Count == lstDatums.Count)
                {
                    lblDatum.Text = "Dat was alles";
                }
                else
                {
                    //zet de vorige keuze in de lijst
                    lstKeuzes.Add(cmbKeuze.Text);
                    //verwijdert vorige keuzes in cmb
                    cmbKeuze.Text = "";
                    cmbKeuze.Items.Clear();
                    //verandert datum en keuzes
                    if (lstKeuzes.Count == lstDatums.Count)
                    {
                        lblDatum.Text = lstDatums[lstKeuzes.Count - 1];
                    }
                    else
                    {
                        lblDatum.Text = lstDatums[lstKeuzes.Count];

                    }
                    int intTeller = 1;
                    foreach (string datum in lstDatums)
                    {
                        if (datum == lblDatum.Text)
                        {
                            lblGetal.Text = "Keuze " + intTeller + " van de " + lstDatums.Count;
                        }
                        else
                        {
                            intTeller++;
                        }
                    } 
                    foreach (string lijn in bus.getKeuzeActiviteiten(lblDatum.Text))
                    {
                        cmbKeuze.Items.Add(lijn);
                    }
                    txtOmschrijving.Text = "";
                    pcbURL.InitialImage = null;
                }
            }            

        }

        private void btnVorige_Click(object sender, EventArgs e)
        {
            if (lstKeuzes.Count == 0)
            {

            }
            else
            {
                lblDatum.Text = lstDatums[lstKeuzes.Count - 1];
                lstKeuzes.RemoveAt(lstKeuzes.Count - 1);
                cmbKeuze.Text = "";
                cmbKeuze.Items.Clear();
                foreach (string lijn in bus.getKeuzeActiviteiten(lblDatum.Text))
                {
                    cmbKeuze.Items.Add(lijn);
                }
                txtOmschrijving.Text = "";
                pcbURL.InitialImage = null;
                int intTeller =1;
                foreach (string datum in lstDatums)
                {
                    if (datum == lblDatum.Text)
                    {
                        lblGetal.Text = "Keuze " + intTeller + " van de " + lstDatums.Count;
                    }
                    else
                    {
                        intTeller++;
                    }
                }
            }

        }

        private void btnRegistreer_Click(object sender, EventArgs e)
		{
            if (lstKeuzes.Count < lstDatums.Count-1)
            {
                MessageBox.Show("U moet eerst uw keuzes ingeven", "Opgelet", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                if (txtVoornaam.Text != "" || txtAchternaam.Text != "" || txtGsmNummer.Text != "" || cmbKlas.Text != "")
                {
                    if (lstDatums.Count() != lstKeuzes.Count() && cmbKeuze.Text != "")
                    {
                        lstKeuzes.Add(cmbKeuze.Text);
                        bus.addLeerling(txtVoornaam.Text, txtAchternaam.Text, txtGsmNummer.Text, Convert.ToString(cmbKlas.Text));
                        bus.AddAutoActiviteitenLeerlingConnectie(txtVoornaam.Text, txtAchternaam.Text);
                        bus.addKeuzeActivteitenLeerlingConnectie(lstKeuzes, txtVoornaam.Text, txtAchternaam.Text);
                        lstKeuzes.Clear();
                        txtGsmNummer.Text = "";
                        txtVoornaam.Text = "";
                        txtAchternaam.Text = "";
                        cmbKlas.Text = "";
                        lblDatum.Text = lstDatums[0];
                        cmbKeuze.Text = "";
                        foreach (string lijn in bus.getKeuzeActiviteiten(lblDatum.Text))
                        {
                            cmbKeuze.Items.Add(lijn);
                        }
                        lblGetal.Text = "Keuze 1 van de " + lstDatums.Count;
                        txtOmschrijving.Text = "";
                        pcbURL.InitialImage = null;
                    }
                    else
                    {
                        if (lstDatums.Count == lstKeuzes.Count)
                        {
                            bus.addLeerling(txtVoornaam.Text, txtAchternaam.Text, txtGsmNummer.Text, Convert.ToString(cmbKlas.Text));
                            bus.AddAutoActiviteitenLeerlingConnectie(txtVoornaam.Text, txtAchternaam.Text);
                            bus.addKeuzeActivteitenLeerlingConnectie(lstKeuzes, txtVoornaam.Text, txtAchternaam.Text);
                            lstKeuzes.Clear();
                            txtGsmNummer.Text = "";
                            txtVoornaam.Text = "";
                            txtAchternaam.Text = "";
                            cmbKlas.Text = "";
                            lblDatum.Text = lstDatums[0];
                            cmbKeuze.Text = "";
                            foreach (string lijn in bus.getKeuzeActiviteiten(lblDatum.Text))
                            {
                                cmbKeuze.Items.Add(lijn);
                            }
                            lblGetal.Text = "Keuze 1 van de " + lstDatums.Count;
                            txtOmschrijving.Text = "";
                            pcbURL.InitialImage = null;
                        }
                        else
                        {
                            MessageBox.Show("U moet eerst een keuze maken", "Opgelet", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("U bent een veld vergeten invullen", "Opgelet", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }

        }

        private void Gebruiker_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmStartscherm startscherm = new frmStartscherm();
            startscherm.Show();
        }

        private void test_Click(object sender, EventArgs e)
        {

        }

        private void cmbKeuze_TextChanged(object sender, EventArgs e)
        {
            if (cmbKeuze.Text != "")
            {
                if(""== bus.getWantedFotoActiviteiten(cmbKeuze.Text))
                {
                    pcbURL.Image = Properties.Resources.GeenFoto2;
                }
                else
                {
                    pcbURL.ImageLocation = bus.getWantedFotoActiviteiten(cmbKeuze.Text);
                }
                txtOmschrijving.Text = bus.getWantedOmschrijvingPlaatsenActiviteiten(cmbKeuze.Text);
            }
            else
            {

            }
            foreach (string item in cmbKeuze.Items)
            {
                if (cmbKeuze.Text != item)
                {
                    cmbKeuze.Text = "";
                }
                else
                {

                }
            }
        }

        private void cmbKlas_TextChanged(object sender, EventArgs e)
        {
            foreach (string item in cmbKlas.Items)
            {
                if (cmbKlas.Text != item)
                {
                    cmbKlas.Text = "";
                }
                else
                {

                }
            }
        }

        private void lblDatum_TextChanged(object sender, EventArgs e)
        {
        }

        private void cmbKeuze_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
