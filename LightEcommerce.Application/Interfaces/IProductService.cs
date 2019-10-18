using LightEcommerce.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace LightEcommerce.Application.Interfaces
{
    public interface IProductService : IDisposable
    {
        void Register(ProductViewModel productViewModel);
        IEnumerable<ProductViewModel> GetAll();
        ProductViewModel GetById(Guid id);
        void Update(ProductViewModel productViewModel);
        void Remove(Guid id);
    }
}
