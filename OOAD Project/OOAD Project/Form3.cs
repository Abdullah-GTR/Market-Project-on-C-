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
    public partial class Form3 : Form
    {
        
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DJJQ8SI\SQLEXPRESS;Initial Catalog=SuperMarket;Integrated Security=True");
        private Form3()
        {
            InitializeComponent();
        }
        public static Form3 obj;
        public static Form3 cobject()
        {
            if (obj == null)
            {
                obj = new Form3();
            }
            return obj;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Product Button
            pnlProduct.Show();


            using (SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-DJJQ8SI\SQLEXPRESS;Initial Catalog=SuperMarket;Integrated Security=True"))
            {
                sqlcon.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * From tblProduct", sqlcon);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Grid1.DataSource = dt;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Customer Button
            pnlCustomer.Show();
            pnlProduct.Hide();
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DJJQ8SI\SQLEXPRESS;Initial Catalog=SuperMarket;Integrated Security=True"))
            {
                con.Open();
                SqlDataAdapter dada = new SqlDataAdapter("Select * From Customer", con);
                DataTable dtable = new DataTable();
                dada.Fill(dtable);
                Grid2.DataSource = dtable;
            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            //Customer Add Button
            try
            {
                using (var connection = new SqlConnection(@"Data Source=DESKTOP-DJJQ8SI\SQLEXPRESS;Initial Catalog=SuperMarket;Integrated Security=True"))
                {
                    connection.Open();
                    var sql = "INSERT INTO Customer(CustomerID,CustomerName,CustomerNumber, CustomerMail) VALUES(@CustomerID, @CustomerName, @CustomerNumber, @CustomerNumber)";
                    using (var cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", CustomerID.Text);
                        cmd.Parameters.AddWithValue("@CustomerName", CustomerName.Text);
                        cmd.Parameters.AddWithValue("@CustomerNumber", CustomerNumber.Text);
                        cmd.Parameters.AddWithValue("@CustomerMail", CustomerMail.Text);


                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Product Added!!!!!!!!!!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Product Add Button
            try
            {
                using (var connection = new SqlConnection(@"Data Source=DESKTOP-DJJQ8SI\SQLEXPRESS;Initial Catalog=SuperMarket;Integrated Security=True"))
                {
                    connection.Open();
                    var sql = "INSERT INTO tblProduct(ProductID,ProductName,ProductPrice, ProductQuantity,ProductCatagory) VALUES(@ProductID, @ProductName, @ProductPrice, @ProductQuantity,@ProductCatagory)";
                    using (var cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@ProductID", ProductID.Text);
                        cmd.Parameters.AddWithValue("@ProductName", ProductName.Text);
                        cmd.Parameters.AddWithValue("@ProductPrice", ProductPrice.Text);
                        cmd.Parameters.AddWithValue("@ProductQuantity", ProductQuantity.Text);
                        cmd.Parameters.AddWithValue("@ProductCatagory", comboBox.Text);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Product Added!!!!!!!!!!");
                    con.Close();

                    /*
                    con.Open();
                    string query = "INSERT INTO tblProduct VALUES("+ProductID.Text+",'"+ProductName.Text+"','"+ProductPrice.Text+"','"+ProductQuantity.Text +"','"+ProductCatagory.SelectedValue.ToString()+"')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Added!!!!!!!!!!");
                    con.Close();*/
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Grid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Product Grid View
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.Grid1.Rows[e.RowIndex];
                ProductID.Text = row.Cells["ProductID"].Value.ToString();
                ProductName.Text = row.Cells["ProductName"].Value.ToString();
                ProductQuantity.Text = row.Cells["ProductQuantity"].Value.ToString();
                ProductPrice.Text = row.Cells["ProductPrice"].Value.ToString();
                comboBox.Text = row.Cells["ProductCatagory"].Value.ToString();
            }
        }
        private void Grid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Customer Grid View
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.Grid2.Rows[e.RowIndex];
                CustomerID.Text = row.Cells["CustomerID"].Value.ToString();
                CustomerName.Text = row.Cells["CustomerName"].Value.ToString();
                CustomerNumber.Text = row.Cells["CustomerNumber"].Value.ToString();
                CustomerMail.Text = row.Cells["CustomerMail"].Value.ToString();
            }
        }
        private void pnlCustomer_Paint(object sender, PaintEventArgs e)
        { 
        }
        private void btnPdelete_Click(object sender, EventArgs e)
        {
            //Product Delete Button
            try
            {
                if (ProductID.Text == "")
                {
                    MessageBox.Show("Select a Column");
                }
                else
                {
                    con.Open();
                    string query = "Delete From tblProduct where ProductID = " + ProductID.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete Successfully");

                    con.Close();
                    ProductID.Text = "";
                    ProductName.Text = "";
                    ProductPrice.Text = "";
                    ProductQuantity.Text = "";
                    comboBox.Text = "";
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void populate()
        {
            con.Open();
            string query = "Select * from tblProduct";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder build = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Grid1.DataSource = ds.Tables[0];
            con.Close();
        }
        private void btnCdelete_Click(object sender, EventArgs e)
        {
        }
        private void btnCdelete_Click_1(object sender, EventArgs e)
        {
            //Customer Delete Button
            try
            {
                if (CustomerID.Text == "")
                {
                    MessageBox.Show("Select a Column");
                }
                else
                {
                    con.Open();
                    string query = "Delete From Customer where CustomerID = " + CustomerID.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete Successfully");

                    con.Close();
                    CustomerID.Text = "";
                    CustomerName.Text = "";
                    CustomerNumber.Text = "";
                    CustomerMail.Text = "";
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        private void btnPedit_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProductID.Text == "" || ProductName.Text == "" || ProductPrice.Text == "" || ProductQuantity.Text == "" || comboBox.Text == "")
                {
                    MessageBox.Show("Missing Info");
                }
                else
                {
                    con.Open();
                    string query = "Update tblProduct set ProductName = '" + ProductName.Text + "', ProductPrice = '" + ProductPrice.Text + "', ProductQuantity = '" + ProductQuantity.Text + "', ProductCatagory = '" + comboBox.Text + "' Where ProductID = " + ProductID.Text + ";";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("All Things is Updated");
                    con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SearchBar_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Hide();
            Form1 login = new Form1();
            login.Show();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            string query = "Select * From tblProduct Where ProductID = " + txtSearch.Text;
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder build = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Grid1.DataSource = ds.Tables[0];
            con.Close();
        }
        private void btnCedit_Click(object sender, EventArgs e)
        {
            try
            {
                if (CustomerID.Text == "" || CustomerName.Text == "" || CustomerNumber.Text == "" || CustomerMail.Text == "")
                {
                    MessageBox.Show("Missing Info");
                }
                else
                {
                    con.Open();
                    string query = "Update Customer set CustomerName = '" + CustomerName.Text + "', CustomerNumber = " + CustomerNumber.Text + ", CustomerMail = '" + CustomerMail.Text + "' Where CustomerID = " + CustomerID.Text + ";";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("All Things is Updated");
                    con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnCedit_Click_1(object sender, EventArgs e)
        {
            //Edit Button Customer
            try
            {
                if (CustomerID.Text == "" || CustomerName.Text == "" || CustomerNumber.Text == "" || CustomerMail.Text == "")
                {
                    MessageBox.Show("Missing Info");
                }
                else
                {
                    con.Open();
                    string query = "Update Customer set CustomerName = '" + CustomerName.Text + "', CustomerNumber = " + CustomerNumber.Text + ", CustomerMail = '" + CustomerMail.Text + "' Where CustomerID = " + CustomerID.Text + ";";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("All Things is Updated");
                    con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CustomerMail_TextChanged(object sender, EventArgs e)
        {
            System.Text.RegularExpressions.Regex rmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (CustomerMail.Text.Length > 0)
            {
                if (!rmail.IsMatch(CustomerMail.Text))
                {
                    MessageBox.Show("Invalid Email Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CustomerMail.SelectAll();

                }
            }
        }
        private void button14_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void pnlProduct_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
