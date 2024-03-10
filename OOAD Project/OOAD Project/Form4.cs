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


namespace OOAD_Project
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DJJQ8SI\SQLEXPRESS;Initial Catalog=SuperMarket;Integrated Security=True");
        private void Populate()
        {
            con.Open();
            string query = "Select * from tblProduct";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder build = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            SellingGrid1.DataSource = ds.Tables[0];
            con.Close();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            Populate();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void SellingGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.SellingGrid1.Rows[e.RowIndex];
                ProductID.Text = row.Cells["ProductID"].Value.ToString();
                ProductName.Text = row.Cells["ProductName"].Value.ToString();
                ProductPrice.Text = row.Cells["ProductPrice"].Value.ToString();
            }
        }
        private void pnlMart_Paint(object sender, PaintEventArgs e)
        {
            lblDate.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();

        }
        int totalvalue = 0;
        int n = 0;
        private void button10_Click(object sender, EventArgs e)
        {
            if (ProductName.Text == "" || ProductQuantity.Text == "")
            {
                MessageBox.Show("Data Miss");
            }
            else
            {
                int n = 0;
                int total = Convert.ToInt32(ProductPrice.Text) * Convert.ToInt32(ProductQuantity.Text);
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(GridProduct);
                row.Cells[0].Value = n + 1;
                row.Cells[1].Value = ProductName.Text;
                row.Cells[2].Value = ProductPrice.Text;
                row.Cells[3].Value = ProductQuantity.Text;
                row.Cells[4].Value = Convert.ToInt32(ProductPrice.Text) * Convert.ToInt32(ProductQuantity.Text);
                GridProduct.Rows.Add(row);
                n++;
                totalvalue = total + totalvalue;
                lblAmt.Text = "Rs: " + totalvalue;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void ProductQuantity_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
