using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LightEcommerce.Application.Interfaces;
using LightEcommerce.Application.ViewModel;
using LightEcommerce.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LightEcommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController(
            IProductService _productService)            
        {
            productService = _productService;
        }

        [HttpGet]
        [Route("products")]
        public IEnumerable<ProductViewModel> Get()
        {
            return productService.GetAll();
        }
    }
}