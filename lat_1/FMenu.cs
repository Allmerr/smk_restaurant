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
    public partial class FMenu : Form
    {
        SqlConnection con = new SqlConnection("Data Source = LAPTOP-EB9PTRRD;Initial Catalog = latihan;Integrated Security=True;");
        SqlCommand cmd;
        public FMenu()
        {
            InitializeComponent();
            display();
        }

        public void clear()
        {
            txtMenuId.Clear();
            txtName.Clear();
            txtPrice.Clear();
            txtPhoto.Clear();
            txtCarbo.Clear();
            txtProtein.Clear();
            txtSeacrh.Clear();

            pb.Image = null;

            display();
        }
        public void display()
        {
            cmd = new SqlCommand($"SELECT * FROM MsMenu", con);
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
        private void txtSeacrh_TextChanged(object sender, EventArgs e)
        {

        }

        private void FMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FAdmin newpage = new FAdmin();
            newpage.Show();
        }

        private void btnPhotoDetail_Click(object sender, EventArgs e)
        {
            pb.Image = null;
            ofd.Filter = "JPG FILES (*.jpg)|*jpg|PNG FILES (*.png)|*png";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                pb.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            txtPhoto.Text = @"C:\lks" + txtName.Text;
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(txtName.Text != "" && txtPrice.Text != "")
            {


                string folder = @"C:\lks";
                string fname = txtName.Text + ".jpg";
                string path = System.IO.Path.Combine(folder,fname);

                Image img = pb.Image;
                img.Save(path);

                cmd = new SqlCommand($"INSERT INTO MsMenu(name,price,photo,carbo,protein) VALUES('{txtName.Text}', '{txtPrice.Text}', '{path}', '{txtCarbo.Text}', '{txtProtein.Text}')",con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Berhasil Menambah Data!");

                clear();
            }
            else
            {
                MessageBox.Show("Data diri belum lengkap!");
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMenuId.Text = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPrice.Text = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPhoto.Text = dgv.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtCarbo.Text = dgv.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtProtein.Text = dgv.Rows[e.RowIndex].Cells[5].Value.ToString();

            if (System.IO.File.Exists(txtPhoto.Text))
            {
                pb.Image = Image.FromFile(txtPhoto.Text);
            }

            btnInsert.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Yakin ??", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var image = Image.FromFile(txtPhoto.Text);
                image.Dispose();
                pb.Image.Dispose();
                System.IO.File.Delete(txtPhoto.Text);
                cmd = new SqlCommand($"DELETE FROM MsMenu WHERE id = '{txtMenuId.Text}'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Berhasil Menghapus Data!");
                clear();
            }
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtPrice.Text != "")
            {
                Random ran = new Random();
                int a = ran.Next();

                string folder = @"C:\lks";
                string fname = txtName.Text + Convert.ToString(a) + "_new.jpg";
                string path = System.IO.Path.Combine(folder, fname);

                Image img = pb.Image;
                img.Save(path);

                cmd = new SqlCommand($"UPDATE MsMenu SET name = '{txtName.Text}', price = '{txtPrice.Text}', photo = '{path}', carbo = '{txtCarbo.Text}', protein = '{txtProtein.Text}' WHERE id = '{txtMenuId.Text}'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Berhasil Menambah Data!");

                clear();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand($"SELECT * FROM MsMenu WHERE concat(id,name,price,photo,carbo,protein) LIKE '%{txtSeacrh.Text}%'",con);
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
