using LightEcommerce.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LightEcommerce.Domain.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        Product GetById(string id);
    }
}
