using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOAD_Project
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {   
        }
        private void Form1_Load(object sender, EventArgs e)
        {   
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        /*Login Method*/
        private void button3_Click(object sender, EventArgs e)
        {
            
            if(txtUname.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Enter User Name and Pass");
            }
            else if (txtUname.Text == "")
            {
                MessageBox.Show("Enter User Name");
            }
            else if(txtPass.Text == "")
            {
                MessageBox.Show("Enter Pass");
            }
            
            else if (CboxRole.Text == "Manager")
            {
                
                if (txtUname.Text == "Admin" || txtPass.Text == "Admin")
                {
                    
                    Form3 f31 = Form3.cobject();
                    f31.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Are You The Admin?");
                }
            }
                
            else if (CboxRole.Text == "Customer")
            {
                if (txtUname.Text == "hello" || txtPass.Text == "123")
                {

                    Form4 f4 = new Form4();
                    f4.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Are You The Admin?");
                }
            }
            else
            {
                MessageBox.Show("Select a Roll");
            }
            Form1 login= new Form1();
            login.Hide();
            Form3 f3 = Form3.cobject();
            f3.Show();
            this.Hide();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
