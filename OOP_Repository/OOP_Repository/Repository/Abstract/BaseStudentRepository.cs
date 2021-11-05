using OOP_Repository.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Repository.Repository.Abstract
{
    public abstract class BaseStudentRepository
    {
        public abstract void CreateStudent(int id,string fullName,string description);
        public abstract List<Student> GetStudents();
        public abstract void Find(int id,TextBox txt_UpdateFullName,TextBox txt_UpdateDescription);
        public abstract void UpdateStudent(int id,string fullName,string description);
        public abstract void DeleteStudent(int id);
        public abstract Student GetFindById(int id);

    }
}
