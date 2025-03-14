using GraphQL.Types;
using MediatR;
using Products.Persentation.GQL.Mutations.Product;

namespace Products.Persentation.GQL.Mutations;

public class AppMutations : ObjectGraphType
{
    public AppMutations(IMediator mediator)
    {
        this.AddProductMutation(mediator);
    }
}
