using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LightEcommerce.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        
        [HttpGet("products")]
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
                adafafafa
                products.Add(p);
            }

            return products;
        }


        [HttpGet("[action]")]
        public IEnumerable<WeatherForecast> WeatherForecasts()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                DateFormatted = DateTime.Now.AddDays(index).ToString("d"),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });
        }



        public class Product
        {           
            public string Id { get; set; }
            public string Price { get; set; }
            public string Name { get; set; }
            public int Value { get; set; }
            public TypeProduct type { get; set; }
        }

        public class TypeProduct
        {
            public string Id { get; set; }
            public string Name { get; set; }
        }

        public class WeatherForecast
        {
            public string DateFormatted { get; set; }
            public int TemperatureC { get; set; }
            public string Summary { get; set; }

            public int TemperatureF
            {
                get
                {
                    return 32 + (int)(TemperatureC / 0.5556);
                }
            }
        }
    }
}
