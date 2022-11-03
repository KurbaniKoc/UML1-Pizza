using System;

namespace PizzaStore
{
    class Program
    {
        static void Main(string[] args)
        {
        Customer Robby = new Kunde(" Robby West", " Bestilling af pizza ");
        PizzaBestilling pizzaBestilling = new PizzaBestilling("Salat pizza, Oste pizza, kyllinge pizza", " Holbæk ",  200.00, "MasterCard");
        PizzaMenu kebabPizza = new Pizza(" Salat pizza, Oste pizza, kyllinge pizza",  120, " MED SODAVAND OG POMMES ", " OST OG SKINKE ");
        Ordre ordre = new Ordre(kebabPizza, Robby);
        
            
        Betaling betaling = new Betaling(" MasterCard",  200.00);
        MedlemsFordele medlemsFordele = new MedlemsFordele(" Rabatter", " Gratispræmie", " Ugensgave");

        
       
        Console.WriteLine(ordre);
       
        Console.WriteLine(medlemsFordele);

        Console.WriteLine(ordre.CalculateTotalPrice());
        }
    }
}