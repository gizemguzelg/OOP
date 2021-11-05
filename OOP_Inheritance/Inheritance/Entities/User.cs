using Inheritance.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance.Entities
{
   public class User:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => FirstName + " " + LastName;

        private int _age;
        public int Age
        {
            get => _age;
            set
            {
                if (value > 18)
                    _age = value;
                else
                    MessageBox.Show("18 yaşından küçükler üye olamaz.");
            }
        }

    }
}
