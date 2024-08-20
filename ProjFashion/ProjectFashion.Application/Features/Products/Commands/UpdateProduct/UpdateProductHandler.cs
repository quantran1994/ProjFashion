namespace ProjectFashion.Application.Features.Products.Commands.UpdateProduct
{
    public record UpdateProductCommand(int Id, string Name, string Description, long CategoryId, long BrandId, EGenderFashion StyleFashion, bool IsBestSelling) : IRequest<bool>;

    public class UpdateProductHandler : IRequestHandler<UpdateProductCommand, bool>
    {
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateProductHandler(IProductRepository productRepository, IUnitOfWork unitOfWork)
        {
            _productRepository = productRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var _updated = await _productRepository.Update(new ProjFashion.Core.Entities.Product
            {
                Name = request.Name,
                Description = request.Description,
                CategoryId = request.CategoryId,
                BrandId = request.BrandId,
                StyleFashion = request.StyleFashion,
            });
            await _unitOfWork.SaveChangesAsync();
            return _updated;
        }
    }
}
