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
    public partial class FHeader : Form
    {
        SqlConnection con = new SqlConnection("Data Source = LAPTOP-EB9PTRRD;Initial Catalog = latihan;Integrated Security=True;");
        SqlCommand cmd;

        public static string id;
        public static string memberId;
        public FHeader()
        {
            InitializeComponent();
            display();
            generateId();
        }

        public void generateId()
        {
            string urut;
            cmd = new SqlCommand("SELECT id FROM OrderHeader WHERE id in(SELECT MAX(id) FROM OrderHeader) ORDER BY id DESC", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            if(dt.Rows.Count > 0)
            {
                if(dt.Rows[0]["id"].ToString().Substring(0,8) != DateTime.Now.ToString("yyyyMMdd"))
                {
                    urut = DateTime.Now.ToString("yyyyMMdd");
                }
                else
                {
                    urut = Convert.ToString(Convert.ToInt64(dt.Rows[0]["id"].ToString()) + 1);
                }
            }
            else
            {
                urut = DateTime.Now.ToString("yyyyMMdd") + "0001";
            }

            id = urut;
        } 
        public void display()
        {
            cmd = new SqlCommand("SELECT * FROM MsMember",con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            dgv.DataSource = dt;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Hide();
            FAdmin newpage = new FAdmin();
            newpage.Show();
        }

        private void dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtNamaPembeli.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            memberId = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand($"SELECT * FROM MsMember WHERE concat(id,name,email,handphone,joindate) LIKE '%{txtSeacrh.Text}%'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            dgv.DataSource = dt;
        }

        private void btnPilih_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand($"INSERT INTO OrderHeader(id,memberId,date) VALUES('{id}','{memberId}',CURRENT_TIMESTAMP)", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            this.Hide();
            FOrder newpage = new FOrder();
            newpage.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FAdmin newpage = new FAdmin();
            newpage.Show();
        }
    }
}
