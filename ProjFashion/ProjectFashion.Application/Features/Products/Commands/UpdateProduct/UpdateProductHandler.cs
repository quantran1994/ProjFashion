
using FluentValidation;

namespace ProjectFashion.Application.Features.Products.Commands.UpdateProduct
{
    public class UpdateProductHandler : IRequestHandler<UpdateProductCommand, bool>
    {
        private readonly UpdateProductValidator _validator = new UpdateProductValidator();
        private readonly IProductRepository _productRepository;

        public UpdateProductHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<bool> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var _resultValidate = _validator.Validate(request, opt => opt.ThrowOnFailures());
            if (!_resultValidate.IsValid)
            {
                throw new Exception(_resultValidate.Errors.FirstOrDefault()?.ErrorMessage);
            }
            return await _productRepository.Update(new ProjFashion.Core.Entities.Product
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
