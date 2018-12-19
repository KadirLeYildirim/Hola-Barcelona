using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.VisualBasic;

namespace Barcalona
{
    public partial class Gebruiker : Form
    {
        public Gebruiker()
        {
            InitializeComponent();
        }

        string ConnectionString = "server=ID191774_6itngip8.db.webhosting.be; userid=ID191774_6itngip8; password=dtrerQwJ1; databse=mydb";

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Gebruiker_Load(object sender, EventArgs e)
        {
            cmbKlas.Items.Add(Convert.ToString("6ITN"));
            cmbKlas.Items.Add(Convert.ToString("6MO1"));
            cmbKlas.Items.Add(Convert.ToString("6MO2"));
            cmbKlas.Items.Add(Convert.ToString("6AIT"));

            string strActiviteit;

            MySqlConnection Connect = new MySqlConnection();
            MySqlCommand Activiteiten = new MySqlCommand("select * from activiteit");

            Connect.Open();
            MySqlDataReader Activiteit = Activiteiten.ExecuteReader();

            while(Activiteit.Read())
            {
                cmbActiviteit.Items.Add("");
            }

            Connect.Close();
        }

        private void btnVolgende_Click(object sender, EventArgs e)
        {            
            cmbActiviteit.Enabled = true;
            btnBevestigen.Enabled = true;
        }

        private void btnBevestigen_Click(object sender, EventArgs e)
        {
            string strVoornaam;
            string strAchternaam;
            int intKlasNummer;
            string strGSMNummer;

            MySqlConnection Connect = new MySqlConnection();

            strVoornaam = txtVoor.Text;
            strAchternaam = txtAchter.Text;
            intKlasNummer = Convert.ToInt16(TxtNummer.Text);
            strGSMNummer = txtGSM.Text;

            MySqlCommand Toevoegen = new MySqlCommand("INSERT INTO ");

            MessageBox.Show("U bent geregistreed in het systeem!", "Voltooid", MessageBoxButtons.OKCancel);
            Close();
        }

        private void xd_Click(object sender, EventArgs e)
        {

        }
    }
}
