﻿using PetControlSystem.Models;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace PetControlSystem.Models
{
    public class Order
    {
        public long Id { get; private set; }
        public DateTime Date { get; private set; }
        public long CustomerId { get; private set; }
        public Customer Customer { get; private set; }
        public ICollection<Product> Products = [];

        public Order() { }

        public Order(Customer customer)
        {
            Date = DateTime.Now;
            Customer = customer;
        }
    }
}