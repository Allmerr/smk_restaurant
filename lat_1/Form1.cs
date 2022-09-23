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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source = LAPTOP-EB9PTRRD;Initial Catalog = latihan;Integrated Security=True;");
        SqlCommand cmd;

        public static string name;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand($"SELECT * FROM MsEmploye WHERE name = '{txtUsername.Text}' AND password = '{txtPassword.Text}'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            if(dt.Rows.Count > 0)
            {
                switch (dt.Rows[0]["position"] as string)
                {
                    case "admin":
                        name = Convert.ToString(dt.Rows[0]["name"]);
                        MessageBox.Show("Berhasil Login!");
                        this.Hide();
                        FAdmin newpageAdmin = new FAdmin();
                        newpageAdmin.Show();
                        break;
                    case "kasir":
                        name = Convert.ToString(dt.Rows[0]["name"]);
                        MessageBox.Show("Berhasil Login!");
                        this.Hide();
                        FKasir newpageKasir = new FKasir();
                        newpageKasir.Show();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Password atau Username Salah!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FDaftar newpage = new FDaftar();
            newpage.Show();
        }
    }
}
