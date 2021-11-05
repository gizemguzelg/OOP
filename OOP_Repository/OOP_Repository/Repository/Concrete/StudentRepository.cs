using OOP_Repository.Entities.Concrete;
using OOP_Repository.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Repository.Repository.Concrete
{
    public class StudentRepository : BaseStudentRepository
    {
        public override void CreateStudent(int id,string fullName, string description)
        {
            Student student = new Student();
            student.Id = id;
            student.FullName = fullName;
            student.Description = description;
            FakeData.Students.Add(student);
            student.Status = Entities.Abstract.Status.Active;
        }

        public override void DeleteStudent(int id)
        {
            foreach (Student student in FakeData.Students)
            {
                if (student.Id == id)
                {
                    student.Status = Entities.Abstract.Status.Passive;

                }
                
            }
            
        }

        public override void Find(int id, TextBox txt_FullName, TextBox txt_Description)
        {
            foreach (Student student in FakeData.Students)
            {
                if (student.Id == id)
                {
                    txt_FullName.Text = student.FullName;
                    txt_Description.Text = student.Description;
                    student.Status = Entities.Abstract.Status.Modified;
                }
            }

         }

     public override Student GetFindById(int id)
        {
            Student findedStudent = new Student();
            foreach (Student student in FakeData.Students)
            {
                if (student.Id == id)
                {
                    findedStudent = student;
                   
                }
            }
            return findedStudent;
        }
        public override List<Student> GetStudents()
        {
            return FakeData.Students.ToList();
        }


        public override void UpdateStudent(int id, string fullName, string description)
        {
            foreach(Student student in FakeData.Students)
            {
                if (student.Id == id)
                {
                    student.FullName = fullName;
                    student.Description = description;
                    student.Status = Entities.Abstract.Status.Modified;
                }
                
            }

           
        }
    }
}
