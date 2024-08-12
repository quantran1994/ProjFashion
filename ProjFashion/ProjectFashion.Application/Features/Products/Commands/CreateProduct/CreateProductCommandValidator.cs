using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFashion.Application.Features.Products.Commands.CreateProduct
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator()
        {
            RuleFor(model => model.Name).NotEmpty().WithMessage("Chưa nhập tên sản phẩm");
            RuleFor(model => model.CategoryId).GreaterThan(0).WithMessage("Chưa chọn loại sản phẩm");
            RuleFor(model => model.BrandId).GreaterThan(0).WithMessage("Chưa chọn nhãn hàng");
            RuleFor(model => model.StyleFashion).IsInEnum().WithMessage("Chưa chọn giới tính mặt hàng");
        }
    }
}
