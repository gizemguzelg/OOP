using OOP_Abstractions.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Abstractions.Entities.Concrete
{
    public class APlane : Plane
    {
        public override void Price()
        {
            Console.WriteLine("A uçağının fiyat 348 TL.");
        }
    }
}
