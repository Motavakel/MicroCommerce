using GraphQL;
using GraphQL.Types;
using MediatR;
using Products.Application.Features.Products.Query.GetAll;
using Products.Persentation.GQL.Types.Products;

namespace Products.Persentation.GQL.Queris.Product;

public static class ProductQuery
{
    public static void ProductsQuery(this ObjectGraphType schema, IMediator mediator)
    {
        schema.FieldAsync<ProductPaginationType>(
            "products", 
            arguments: new QueryArguments(
                new QueryArgument<NonNullGraphType<ProductReqType>> { Name = "filter" }
            ),
            resolve: async context =>
            {
                var filter = context.GetArgument<GetAllProductsQuery>("filter");
                return await mediator.Send(filter);
            }
        );
    }
}
