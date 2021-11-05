using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_GenericList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            List<string> kategoriler = new List<string>() { };

            List<Category> categories = new List<Category>()
            {
                new Category { Id= 1, Name = "Tennis Racket", Description="Best tennis racket."},
                new Category { Id= 2, Name = "Tennis Ball", Description="Best tennis ball."},
                new Category { Id= 3, Name = "Tennis Shoes", Description="Best tenis shoes."},
            };

            dataGridView1.DataSource = categories.ToList();
        }
    }
}
