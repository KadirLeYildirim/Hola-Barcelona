using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Barcelona
{
    public partial class ActiviteitAanpassen : Form
    {
        Business bus = new Business();
        public ActiviteitAanpassen()
        {
            InitializeComponent();
        }

        private void ActiviteitAanpassen_Load(object sender, EventArgs e)
        {
            foreach(string lijn in bus.getNaamActiviteiten())
            {
                lstActiviteiten.Items.Add(lijn);
            }
            foreach (string lijn in bus.getBegeleidersNamen())
            {
                clbBegeleiders.Items.Add(lijn);
            }
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstActiviteiten_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstActiviteiten.SelectedItem != null)
            {
                vulIN();
            }
            else { }
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            DialogResult Antwoord;
            
            Antwoord=MessageBox.Show("Bent u zeker dat u deze activiteit wilt verwijderen?", "Activiteit verwijderen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Antwoord == DialogResult.Yes)
            {
                bus.deleteActiviteit(txtNaam.Text);
                lstActiviteiten.Items.Clear();
                foreach (string lijn in bus.getNaamActiviteiten())
                {
                    lstActiviteiten.Items.Add(lijn);
                }
                txtNaam.Clear();
                txtDeelnemers.Clear();
                txtAantalPlaatsen.Clear();
                txtDatum.Clear();
                txtOmschrijving.Clear();
                txtPrijs.Clear();
                lstGekozenBegeleiders.Items.Clear();
                rdbNamiddag.Checked = false;
                rdbVoormiddag.Checked = false;
            }
            else { }

        }

        private void btnBevestigen_Click(object sender, EventArgs e)
        {
            string strUUR="";
            if (rdbNamiddag.Checked == true)
            {
                strUUR = "De namiddag";
            }
            if (rdbVoormiddag.Checked == true)
            {
                strUUR = "De voormiddag";
            }
            bus.updateActiviteit(lstActiviteiten.SelectedItem.ToString(), txtNaam.Text, txtOmschrijving.Text,
                Convert.ToDouble(txtPrijs.Text), Convert.ToInt32(txtAantalPlaatsen.Text),
                Convert.ToInt32(txtDeelnemers.Text), txtDatum.Text, strUUR);
            foreach (string lijn in bus.getNaamActiviteiten())
            {
                lstActiviteiten.Items.Add(lijn);
            }

            vulIN();
            lstActiviteiten.Items.Clear();
            foreach (string lijn in bus.getNaamActiviteiten())
            {
                lstActiviteiten.Items.Add(lijn);
            }
        }

        public void vulIN()
        {
            lstGekozenBegeleiders.Items.Clear();
            txtNaam.Text = bus.getWantedNaamActiviteiten(lstActiviteiten.SelectedItem.ToString());
            txtOmschrijving.Text = bus.getWantedOmschrijvingActiviteiten(lstActiviteiten.SelectedItem.ToString());
            txtAantalPlaatsen.Text = bus.getWantedPlaatsenActiviteiten(lstActiviteiten.SelectedItem.ToString());
            txtDeelnemers.Text = bus.getWantedDeelnemersActiviteiten(lstActiviteiten.SelectedItem.ToString());
            txtPrijs.Text = bus.getWantedKostprijsActiviteiten(lstActiviteiten.SelectedItem.ToString());
            txtDatum.Text = bus.getWantedDatumActiviteiten(lstActiviteiten.SelectedItem.ToString());
            if (bus.getWantedUUrActiviteiten(lstActiviteiten.SelectedItem.ToString()).ToLower() == "de voormiddag")
            {
                rdbVoormiddag.Select();
            }
            if (bus.getWantedUUrActiviteiten(lstActiviteiten.SelectedItem.ToString()).ToLower() == "de namiddag")
            {
                rdbNamiddag.Select();
            }
            foreach(string lijn in bus.getWantedBegeleiders(lstActiviteiten.SelectedItem.ToString()))
            {
                lstGekozenBegeleiders.Items.Add(lijn);
            }


        }

        private void lstGekozenBegeleiders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string item;
            for (int i = 0; i < clbBegeleiders.CheckedItems.Count; i++)
            {
                string strLetter = "", strNaam = "";
                item = clbBegeleiders.CheckedItems[i].ToString();
                for (int j = 0; j < item.Length; j++)
                {
                    strLetter = item.Substring(j, 1);
                    if (strLetter == " ")
                    {
                        j = item.Length;
                    }
                    strNaam += strLetter;
                }
                bus.connectActiviteitBegeleider(strNaam, txtNaam.Text);
            }
            lstGekozenBegeleiders.Items.Clear();
            foreach (string lijn in bus.getWantedBegeleiders(lstActiviteiten.SelectedItem.ToString()))
            {
                lstGekozenBegeleiders.Items.Add(lijn);
            }
        }

        private void btnVerwijderBegleider_Click(object sender, EventArgs e)
        {
            string strNaam = "", strLetter;
            for (int i = 0; i < lstGekozenBegeleiders.SelectedItem.ToString().Length; i++)
            {
                strLetter = lstGekozenBegeleiders.SelectedItem.ToString().Substring(i, 1);
                if (strLetter == " ")
                {
                    i = lstGekozenBegeleiders.SelectedItem.ToString().Length;
                }
                strNaam += strLetter;
            }
            bool blnAntwoord;
            blnAntwoord = Convert.ToBoolean(MessageBox.Show("Bent u zeker dat u deze begeleider wilt verwijderen?", "Begeleider verwijderen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (blnAntwoord == true)
            {
                bus.deleteActiviteitBegeleiderConnectie(strNaam, txtNaam.Text);
                lstGekozenBegeleiders.Items.Clear();
                foreach (string lijn in bus.getWantedBegeleiders(txtNaam.Text))
                {
                    lstGekozenBegeleiders.Items.Add(lijn);
                }

            } else { }
        }

        private void ActiviteitAanpassen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Administrator admin = new Administrator();
            admin.Show();
        }
    }
}
