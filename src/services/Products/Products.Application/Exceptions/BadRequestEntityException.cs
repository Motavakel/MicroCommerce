using FluentValidation.Results;

namespace Products.Application.Exceptions;

public class BadRequestEntityException : BaseException
{
    public BadRequestEntityException(string message) : base(message) { }
    public BadRequestEntityException(List<string> messages) :base(messages) { }
    public BadRequestEntityException(IEnumerable<ValidationFailure> failures) :base(failures) { }   
}
