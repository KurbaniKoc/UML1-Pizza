﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Ordre
    {
        private static int nextId = 1;
        public Ordre(int id, DateOnly orderDate, DateOnly deliveryDate, Customer customer, Pizza pizza)
        {
            Id = nextId++; 
            OrderDate = orderDate;
            DeliveryDate = deliveryDate;
            Customer = customer;
            Pizza = pizza;
        }

        public int Id { get; set; }
        public DateOnly OrderDate { get; set; }
        public DateOnly DeliveryDate { get; set; }
        public Customer  Customer { get; set; }
        public Pizza Pizza { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(OrderDate)}={OrderDate}, {nameof(DeliveryDate)}={DeliveryDate}, {nameof(Customer)}={Customer}, {nameof(PizzaName)}={PizzaName}}}";
        }
    }
}