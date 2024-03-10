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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int sPoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sPoint += 1;
            Bar1.Value = sPoint;
            if(Bar1.Value == 100)
            {
                Bar1.Value = 0;
                timer1.Stop();
                Form1 F1 = new Form1();
                this.Hide();
                F1.Show();
                this.Hide();
                Form1 login = new Form1();
                login.Show();
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
           timer1.Start();   
        }
    }
}
