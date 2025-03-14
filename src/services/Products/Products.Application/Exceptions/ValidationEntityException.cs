using FluentValidation.Results;

namespace Products.Application.Exceptions;

public class ValidationEntityException : BaseException
{
    public ValidationEntityException(List<string> messages) : base(messages) { }
    public ValidationEntityException(IEnumerable<ValidationFailure> failures) : base(failures) { }
}
