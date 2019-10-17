using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LightEcommerce.Dados
{
    public class Product : TypeProduct
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public int Value { get; set; }
        public TypeProduct Type { get; set; }

        public Product() { }


        public IList<Product> GetProducts()
        {
            IList<Product> products = new List<Product>();

            for (int i = 0; i < 100; i++)
            {
                var p = new Product
                {
                    Id = Convert.ToString(i),
                    Name = Convert.ToString(i),
                    Price = Convert.ToString(i),
                    Value = i * i * i,
                };

                products.Add(p);
            }

            return products;
        }
    }
}
