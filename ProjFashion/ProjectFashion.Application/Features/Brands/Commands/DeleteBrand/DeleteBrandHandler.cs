using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public record DeleteBrandCommand(List<long> ListId):IRequest<bool>;
public class DeleteBrandHandler : IRequestHandler<DeleteBrandCommand, bool>
{
    private readonly IBrandRepository _brandRepository;
    private readonly IUnitOfWork _unitOfWork;

    public DeleteBrandHandler(IUnitOfWork unitOfWork, IBrandRepository brandRepository)
    {
        _unitOfWork = unitOfWork;
        _brandRepository = brandRepository;
    }
    public async Task<bool> Handle(DeleteBrandCommand request, CancellationToken cancellationToken)
    {
        var _result=await _brandRepository.DeleteByListId(request.ListId);
        await _unitOfWork.SaveChangesAsync();
        return _result;
    }
}
