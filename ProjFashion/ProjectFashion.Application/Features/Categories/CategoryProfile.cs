using AutoMapper;
using ProjectFashion.Application.Features.Categories.Queries;
using ProjFashion.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFashion.Application.Features.Categories
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, ResponseCategory>();
        }
    }
}
