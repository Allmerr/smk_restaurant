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
    public partial class FPayment : Form
    {
        SqlConnection con = new SqlConnection("Data Source = LAPTOP-EB9PTRRD;Initial Catalog = latihan;Integrated Security=True;");
        SqlCommand cmd;
        public static string _total;
        public FPayment()
        {
            InitializeComponent();
            firstDisplay();
            data();
        }

        public void data()
        {
            cmd = new SqlCommand("SELECT * FROM OrderHeader", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbOrderId.Items.Add(dt.Rows[i]["id"].ToString());
            }
        }

        private void firstDisplay()
        {
            lblJumlahUang.Visible = false;
            lblKembalian.Visible = false;
            txtJumlahUang.Visible = false;
            txtKembalian.Visible = false;
            lblCardNumber.Visible = false;
            lblBankName.Visible = false;
            txtCardNumber.Visible = false;
            cmbBankName.Visible = false;
            btnBayar.Enabled = false;
        }
        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            firstDisplay();
            if(cmbPaymentType.Text == "Cash")
            {
                lblJumlahUang.Visible = true;
                lblKembalian.Visible = true;
                txtJumlahUang.Visible = true;
                txtKembalian.Visible = true;
            }
            else
            {
                lblCardNumber.Visible = true;
                lblBankName.Visible = true;
                txtCardNumber.Visible = true;
                cmbBankName.Visible = true;
                btnBayar.Enabled = true;
            }
        }

        private void txtJumlahUang_TextChanged(object sender, EventArgs e)
        {
            int kembali,bayar = 0;
            if(int.TryParse(txtJumlahUang.Text, out bayar))
            {
                kembali = bayar - int.Parse(_total);
                txtKembalian.Text = Convert.ToString(kembali);
                if(kembali < 0)
                {
                    txtJumlahUang.Focus();
                    txtJumlahUang.BackColor = Color.DarkOrange;
                }
                else
                {
                    txtJumlahUang.BackColor = Color.Green;
                    btnBayar.Enabled = true;
                }
            }
        }

        private void cmbOrderId_SelectedValueChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand($"select a.orderId, b.name, a.qty, b.price, a.status from OrderDetail a left join MsMenu b on a.menuId = b.id where orderId = '{cmbOrderId.Text}'; ", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            dgv.DataSource = dt;

            int total = 0;

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                total += int.Parse(dgv.Rows[i].Cells[3].Value.ToString()) * int.Parse(dgv.Rows[i].Cells[2].Value.ToString());
            }

            _total = Convert.ToString(total);
            lblTotal.Text = "Total : "  + Convert.ToString(total);
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            this.Hide();
            FKasir newpage = new FKasir();
            newpage.Show();
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            var firstCmd = new SqlCommand($"UPDATE OrderHeader SET paymentType ='{cmbPaymentType.Text}', cardNumber = '{txtCardNumber.Text}', bank = '{cmbBankName.Text}', jumlahBayar = '{txtJumlahUang.Text}' WHERE id = '{cmbOrderId.Text}' ", con);
            var secondCmd = new SqlCommand($"UPDATE OrderDetail SET status = 'success' WHERE orderId = '{cmbOrderId.Text}'", con);
            con.Open();
            firstCmd.ExecuteNonQuery();
            secondCmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Berhasil Membayar Pesanan!");
        }
    }
}
