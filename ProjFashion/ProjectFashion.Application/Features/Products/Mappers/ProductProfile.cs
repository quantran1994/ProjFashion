using AutoMapper;
using ProjectFashion.Application.Features.Products.Commands.CreateProduct;
using ProjectFashion.Application.Features.Products.Commands.DeleteProduct;
using ProjectFashion.Application.Features.Products.Commands.UpdateProduct;
using ProjectFashion.Application.Features.Products.Queries.GetAllQuery;
using ProjFashion.Core.Entities;

namespace ProjectFashion.Application.Features.Products.Mappers
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            //Reponse
            CreateMap<Product, Product_Response>();

            //Request Payloads
            CreateMap<CreateProductCommand, Product>();
            CreateMap<UpdateProductCommand, Product>();
        }
    }
}
