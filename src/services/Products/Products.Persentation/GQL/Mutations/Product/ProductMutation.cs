using GraphQL.Types;
using MediatR;
namespace Products.Persentation.GQL.Mutations.Product;

public static class ProductMutation
{
    public static void AddProductMutation(this ObjectGraphType schems,IMediator mediator)
    {
        /*schems.FieldAsync<ProductType>(
            "createProduct",
            arguments: new QueryArguments(
                new QueryArgument<NonNullGraphType<ProductInputType>> { Name = "product" }
            ),
            resolve: async context =>
            {
                var product = context.GetArgument<Domain.Entities.Product>("product");
                return await context.TryAsyncResolve(
                    async c => await c.GetRequiredService<IMediator>().Send(new CreateProductCommand(product))
                );
            }
        );*/
    }
}
