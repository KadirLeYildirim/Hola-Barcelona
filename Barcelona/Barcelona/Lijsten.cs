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
            vulIN();
        }
        public void vulIN()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add(bus.getNaamActiviteiten());

        }
    }
}
