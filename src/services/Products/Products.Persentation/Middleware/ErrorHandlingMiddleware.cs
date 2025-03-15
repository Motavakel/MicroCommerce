using Products.Application.Exceptions;
using System.Net;
using System.Text.Json;

namespace Products.Persentation.Middleware;

public class ErrorHandlingMiddleware
{
    private readonly RequestDelegate _next;

    public ErrorHandlingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            var option = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
            var result =  HandleException(context, ex, option);
            await context.Response.WriteAsync(result);
        }
    }

    private string HandleException(HttpContext context, Exception exception, JsonSerializerOptions options)
    {
        context.Response.ContentType = "application/json";

        ExceptionResponse exceptionResponse;

        switch (exception)
        {
            case NotFoundEntityException notFoundEntityException:
                context.Response.StatusCode = (int)HttpStatusCode.NotFound;
                exceptionResponse = new ExceptionResponse((int)HttpStatusCode.NotFound, notFoundEntityException.Messages ?? new List<string> { notFoundEntityException.Message});
                break;

            case BadRequestEntityException badRequestEntityException:
                context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                exceptionResponse = new ExceptionResponse((int)HttpStatusCode.BadRequest, badRequestEntityException.Messages ?? new List<string> { badRequestEntityException.Message});
                break;

            case ValidationEntityException validationEntityException:
                context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                exceptionResponse = new ExceptionResponse((int)HttpStatusCode.BadRequest, validationEntityException.Messages ?? new List<string> { validationEntityException.Message });
                break;

            default:
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                exceptionResponse = new ExceptionResponse((int)HttpStatusCode.InternalServerError, exception.Message);
                break;
        }

        return JsonSerializer.Serialize(exceptionResponse, options);

    }
}
