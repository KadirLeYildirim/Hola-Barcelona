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
            //vulIN();
            foreach (string lijn in bus.getWantedBegeleiders(comboBox1.SelectedItem.ToString()))
            {
                listBox1.Items.Add(lijn);
            }   
        }

        //public void vulIN()
        //{
        //    foreach (string lijn in bus.getWantedBegeleiders(comboBox1.SelectedItem.ToString()))
        //    {
        //        listBox1.Items.Add(lijn);
        //    }
        //}

        private void Lijsten_Load(object sender, EventArgs e)
        {
            foreach (string lijn in bus.getNaamActiviteiten())
            {
                comboBox1.Items.Add(lijn);
            }
        }
    }
}
