using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFashion.Application.Features.Products.Commands.CreateProductClassification
{
    public record ProductClassificationModel(string colorName,double size);
    public record CreateProductClassificationCommand(List<ProductClassificationModel> productClassification):IRequest<bool>;
    public record CreateProductClassificationHandler : IRequestHandler<CreateProductClassificationCommand, bool>
    {
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfWork _unitOfWork;
        public CreateProductClassificationHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<bool> Handle(CreateProductClassificationCommand request, CancellationToken cancellationToken)
        {
            throw new Exception();
        }
    }
}
