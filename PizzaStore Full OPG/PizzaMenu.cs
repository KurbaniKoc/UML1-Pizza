using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class PizzaMenu
    {
        private static int nextId = 1;
        public PizzaMenu(int id, string name, double price, string menu, string ingredients)
        {
            nextId = id++;
            Id = id;
            Name = name;
            Price = price;
            Menu = menu;
            Ingredients = ingredients;
        }
        public int Id { get; set; }
        public string Name { get; set;}
        public double Price { get; set;}
        public string Menu { get; set;}
        public string Ingredients { get; set;}

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Name)}={Name.ToString()}, {nameof(Price)}={Price}, {nameof(Menu)}={Menu}, {nameof(Ingredients)}={Ingredients}}}";
        }
    }
    
        

}
