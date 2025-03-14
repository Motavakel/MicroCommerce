namespace Products.Application.Exceptions;

public class ExceptionResponse
{
    public string Message { get; set; } = string.Empty;
    public int Status { get; set; }
    public List<string> Messages { get; set; } = new();


    public ExceptionResponse(int status,string message)
    {
        Message = message;
        Status = status;
        Messages.Add(message);
    }

    public ExceptionResponse(int status,List<string> messages) {

        Status = status;
        Messages = messages ?? new();
    }
}
