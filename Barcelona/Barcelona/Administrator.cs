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
            toonBegeleiders();
            toonActiviteiten();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnVoegLeerkrachtToe_Click(object sender, EventArgs e)
        {
            //Dit opend een begeleider form om een nieuwe begeleider toe te voegen
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
            //Voegt een activiteit toe
            if(txtAantalPlaatsen.Text==""|| txtNaam.Text == "" || txtOmschrijving.Text == "" || txtPrijs.Text == "" ||(rdbNamiddag.Checked==false && rdbVoormiddag.Checked == false))
            {
                MessageBox.Show("U bent een veld vergeten invullen", "Opgelet", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                string strUur = "_";
                if (rdbNamiddag.Checked == true)
                {
                    strUur = "De namiddag";
                }
                if (rdbVoormiddag.Checked == true)
                {
                    strUur = "De voormiddag";
                }
                bus.addActiviteit(txtNaam.Text, txtOmschrijving.Text, Convert.ToDouble(txtPrijs.Text),
        Convert.ToInt32(txtAantalPlaatsen.Text), mclDag.SelectionStart, strUur);
                //Dit connecteerd een activiteit en de gekozen begeleider
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
                makeEmpty();

                toonActiviteiten();
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
            foreach (string lijn in bus.getBegeleidersNamen())
            {
                clbBegeleiders.Items.Add(lijn);
            }
        }
        public void toonActiviteiten()
        {
            txtActiviteiten.Clear();
            foreach(string lijn in bus.getActiviteiten())
            {
                txtActiviteiten.Text+=lijn+Environment.NewLine;
            }

        }
        public void toonBegeleiders()
        {
            clbBegeleiders.Items.Clear();
            foreach (string lijn in bus.getBegeleidersNamen())
            {
                clbBegeleiders.Items.Add(lijn);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ActiviteitAanpassen form = new ActiviteitAanpassen();
            form.Show();
            this.Close();
        }

        private void btnBegeleiderAanpassen_Click(object sender, EventArgs e)
        {
            BegeleiderAanpassen begaanpassen = new BegeleiderAanpassen();
            begaanpassen.Show();
            this.Close();
        }

        private void btnLijsten_Click(object sender, EventArgs e)
        {
            Lijsten lijsten = new Lijsten();
            lijsten.Show();
            this.Close();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            frmStartscherm startscherm = new frmStartscherm();
            startscherm.Show();
            this.Close();
        }
    }
}
