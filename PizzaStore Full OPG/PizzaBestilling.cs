using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace PizzaStore
{
    internal class PizzaBestilling
    {
        private static int nextId = 1;
        public PizzaBestilling(int id, string name, string adress, int total, string paymentMethod)
        {
            Id = id;
            Name = name;
            Adress = adress;
            Total = total;
            PaymentMethod = paymentMethod;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public int Total { get; set; }
        public string PaymentMethod { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Name)}={Name}, {nameof(Adress)}={Adress}, {nameof(Total)}={Total.ToString()}, {nameof(PaymentMethod)}={PaymentMethod}}}";
        }
    }

      
}
