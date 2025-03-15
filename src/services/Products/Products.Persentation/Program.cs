using Products.Persentation.Configurations;
using Products.Persentation.GQL;
using Products.Persentation.Middleware;


var builder = WebApplication.CreateBuilder(args);
builder.AddCustomService();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Products API v1"));
}


app.UseHttpsRedirection();
app.UseRouting();

app.UseMiddleware<ErrorHandlingMiddleware>();


app.UseAuthorization();
/*app.UseGraphQL<AppSchema>();
app.UseGraphQLGraphiQL("/ui/graphql");*/

app.MapControllers();
app.Run();
