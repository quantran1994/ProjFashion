using ProjFashion.Core.Entities;
using ProjFashion.Core.Exceptions;

public record UpdateBrandCommand(long Id, string Name, string Describe, string UserName) : IRequest<bool>;
public class UpdateBrandHandler : IRequestHandler<UpdateBrandCommand, bool>
{
    private readonly IBrandRepository _brandRepository;
    private readonly IUnitOfWork _unitOfWork;

    public UpdateBrandHandler(IUnitOfWork unitOfWork, IBrandRepository brandRepository)
    {
        _unitOfWork = unitOfWork;
        _brandRepository = brandRepository;
    }

    public async Task<bool> Handle(UpdateBrandCommand request, CancellationToken cancellationToken)
    {
        Brand _brand = await _brandRepository.Get(request.Id);
        if (_brand == null)
            throw new RaiseException("Không tìm thấy nhãn hiệu");
        _brand.Name = request.Name;
        _brand.Describe = request.Describe;
        _brand.LastModifiedBy = request.UserName;
        bool _result = await _brandRepository.Update(_brand);
        await _unitOfWork.SaveChangesAsync();
        return _result;
    }
}
