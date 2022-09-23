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
    public partial class FDaftar : Form
    {
        SqlConnection con = new SqlConnection("Data Source = LAPTOP-EB9PTRRD;Initial Catalog = latihan;Integrated Security=True;");
        SqlCommand cmd;
        public FDaftar()
        {
            InitializeComponent();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 newpage = new Form1();
            newpage.Show();
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text != "" && txtEmail.Text != "" && txtPassword.Text != "" && cmbPosition.Text != "")
            {
                cmd = new SqlCommand($"INSERT INTO MsEmploye(name,email,password,position) VALUES('{txtUsername.Text}', '{txtEmail.Text}', '{txtPassword.Text}', '{cmbPosition.Text}')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Berhasil Mendaftar!");
            }
            else
            {
                MessageBox.Show("Data diri belum lengkap!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }
    }
}
