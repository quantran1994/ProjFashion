using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFashion.Application.Features.Brands.Commands.CreateBrand
{
    public class CreateBrandValidator : AbstractValidator<CreateBrandCommand>
    {
        public CreateBrandValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Chưa nhập tên nhãn hàng");
            RuleFor(x => x.CreatedBy).NotEmpty().WithMessage("Không có dữ liệu người tạo nhãn hàng");
        }
    }
}
