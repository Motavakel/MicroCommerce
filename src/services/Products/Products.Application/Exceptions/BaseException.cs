using FluentValidation.Results;

namespace Products.Application.Exceptions;

public class BaseException: Exception
{
    public readonly List<string> Messages = new();

    public BaseException(string message) :base(message)
    {

    }

    public BaseException(List<string> messages) :base(null)
    {
        Messages = messages;
    }

    public BaseException(IEnumerable<ValidationFailure> failure)
    {
        Messages = failure.Select(x => x.ErrorMessage).ToList();
    }

}
