using OOP_Interface.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Manager manager = new Manager();
            manager.FirstName = "Mustafa";
            manager.LastName = "Güzel";
            manager.Department = "Yazılım";
            manager.ToString();
            manager.Information();

            Employee employee = new Employee();
            employee.FirstName = "Gizem";
            employee.LastName = "Güzel";
            employee.Department = "Yazılım";
            employee.ToString();
            employee.Information();
            
        }
    }
}
