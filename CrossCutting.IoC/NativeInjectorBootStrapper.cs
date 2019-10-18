using LightEcommerce.Application.Interfaces;
using LightEcommerce.Application.Services;
using LightEcommerce.Data.Context;
using LightEcommerce.Data.Repository;
using LightEcommerce.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace LightEcommerce.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<LightEcommerceContext>();
        }
    }
}
