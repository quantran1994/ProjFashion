using AutoMapper;
using ProjFashion.Core.Entities;
using ProjFashion.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFashion.Application.Features.Categories.Queries
{
    public class GetAllQueryHandler : IRequestHandler<IRequest<List<ResponseCategory>>, List<ResponseCategory>>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public GetAllQueryHandler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<List<ResponseCategory>> Handle(IRequest<List<ResponseCategory>> request, CancellationToken cancellationToken)
        {
            List<Category> _listCategory = await _categoryRepository.GetAll();
            return _mapper.Map<List<ResponseCategory>>(_listCategory);
        }
    }
}
