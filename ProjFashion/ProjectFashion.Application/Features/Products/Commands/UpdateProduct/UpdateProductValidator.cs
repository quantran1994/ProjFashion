using FluentValidation;

namespace ProjectFashion.Application.Features.Products.Commands.UpdateProduct
{
    public class UpdateProductValidator : AbstractValidator<UpdateProductCommand>
    {
        public UpdateProductValidator()
        {
            RuleFor(x => x.Id).NotNull().GreaterThan(0).WithMessage("Chưa có Id cần update");
            RuleFor(model => model.Name).NotEmpty().WithMessage("Chưa nhập tên sản phẩm");
            RuleFor(model => model.CategoryId).GreaterThan(0).WithMessage("Chưa chọn loại sản phẩm");
            RuleFor(model => model.BrandId).GreaterThan(0).WithMessage("Chưa chọn nhãn hàng");
            RuleFor(model => model.StyleFashion).IsInEnum().WithMessage("Chưa chọn giới tính mặt hàng");
        }
    }
}
