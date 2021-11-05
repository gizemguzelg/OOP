using OOP_Repository.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Repository.Entities.Concrete
{
    public class Student : BaseEntity
    {
        public override int Id { get; set ; }
        public string FullName { get; set; }
        public string Description { get; set; }
    }
}
