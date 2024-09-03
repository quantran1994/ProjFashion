using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFashion.Application.Features.Categories.Commands.CreateCategory
{
    public class CreateCategoryValidator : AbstractValidator<CreateCategoryCommand>
    {
        public CreateCategoryValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Chưa nhập tên loại mặt hàng");
            RuleFor(x => x.CreateBy).NotEmpty().WithMessage("Không có dữ liệu người tạo loại mặt hàng");
        }
    }
}
