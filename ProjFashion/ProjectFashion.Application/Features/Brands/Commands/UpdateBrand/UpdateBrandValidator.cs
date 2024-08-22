using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFashion.Application.Features.Brands.Commands.UpdateBrand
{
    public class UpdateBrandValidator:AbstractValidator<UpdateBrandCommand>
    {
        public UpdateBrandValidator()
        {
            RuleFor(x => x.Id).LessThanOrEqualTo(0).WithMessage("Thiếu thông tin nhãn hàng cần cập nhật");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Chưa nhập tên nhãn hàng");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Không có dữ liệu người cập nhật nhãn hàng");
        }
    }
}
