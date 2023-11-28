using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;
using System.Text.Json;

namespace SoBugger.WebApi.Filters;

public class GlobalExceptionFilter : IAsyncExceptionFilter
{
    public Task OnExceptionAsync(ExceptionContext context)
    {
        var exception = context.Exception;
        var response = context.HttpContext.Response;
        response.ContentType = "application/json";
        response.StatusCode = (int)HttpStatusCode.InternalServerError;
        var result = JsonSerializer.Serialize(new { message = exception?.Message });
        return response.WriteAsync(result);
    }
}
