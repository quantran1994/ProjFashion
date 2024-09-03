using ProjFashion.Core.Entities;
using ProjFashion.Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFashion.Application.Features.Categories.Commands.UpdateCategory
{
    public record UpdateCategoryCommand(long Id,string Name, string Describe, string UserName) : IRequest<bool>;
    public class UpdateCategoryHandler
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateCategoryHandler(IUnitOfWork unitOfWork, ICategoryRepository categoryRepository)
        {
            _unitOfWork = unitOfWork;
            _categoryRepository = categoryRepository;
        }

        public async Task<bool> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            Category _category = await _categoryRepository.Get(request.Id);
            if (_category == null)
                throw new RaiseException("Không tìm thấy nhãn hiệu");
            _category.Name = request.Name;
            _category.Describe = request.Describe;
            _category.LastModifiedBy = request.UserName;
            bool _result = await _categoryRepository.Update(_category);
            await _unitOfWork.SaveChangesAsync();
            return _result;
        }
    }
}
