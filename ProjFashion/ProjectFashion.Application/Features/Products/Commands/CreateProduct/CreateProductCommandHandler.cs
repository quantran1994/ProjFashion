using FluentValidation;
using System.Text;

namespace ProjectFashion.Application.Features.Products.Commands.CreateProduct.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, bool>
    {
        private readonly CreateProductCommandValidator _validator = new CreateProductCommandValidator();
        private readonly IProductRepository _productRepository;

        public CreateProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<bool> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var _resultValidate = _validator.Validate(request, opt => opt.ThrowOnFailures());
            if (!_resultValidate.IsValid)
            {
                throw new Exception(_resultValidate.Errors.FirstOrDefault()?.ErrorMessage);
            }
            return await _productRepository.Create(new ProjFashion.Core.Entities.Product
            {
                Name = request.Name,
                Description = request.Description,
                CategoryId = request.CategoryId,
                BrandId = request.BrandId,
                StyleFashion = request.StyleFashion,
            });
        }
    }
}
