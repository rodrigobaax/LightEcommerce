using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LightEcommerce.Dados
{
    public class Products : TypeProduct
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public int Value { get; set; }
        public TypeProduct Type { get; set; }

        public Products() { }

        [HttpGet("products")]
        public IList<Products> GetProduct()
        {
            IList<Products> products = new List<Products>();

            for (int i = 0; i < 100; i++)
            {
                var p = new Products
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
