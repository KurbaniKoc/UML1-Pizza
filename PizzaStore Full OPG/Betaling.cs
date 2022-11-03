using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Betaling

    {
        public Betaling(string paymentMethod, double price)
        {
            PaymentMethod = paymentMethod;
            Price = price;
        }

        public string PaymentMethod { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(PaymentMethod)}={PaymentMethod}, {nameof(Price)}={Price.ToString()}}}";
        }
    }


      
}
