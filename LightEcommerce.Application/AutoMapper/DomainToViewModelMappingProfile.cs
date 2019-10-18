using AutoMapper;
using LightEcommerce.Application.ViewModel;
using LightEcommerce.Domain.Models;

namespace LightEcommerce.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Product, ProductViewModel>();
        }
    }
}
