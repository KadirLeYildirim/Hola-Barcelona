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
    public partial class BegeleiderAanpassen : Form
    {
        Business bus = new Business();
        public BegeleiderAanpassen()
        {
            InitializeComponent();
        }

        private void BegeleiderAanpassen_Load(object sender, EventArgs e)
        {
            foreach(string lijn in bus.getBegeleidersNamen())
            {
                lstBegeleiders.Items.Add(lijn);
            }
        }

        private void lstBegeleiders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBegeleiders.SelectedItem != null)
            {
                VulIN();
            }
            else
            {

            }
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            Administrator admin = new Administrator();
            admin.Show();
            this.Close();
        }

        private void btnAanpassen_Click(object sender, EventArgs e)
        {
            if (lstBegeleiders.SelectedItem != null)
            {
                string strNaam = "", strLetter;
                for (int i = 0; i < lstBegeleiders.SelectedItem.ToString().Length; i++)
                {
                    strLetter = lstBegeleiders.SelectedItem.ToString().Substring(i, 1);
                    if (strLetter == " ")
                    {
                        i = lstBegeleiders.SelectedItem.ToString().Length;
                    }
                    strNaam += strLetter;
                }
                bus.updateBegeleider(strNaam, txtVoornaam.Text, txtAchternaam.Text, txtGsmNummer.Text);
                lstBegeleiders.Items.Clear();
                foreach (string lijn in bus.getBegeleidersNamen())
                {
                    lstBegeleiders.Items.Add(lijn);
                }
            }
            else
            {
                MessageBox.Show("Eerst een begeleider kiezen", "opgelet", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            if (lstBegeleiders.SelectedItem != null)
            {
                string strNaam = "", strLetter;
                for (int i = 0; i < lstBegeleiders.SelectedItem.ToString().Length; i++)
                {
                    strLetter = lstBegeleiders.SelectedItem.ToString().Substring(i, 1);
                    if (strLetter == " ")
                    {
                        i = lstBegeleiders.SelectedItem.ToString().Length;
                    }
                    strNaam += strLetter;
                }
                DialogResult Antwoord;
                Antwoord = MessageBox.Show("Bent u zeker dat u deze begeleider wilt verwijderen?", "Begeleider verwijderen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Antwoord == DialogResult.Yes)
                {
                    bus.deleteBegeleider(strNaam);
                    lstBegeleiders.Items.Clear();
                    foreach (string lijn in bus.getBegeleidersNamen())
                    {
                        lstBegeleiders.Items.Add(lijn);
                    }
                    txtAchternaam.Clear();
                    txtGsmNummer.Clear();
                    txtVoornaam.Clear();
                }
                else { }
            }
            else
            {
                MessageBox.Show("Eerst een begeleider kiezen", "opgelet", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void VulIN()
        {
            string strNaam = "", strLetter;
            for (int i = 0; i < lstBegeleiders.SelectedItem.ToString().Length; i++)
            {
                strLetter = lstBegeleiders.SelectedItem.ToString().Substring(i, 1);
                if (strLetter == " ")
                {
                    i = lstBegeleiders.SelectedItem.ToString().Length;
                }
                strNaam += strLetter;
            }
            txtVoornaam.Text = bus.getWantedBegeleiderVoornaam(strNaam);
            txtAchternaam.Text = bus.getWantedBegeleiderAchternaam(strNaam);
            txtGsmNummer.Text = bus.getWantedBegeleiderGsmNummer(strNaam);
        }
    }
}
