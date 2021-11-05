using OOP_Repository.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Repository
{
   public static class FakeData
    {
        public static List<Student> Students = new List<Student>()
        {
            new Student{Id=1,FullName="Gizem Güzel",Description="3.sınıf"},
            new Student{Id=2,FullName="Emre Güzel",Description="8.sınıf"}

        };

    }
}
