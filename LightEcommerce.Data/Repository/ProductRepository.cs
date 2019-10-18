using LightEcommerce.Data.Context;
using LightEcommerce.Domain.Interfaces;
using LightEcommerce.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LightEcommerce.Data.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(LightEcommerceContext context)
            : base(context)
        {

        }

        public Product GetById(string id)
        {
            return DbSet.AsNoTracking().FirstOrDefault(c => c.Id.ToString() == id);
        }
    }
}
