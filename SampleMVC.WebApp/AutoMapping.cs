using AutoMapper;
using SampleMVC.Core.Entities;
using SampleMVC.WebApp.Dtos;
namespace SampleMVC.WebApp
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Property, PropertyDto>();
            CreateMap<PropertyDto, Property>();
        }
    }
}
