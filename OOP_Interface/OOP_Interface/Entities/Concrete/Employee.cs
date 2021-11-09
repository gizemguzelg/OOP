using OOP_Interface.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Interface.Entities.Concrete
{
    public class Employee : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }

        public override string ToString() => $"{FirstName} {LastName}";

        public void Information()
        {
            MessageBox.Show($"{ToString()} {Department} departmanında işçidir.");
        }
    }
}
