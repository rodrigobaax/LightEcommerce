using LightEcommerce.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LightEcommerce.Domain.Models
{
    public class Product : Entity
    {
        public Product(Guid id, string name, int price, int value)
        {
            Id = id;
            Name = name;
            Price = price;
            Value = value;
        }

        public int Price { get; private set; }
        public string Name { get; private set; }
        public int Value { get; private set; }

        protected Product() {}
    }    
}
