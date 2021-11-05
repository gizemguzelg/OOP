using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Class_Constructor_Encapsulation_Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.FirstName = "Gizem";
            customer.LastName = "Güzel";
            customer.Id = Guid.NewGuid();
            customer.City = "İstanbul";
            MessageBox.Show($"First Name: {customer.FirstName}\nLast Name: {customer.LastName}\nId:{customer.Id}\nCity:{customer.City}");
        }

        private void btn_User_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.FullName = txt_FullName.Text;
            user.UserId = Guid.NewGuid();
            MessageBox.Show($"User Id: {user.UserId}\nFull Name: {user.FullName}");
        }
    }
}
