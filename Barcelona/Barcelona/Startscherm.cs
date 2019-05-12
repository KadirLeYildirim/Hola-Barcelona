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
    public partial class frmStartscherm : Form 
    {
        public frmStartscherm()
        {
            InitializeComponent();
        }

        private void btnGebruiker_Click(object sender, EventArgs e)
        {
            Gebruiker gebruiker = new Gebruiker();
            gebruiker.Show();
            this.Close();
        }

        private void btnAdministrator_Click(object sender, EventArgs e)
        {
            string strAntwoord;
            strAntwoord=Interaction.InputBox("Geef het wachtwoord in", "Wachtwoord", "");
            if (strAntwoord == "OGSint-Joris")
            {
                Administrator admin = new Administrator();
                admin.Show();
                this.Close();
            }
            else
            {
                if (strAntwoord == "")
                {
                    MessageBox.Show("U moet wel een iets ingeven", "Geen wachtwoord!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("U heeft het verkeerd wachtwoord ingegeven", "Verkeerd wachtwoord!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }

        private void frmStartscherm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void frmStartscherm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
                Application.Exit();
        }

        private void frmStartscherm_Load(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Transparent;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
