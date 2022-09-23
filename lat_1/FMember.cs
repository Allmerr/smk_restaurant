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
    public partial class FMember : Form
    {
        SqlConnection con = new SqlConnection("Data Source = LAPTOP-EB9PTRRD;Initial Catalog = latihan;Integrated Security=True;");
        SqlCommand cmd;
        public FMember()
        {
            InitializeComponent();
            display();
        }

        public void display()
        {
            cmd = new SqlCommand($"SELECT * FROM MsMember", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            dgv.DataSource = dt;

            btnInsert.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        public void clear()
        {
            txtMemberId.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtHandphone.Clear();
            txtSeacrh.Clear();

            display();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(txtName.Text != "" && txtEmail.Text != "" && txtHandphone.Text != "")
            {
                DateTime date = dtp.Value;
                cmd = new SqlCommand($"INSERT INTO MsMember(name,email,handphone,joindate) VALUES('{txtName.Text}', '{txtEmail.Text}', '{txtHandphone.Text}', '{date.Date.ToString("yyyy-MM-dd")}')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Berhasil Menambah Data!");
                clear();
            }
            else
            {
                MessageBox.Show("Data Diri Belum Lengkap!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FAdmin newpage = new FAdmin();
            newpage.Show();
        }

        private void dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMemberId.Text = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEmail.Text = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtHandphone.Text = dgv.Rows[e.RowIndex].Cells[3].Value.ToString();

            btnInsert.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtEmail.Text != "" && txtHandphone.Text != "")
            {
                cmd = new SqlCommand($"UPDATE MsMember SET name = '{txtName.Text}', email = '{txtEmail.Text}', handphone = '{txtHandphone.Text}' WHERE id = '{txtMemberId.Text}'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Berhasil Mengupdate Data!");
                clear();
            }
            else
            {
                MessageBox.Show("Data Diri Belum Lengkap!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Yakin ??" , "KONFIRMASI" , MessageBoxButtons.YesNo , MessageBoxIcon.Question) == DialogResult.Yes){
                cmd = new SqlCommand($"DELETE FROM MsMember WHERE id = '{txtMemberId.Text}'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Berhasil Menghapus Data!");
                clear();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

                cmd = new SqlCommand($"SELECT * FROM MsMember WHERE CONCAT (id,name,email,handphone,joindate) LIKE '%{txtSeacrh.Text}%'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                dgv.DataSource = dt;

        }
    }
}
