using AutoMapper;
using ProjectFashion.Application.Features.Brands.Queries.GetBrands;
using ProjFashion.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public record GetBrandsQuery : IRequest<List<BrandResponse>>;
public class GetBrandsQueryHandler : IRequestHandler<GetBrandsQuery, List<BrandResponse>>
{
    private readonly IBrandRepository _brandRepository;
    private readonly IMapper _mapper;

    public GetBrandsQueryHandler(IBrandRepository brandRepository, IMapper mapper)
    {
        _brandRepository = brandRepository;
        _mapper = mapper;
    }

    public async Task<List<BrandResponse>> Handle(GetBrandsQuery request, CancellationToken cancellationToken)
    {
        List<Brand> _brands = await _brandRepository.GetAll();
        return _mapper.Map<List<BrandResponse>>(_brands);
    }
}
