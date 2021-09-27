using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Constructor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Example1_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
        }

        private void btn_Example2_Click(object sender, EventArgs e)
        {
            //FirstName bilgisi olan bir müşteri
            Customers customers = new Customers(txt_FirstName.Text);
            MessageBox.Show($"First Name: {customers.FirstName}");
        }

        private void btn_Example3_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers(txt_FirstName.Text, txt_LastName.Text);
        }

        private void btn_Example4_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers(txt_LastName.Text, txt_FirstName.Text, txt_City.Text);
        }
    }
}
