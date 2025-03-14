using FluentValidation.Results;

namespace Products.Application.Exceptions;

public class NotFoundEntityException:BaseException
{
    public NotFoundEntityException(string message): base(message) { }
    public NotFoundEntityException(List<string> messages) : base(messages) { }
    public NotFoundEntityException(IEnumerable<ValidationFailure> validationFailures) : base(validationFailures) { }
}
