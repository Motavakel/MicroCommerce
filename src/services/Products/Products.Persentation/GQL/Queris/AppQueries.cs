using GraphQL.Types;
using MediatR;
using Products.Persentation.GQL.Queris.Product;

namespace Products.Persentation.GQL.Queris;

public class AppQueries:ObjectGraphType
{
    public AppQueries(IMediator mediator)
    {
        this.ProductsQuery(mediator);
    }
}
