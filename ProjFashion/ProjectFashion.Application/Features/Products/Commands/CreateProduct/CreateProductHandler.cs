using ProjectFashion.Core.Interfaces;
using ProjFashion.Core.Enums;

namespace ProjectFashion.Application.Features.Products.Commands.CreateProduct.CreateProduct
{
    public record CreateProductCommand(string Name, string Description, long CategoryId,long BrandId, EGenderFashion StyleFashion, bool IsBestSelling) : IRequest<bool>;

    public class CreateProductHandler : IRequestHandler<CreateProductCommand, bool>
    {
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateProductHandler(IProductRepository productRepository, IUnitOfWork unitOfWork)
        {
            _productRepository = productRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var _added = await _productRepository.Create(new ProjFashion.Core.Entities.Product
            {
                Name = request.Name,
                Description = request.Description,
                CategoryId = request.CategoryId,
                BrandId = request.BrandId,
                StyleFashion = request.StyleFashion,
            });
            await _unitOfWork.SaveChangesAsync();
            return _added;
        }
    }
}
