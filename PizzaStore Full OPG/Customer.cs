using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Customer
    {
        private static int nextId = 1;
        public Customer(int id, string logind, string ordre)
        {
            Id = id;
            LogInd = logind;
            Ordre = ordre;
        }

        public int Id { get; set; }
        public string LogInd { get; set; }
        public string Ordre { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(LogInd)}={LogInd}, {nameof(Ordre)}={Ordre}}}";
        }
    }
    
        
}