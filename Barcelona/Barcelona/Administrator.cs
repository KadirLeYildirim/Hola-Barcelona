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
    public partial class Administrator : Form
    {
        Business bus = new Business();
        public Administrator()
        {
            InitializeComponent();
        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            clbBegeleiders.Items.Clear();
            foreach (string lijn in bus.getBegeleiders2())
            {
                clbBegeleiders.Items.Add(lijn);
            }
            dgvKalender.Columns.Clear();
            dgvKalender.Rows.Clear();
            foreach(string lijn in bus.getDatumActiviteiten())
            {
                dgvKalender.Columns.Add("",lijn);
            }
            foreach(string lijn in bus.getActiviteitenZonderTijd())
            {
                dgvKalender.Rows.Add(lijn);
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnVoegLeerkrachtToe_Click(object sender, EventArgs e)
        {
            VoegBegeleiderToe Leerkracht = new VoegBegeleiderToe();
            Leerkracht.Show();
            this.Close();
            clbBegeleiders.Items.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVoegActiviteitToe_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strUur = "_";
            if (rdbNamiddag.Checked == true)
            {
                strUur = "De namiddag";
            }
            if (rdbVoormiddag.Checked == true)
            {
                strUur="De voormiddag";
            }
            bus.addActiviteit(txtNaam.Text, txtOmschrijving.Text, Convert.ToDouble(txtPrijs.Text),
    Convert.ToInt32(txtAantalPlaatsen.Text), mclDag.SelectionStart, strUur);
            foreach (string item in clbBegeleiders.SelectedItems)
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
            makeEmpty();

            dgvKalender.Columns.Clear();
            dgvKalender.Rows.Clear();
            foreach (string lijn in bus.getDatumActiviteiten())
            {
                dgvKalender.Columns.Add("", lijn);
            }
            foreach (string lijn in bus.getActiviteitenZonderTijd())
            {
                dgvKalender.Rows.Add(lijn);
            }
        }

        private void clbBegeleiders_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnOverzetten_Click(object sender, EventArgs e)
        {


        }

        private void mclDag_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        public void makeEmpty()
        {
            txtNaam.Text = "";
            txtAantalPlaatsen.Text = "";
            txtPrijs.Text = "";
            txtOmschrijving.Text = "";
            rdbVoormiddag.Checked = false;
            rdbVoormiddag.Checked = false;
            mclDag.ShowToday = true;
            clbBegeleiders.Items.Clear();
            foreach (string lijn in bus.getBegeleiders2())
            {
                clbBegeleiders.Items.Add(lijn);
            }
        }


    }
}
