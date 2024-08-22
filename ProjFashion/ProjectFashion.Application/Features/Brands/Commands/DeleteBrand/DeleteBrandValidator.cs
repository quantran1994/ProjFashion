using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DeleteBrandValidator:AbstractValidator<DeleteBrandCommand>
{
    public DeleteBrandValidator()
    {
        RuleFor(x=>x.ListId).Empty().WithMessage("Vui lòng chọn nhãn hiệu cần xóa");
    }
}
