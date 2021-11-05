using OOP_Abstractions.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Abstractions.Entities.Concrete
{
    public class BPlane : Plane
    {
        public override void Price()
        {
            Console.WriteLine("B uçağının fiyatı 244 TL.");
        }
    }
}
