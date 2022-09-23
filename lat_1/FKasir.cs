using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lat_1
{
    public partial class FKasir : Form
    {
        public FKasir()
        {
            InitializeComponent();
            displayName();
        }

        public void displayName()
        {
            lblWelcome.Text = "Welcome , " + Form1.name;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 newpage = new Form1();
            newpage.Show();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            this.Hide();
            FPayment newpage = new FPayment();
            newpage.Show();
        }
    }
}
