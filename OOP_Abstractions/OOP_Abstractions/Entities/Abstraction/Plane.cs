using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Abstractions.Entities.Abstraction
{
    public abstract class Plane
    {
       public int PassengerCapacity { get; set; }
        public string Company { get; set; }
        public abstract void Price();
        

    }
}
