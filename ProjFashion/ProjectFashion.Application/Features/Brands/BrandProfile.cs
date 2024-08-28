using AutoMapper;
using ProjectFashion.Application.Features.Brands.Queries.GetBrands;
using ProjFashion.Core.Entities;

namespace ProjectFashion.Application.Features.Brands
{
    public class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<Brand, BrandResponse>();
        }
    }
}
