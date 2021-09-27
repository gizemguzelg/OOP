using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Encapsulation
{
    public class Customer
    {
        private Guid _id = Guid.NewGuid();
        public Guid Id
        {
            get { return _id; }

        }


        public string FullName { get; set; }
        public string Password { get; set; }


        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 18)
                {
                    _age = value;
                    MessageBox.Show("Üyelik işlemi tamamlandı.");
                }
                else
                    MessageBox.Show("18 yaşından küçük kişiler üye olamaz!");
            }
        }
    }
}
