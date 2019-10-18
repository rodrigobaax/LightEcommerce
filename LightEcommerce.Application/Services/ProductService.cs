using AutoMapper;
using AutoMapper.QueryableExtensions;
using LightEcommerce.Application.Interfaces;
using LightEcommerce.Application.ViewModel;
using LightEcommerce.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LightEcommerce.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;
        private readonly IProductService _productService;
        private readonly IProductRepository _productRepository;

        public ProductService(IMapper mapper,
                                  IProductService productService,
                                  IProductRepository productRepository)
        {
            _mapper = mapper;
            _productService = productService;
            _productRepository = productRepository;
        }

        public IEnumerable<ProductViewModel> GetAll()
        {
            return _productRepository.GetAll().ProjectTo<ProductViewModel>(_mapper.ConfigurationProvider);
        }

        public ProductViewModel GetById(Guid id)
        {
            return _mapper.Map<ProductViewModel>(_productRepository.GetById(id));
        }

        public void Register(ProductViewModel productViewModel)
        {
            
        }

        public void Update(ProductViewModel productViewModel)
        {
            
        }

        public void Remove(Guid id)
        {
            
        }        

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
