using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Products.Application.Common.BehavioursPipes;
using System.Reflection;

namespace Products.Application.configurations;

public static class ApplicationConfiguration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationPipeline<,>));
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        return services;
    }
}
