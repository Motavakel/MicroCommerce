using FluentValidation;
using MediatR;
using Products.Application.Exceptions;

namespace Products.Application.Common.BehavioursPipes;

public class ValidationPipeline<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
{
    private readonly IEnumerable<IValidator<TRequest>> _validators;
    public ValidationPipeline(IEnumerable<IValidator<TRequest>> validators)
    {
        _validators = validators;
    }

    public async Task<TResponse> Handle(
        TRequest request,
        RequestHandlerDelegate<TResponse> next,
        CancellationToken cancellationToken
    )
    {
       if(!_validators.Any()) return await next();

        var validationResult = await Task.WhenAll(
            _validators.Select(v => v.ValidateAsync(new ValidationContext<TRequest>(request), cancellationToken))
        );

        var failures = validationResult.SelectMany(e => e.Errors).ToList();

        if(failures.Any())
        {
            throw new ValidationEntityException(failures);
        }

        return await next();
    }
}
