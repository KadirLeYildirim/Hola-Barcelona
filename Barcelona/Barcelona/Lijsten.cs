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
    public partial class Lijsten : Form
    {
        Business bus = new Business();

        public Lijsten()
        {
            InitializeComponent();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Administrator admin = new Administrator();
            admin.Show();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Lijsten_Load(object sender, EventArgs e)
        {
            foreach (string lijn in bus.getNaamActiviteiten())
            {
                cmbActiviteiten.Items.Add(lijn);
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            lstLijst.Items.Clear();
            lstBegleider.Items.Clear();
            foreach (string lijn in bus.getWantedLeerlingen(cmbActiviteiten.SelectedItem.ToString()))
            {
                lstLijst.Items.Add(lijn);
            }
            foreach (string lijn in bus.getWantedBegeleiders(cmbActiviteiten.SelectedItem.ToString()))
            {
                lstBegleider.Items.Add(lijn);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
