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
    public partial class VoegBegeleiderToe : Form
    {
        Business bus = new Business();
        public VoegBegeleiderToe()
        {
            InitializeComponent();
        }

        private void VoegLeerkrachtToe_Load(object sender, EventArgs e)
        {
            lstBegeleiders.Items.Clear();
            foreach(string lijn in bus.getBegeleiders())
            {
                lstBegeleiders.Items.Add(lijn);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bus.addBegeleider(txtVoornaam.Text, txtAchternaam.Text, txtGsmNummer.Text);
            lstBegeleiders.Items.Clear();
            foreach (string lijn in bus.getBegeleiders())
            {
                lstBegeleiders.Items.Add(lijn);
            }
           
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            Administrator admin = new Administrator();
            admin.Show();
            this.Close();
        }

        private void lstBegeleiders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
