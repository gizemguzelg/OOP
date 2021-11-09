using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interface.Entities.Interface
{
   public interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Department { get; set; }
        void Information ();

    }
}
