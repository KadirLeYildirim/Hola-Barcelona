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
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            this.Close();
            Administrator admin = new Administrator();
            admin.Show();
        }

        private void lstActiviteiten_SelectedIndexChanged(object sender, EventArgs e)
        {
            vulIN();            
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            bool blnAntwoord;
            string ant;
            MessageBox.Show("Bent u zeker dat u deze activiteit wilt verwijderen?", "Activiteit verwijderen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
            //Verwijderd eerst alle gekozen begeleiders(Zeer belangerijk NIET AANRAKEN)
            foreach (string item in lstGekozenBegeleiders.Items)
            {
                string strLetter = "", strNaam = "";
                for (int i = 0; i < item.Length; i++)
                {
                    strLetter = item.Substring(i, 1);
                    if (strLetter == " ")
                    {
                        i = item.Length;
                    }
                    strNaam += strLetter;
                }
                bus.deleteActiviteitBegeleiderConnectie(strNaam, txtNaam.Text);
            }
            //Helpt met begeleiders te verbinden
            int intJa=0;
            foreach(string item in clbBegeleiders.SelectedItems)
            {
                foreach(string item2 in lstGekozenBegeleiders.Items)
                {
                    if (item == item2)
                    {
                        intJa++;
                    }    
                }
                if (intJa == 0)
                {
                    lstGekozenBegeleiders.Items.Add(item);
                }
            }
            //Verbind gekozen begeleiders
            foreach (string item in lstGekozenBegeleiders.Items)
            {
                string strLetter = "", strNaam = "";
                for (int i = 0; i < item.Length; i++)
                {
                    strLetter = item.Substring(i, 1);
                    if (strLetter == " ")
                    {
                        i = item.Length;
                    }
                    strNaam += strLetter;
                }
                bus.connectActiviteitBegeleider(strNaam, txtNaam.Text);
            }
            vulIN();
        }

        public void vulIN()
        {
            clbBegeleiders.Items.Clear();
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
            foreach (string lijn in bus.getBegeleidersNamen())
            {
                clbBegeleiders.Items.Add(lijn);
            }

        }

        private void lstGekozenBegeleiders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
