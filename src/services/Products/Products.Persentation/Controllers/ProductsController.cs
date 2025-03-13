using Microsoft.AspNetCore.Mvc;
using Products.Application.Dtos;
using Products.Application.Features.Products.Query.GetAll;
using Products.Application.Wrappers;

namespace Products.Persentation.Controllers;

public class ProductsController : BaseApiController
{
    [HttpGet]
    public async Task<ActionResult<PaginationResponse<ProductDto>>> GetProducts([FromQuery]GetProductsQuery request ,CancellationToken cancellation)
    {
        return Ok(await Mediator.Send(request, cancellation));
    }
}
