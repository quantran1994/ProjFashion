﻿using ProjectFashion.Application.Features.Products.Queries.GetAllQuery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFashion.Application.Features.Products.Queries.GetListProduct
{
    public record GetProducts_Request : IRequest<List<Product_Response>>
    {
    }
    public class GetListProductQueryHandler : IRequestHandler<GetProducts_Request, List<Product_Response>>
    {
        private readonly IProductRepository _productRepository;
        public GetListProductQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<List<Product_Response>> Handle(GetProducts_Request request, CancellationToken cancellationToken)
        {
            var _result = await _productRepository.GetAll();
            return new List<Product_Response>();
        }
    }
}
