using GraphQL.Types;
using Products.Persentation.GQL.Mutations;
using Products.Persentation.GQL.Queris;

namespace Products.Persentation.GQL;

/*public class AppSchema:Schema
{
    public AppSchema(AppQueries appQueries,AppMutations appMutations)
    {
        this.Query = appQueries;
        this.Mutation = appMutations;
    }
}*/
/*public class AppSchema : Schema
{
    public AppSchema(IServiceProvider serviceProvider, AppQueries appQueries, AppMutations appMutations)
        : base(serviceProvider)
    {
        this.Query = appQueries;
      //  this.Mutation = appMutations;
    }
}
*/

public class AppSchema : Schema
{
    public AppSchema(IServiceProvider provider) : base(provider)
    {
        Query = provider.GetRequiredService<AppQueries>();
      //  Mutation = provider.GetRequiredService<AppMutations>(); 
    }
}
