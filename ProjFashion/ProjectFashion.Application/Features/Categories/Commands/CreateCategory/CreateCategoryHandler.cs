using AutoMapper;
using ProjFashion.Core.Entities;
using ProjFashion.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFashion.Application.Features.Categories.Commands.CreateCategory
{
    public record CreateCategoryCommand(string Name, string Describe,string CreateBy) : IRequest<bool>;
    public class CreateCategoryHandler : IRequestHandler<CreateCategoryCommand, bool>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateCategoryHandler(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<bool> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            Category _category = _mapper.Map<Category>(request);
            var _added = await _categoryRepository.Create(_category);
            await _unitOfWork.SaveChangesAsync();
            return _added;
        }
    }
}
