using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Products.Application.Contract;
using Products.Application.Contract.Specification;
using Products.Application.Dtos;
using Products.Application.Wrappers;
using Products.Domin.Entities;

namespace Products.Application.Features.Products.Query.GetAll;

public class GetAllProductsQuery : RequestParametersBasic, IRequest<PaginationResponse<ProductDto>>
{
    public decimal? CurrentPrice { get; set; }
}

public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, PaginationResponse<ProductDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetAllProductsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<PaginationResponse<ProductDto>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
    {
        var spec = new GetAllProductBySpec(request);
        var count = await _unitOfWork.GetGenericRepository<Product>().GetCountBySpec(new GetAllProductCountBySpec(request),cancellationToken);
        var result = await _unitOfWork.GetGenericRepository<Product>().GetAllBySpec(spec, cancellationToken);

        var query = _unitOfWork.GetGenericRepository<Product>().GetQuery();
        var max = await query.MaxAsync(p => p.Price);
        var min = await query.MinAsync(p => p.Price);

        return new PaginationResponse<ProductDto>(
            request.PageIndex,
            request.PageSize,
            count,
            _mapper.Map<List<ProductDto>>(result),
            min,
            max
            );
    }
}


public class GetAllProductBySpec : BaseSpecification<Product>
{
    public GetAllProductBySpec(GetAllProductsQuery request) : base(
        x => (string.IsNullOrEmpty(request.Search) || x.Title.Contains(request.Search))&&
             (!request.CurrentPrice.HasValue || x.Price <= request.CurrentPrice.Value))
    {
        AddInclude(x => x.Category);

        switch (request.TypeSort)
        {
            case SortOptions.Newest:
                AddOrderByDes(x => x.Id);
                break;
            case SortOptions.PriceHighToLow:
                AddOrderByDes(x => x.Price);
                break;
            case SortOptions.PriceLowToHigh:
                AddOrderBy(x => x.Price);
                break;
            case SortOptions.NameAToZ:
                AddOrderBy(x => x.Title);
                break;
            default:
                AddOrderByDes(x => x.Id);
                break;
        }
        ApplyPaging(request.PageSize * (request.PageIndex - 1), request.PageSize, true);
    }
}

public class GetAllProductCountBySpec : BaseSpecification<Product>
{
    public GetAllProductCountBySpec(GetAllProductsQuery request) : base(
    
        x => (string.IsNullOrEmpty(request.Search) || x.Title.Contains(request.Search))&&
             (!request.CurrentPrice.HasValue || x.Price <= request.CurrentPrice.Value)
    )
    {
        IsPagingEnabled = false;
    }
}