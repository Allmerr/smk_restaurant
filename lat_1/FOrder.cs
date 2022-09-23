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
    public partial class FOrder : Form
    {
        SqlConnection con = new SqlConnection("Data Source = LAPTOP-EB9PTRRD;Initial Catalog = latihan;Integrated Security=True;");
        SqlCommand cmd;
        DataTable dt = new DataTable();
        public static string menuId, menuName, qty, carbo, protein, price, total;

        public FOrder()
        {
            InitializeComponent();
            displayAtas();
            displayBawah();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvBawah.Rows.Count; i++)
            {
                cmd = new SqlCommand($"INSERT INTO OrderDetail(orderId,menuId,qty,status) VALUES('{FHeader.id}', '{dgvBawah.Rows[i].Cells[0].Value.ToString()}', '{dgvBawah.Rows[i].Cells[2].Value.ToString()}', 'waiting')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            MessageBox.Show("Berhasil Membeli Makanan");
            this.Hide();
            FAdmin newpage = new FAdmin();
            newpage.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dgvBawah.Rows.Remove(dgvBawah.CurrentRow);
            jumlah();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtNamaMenu.Text != "" && txtQty.Text != "")
            {
                total = Convert.ToString(int.Parse(txtQty.Text) * int.Parse(price));

                dt.Rows.Add(menuId,menuName,txtQty.Text,carbo,protein,price,total);
                dgvBawah.DataSource = dt;
                jumlah();

            }

        }

        public void jumlah()
        {
            int carbo = 0;
            int protein = 0;
            int total = 0;

            for (int i = 0; i < dgvBawah.Rows.Count; i++)
            {
                carbo += int.Parse(dgvBawah.Rows[i].Cells[2].Value.ToString()) * int.Parse(dgvBawah.Rows[i].Cells[3].Value.ToString());
                protein += int.Parse(dgvBawah.Rows[i].Cells[2].Value.ToString()) * int.Parse(dgvBawah.Rows[i].Cells[4].Value.ToString());
                total += int.Parse(dgvBawah.Rows[i].Cells[2].Value.ToString()) * int.Parse(dgvBawah.Rows[i].Cells[5].Value.ToString());
            }

            lblCarbo.Text = $"Carbo : {carbo.ToString()}";
            lblProtein.Text = $"Carbo : {protein.ToString()}";
            lblTotal.Text = $"Carbo : {total.ToString()}";
        }

        private void dgvAtas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                txtNamaMenu.Text = dgvAtas.Rows[e.RowIndex].Cells[1].Value.ToString();

                menuId = dgvAtas.Rows[e.RowIndex].Cells[0].Value.ToString();
                menuName = dgvAtas.Rows[e.RowIndex].Cells[1].Value.ToString();
                carbo = dgvAtas.Rows[e.RowIndex].Cells[4].Value.ToString();
                protein = dgvAtas.Rows[e.RowIndex].Cells[5].Value.ToString();
                price = dgvAtas.Rows[e.RowIndex].Cells[2].Value.ToString();

                if (System.IO.File.Exists(dgvAtas.Rows[e.RowIndex].Cells[3].Value.ToString()))
                {
                    pb.Image = Image.FromFile(dgvAtas.Rows[e.RowIndex].Cells[3].Value.ToString());
                }
            }
            catch (Exception)
            {

                int i = 0;
            }
            

        }

        public void displayAtas()
        {
            cmd = new SqlCommand("SELECT * FROM MsMenu", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            dgvAtas.DataSource = dt;
        }

        public void displayBawah()
        {
            dt.Columns.Add("Menu Id");
            dt.Columns.Add("Menu");
            dt.Columns.Add("Qty");
            dt.Columns.Add("Carbo");
            dt.Columns.Add("Protein");
            dt.Columns.Add("Price");
            dt.Columns.Add("Total");

            dgvBawah.DataSource = dt;

        }

        private void FOrder_Load(object sender, EventArgs e)
        {

        }


    }
}
