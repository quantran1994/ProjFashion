using AutoMapper;
using ProjFashion.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFashion.Application.Features.Brands.Commands.CreateBrand
{
    public record CreateBrandCommand(string Name, string Describe,string CreatedBy) : IRequest<bool>;
    public class CreateBrandHandler : IRequestHandler<CreateBrandCommand, bool>
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateBrandHandler(IBrandRepository brandRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _brandRepository = brandRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<bool> Handle(CreateBrandCommand request, CancellationToken cancellationToken)
        {
            Brand _brand = _mapper.Map<Brand>(request);
            var _added = await _brandRepository.Create(_brand);
            await _unitOfWork.SaveChangesAsync();
            return _added;
        }
    }
}
