﻿using MediatR;
using ProjFashion.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFashion.Application.Features.Products.Commands.CreateProduct
{
    public class CreateProductCommand : IRequest<bool>
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public long CategoryId { get; set; }
        public long BrandId { get; set; }
        public EGenderFashion StyleFashion { get; set; }
        public bool IsBestSelling { get; set; }
    }
}
