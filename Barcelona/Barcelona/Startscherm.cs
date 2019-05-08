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

        }

        private void btnAdministrator_Click(object sender, EventArgs e)
        {
            Administrator admin = new Administrator();
            admin.Show();
            
        }
    }
}
