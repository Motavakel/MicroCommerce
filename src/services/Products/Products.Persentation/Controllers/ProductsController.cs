using Microsoft.AspNetCore.Mvc;
using Products.Application.Dtos;
using Products.Application.Features.Products.Command;

namespace Products.Persentation.Controllers;

public class ProductsController : BaseApiController
{
    [HttpGet]
    public async Task<ActionResult<List<ProductDto>>> GetProducts(CancellationToken cancellation)
    {
        return await Mediator.Send(new GetProductsQuery(), cancellation);
    }
}
