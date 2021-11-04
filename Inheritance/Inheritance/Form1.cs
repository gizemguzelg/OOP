using Inheritance.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Eraser(GroupBox groupBox)
        {
            foreach (Control item in groupBox.Controls)
            {
                if (item is TextBox)
                    item.Text = String.Empty;
            }
        }

        User user = new User();
        void GeneratePerson()
        {
            user.Id = Guid.NewGuid();
            user.FirstName = txtFirstName.Text;
            user.LastName = txtLastName.Text;
            user.Age = int.Parse(txtAge.Text);
        }

        void AddListView()
        {
            if (user.Age > 18)
            {
                ListViewItem listViewItem = new ListViewItem(user.Id.ToString());
                listViewItem.SubItems.Add(user.FullName);
                listViewItem.SubItems.Add(user.Age.ToString());
                listViewItem.SubItems.Add(user.CreatDate.ToString());
                listViewItem.SubItems.Add(user.Status.ToString());

                listView1.Items.Add(listViewItem);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                GeneratePerson();
                Eraser(grpCreateUser);
                AddListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
