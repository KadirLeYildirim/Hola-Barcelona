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
        }

        private void lstActiviteiten_SelectedIndexChanged(object sender, EventArgs e)
        {
            vulIN();            
        }

        public void vulIN()
        {
            clbBegeleiders.Items.Clear();
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
                clbBegeleiders.Items.Add(lijn);
            }

        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Bent u zeker dat u deze activiteit wilt verwijderen?", "Activiteit verwijderen", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
        }
    }
}
