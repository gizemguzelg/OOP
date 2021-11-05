using OOP_Repository.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Repository
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        StudentRepository repo = new StudentRepository();
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = repo.GetStudents();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            repo.CreateStudent(Convert.ToInt32(txt_Id.Text),txt_FullName.Text, txt_Description.Text);
            dataGridView1.DataSource = repo.GetStudents();
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            repo.Find(int.Parse(txt_FindById.Text),txt_UpdateFullName,txt_UpdateDescription);
           
           
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            repo.UpdateStudent(int.Parse(txt_FindById.Text), txt_UpdateFullName.Text, txt_UpdateDescription.Text);
            dataGridView1.DataSource = repo.GetStudents();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            repo.DeleteStudent(int.Parse(txt_DeleteId.Text));
        }
    }
}
