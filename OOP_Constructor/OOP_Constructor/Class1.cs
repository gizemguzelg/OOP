using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Constructor
{
    public class Customers
    {
        

        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public int Id { get; set; }
        public string City { get; set; }


        public Customers()
        {

            MessageBox.Show("Customer prototipinden nesne üretildi. Lakin hiçbir özelliği kullanılmadan yaratıldı..!");

        }
        public Customers(string isim)
        {
            this.FirstName = isim;
        }

        public Customers(string isim, string soyisim)
        {
            this.FirstName = isim;
            this.Lastname = soyisim;
            MessageBox.Show($"İsim: {this.FirstName}\nSoyisim: {this.Lastname}");
        }

        public Customers(string isim, string soyisim, string sehir)
        {
            this.FirstName = isim;
            this.Lastname = soyisim;
            this.City = sehir;
            MessageBox.Show($"İsim: {this.FirstName}\nSoyisim: {this.Lastname}\nŞehir:{this.City}");
        }


    }
}
