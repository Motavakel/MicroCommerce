using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Products.Infrastructure.Context;

namespace Products.Persentation.Configurations;

public static class AddConfigurationService
{
    public static IServiceCollection AddCustomService(this WebApplicationBuilder builder)
    {
        builder.Services.AddDbContext<ProductContext>(option =>
        {
            option.UseNpgsql(builder.Configuration.GetConnectionString("ProductsString"));
        });
        builder.Services.AddControllers();
        builder.Services.AddSwaggerGen(c =>
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "Products", Version = "v1" })
        );

        return builder.Services;
    }
}
