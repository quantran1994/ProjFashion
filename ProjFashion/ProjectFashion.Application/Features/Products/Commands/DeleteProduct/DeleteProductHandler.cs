using ProjectFashion.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFashion.Application.Features.Products.Commands.DeleteProduct
{
    public record DeleteProductCommand(List<int> ListId) : IRequest<bool>;

    public class DeleteProductHandler : IRequestHandler<DeleteProductCommand, bool>
    {
        private readonly IProductRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteProductHandler(IProductRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var _deleted =await _repository.DeleteByListId(request.ListId);
            await _unitOfWork.SaveChangesAsync();
            return _deleted;
        }
    }
}
