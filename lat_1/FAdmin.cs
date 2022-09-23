using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lat_1
{
    public partial class FAdmin : Form
    {
        SqlConnection con = new SqlConnection("Data Source = LAPTOP-EB9PTRRD;Initial Catalog = latihan;Integrated Security=True;");
        SqlCommand cmd;
        public FAdmin()
        {
            InitializeComponent();
            displayName();
        }

        public void displayName()
        {
            lblWelcome.Text = $"Welcome, {Form1.name}";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 newpage = new Form1();
            newpage.Show();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            this.Hide();
            FMember newpage = new FMember();
            newpage.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            FMenu newpage = new FMenu();
            newpage.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            FHeader newpage = new FHeader();
            newpage.Show();
        }
    }
}
