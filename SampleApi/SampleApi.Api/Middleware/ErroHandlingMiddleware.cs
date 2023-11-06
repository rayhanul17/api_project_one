using System.Net;
using System.Text.Json;

namespace SampleApi.Api.Middleware;

public class ErroHandlingMiddleware
{
    private readonly RequestDelegate _next;

    public ErroHandlingMiddleware(RequestDelegate next)
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
            await HandleExceptionAsync(context, ex);
        }        
    }

    private static Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        var code = HttpStatusCode.InternalServerError; //500 if unexpected
        var result = JsonSerializer.Serialize(new { error = "An error occurred provided by middleware" });
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)code;

        return context.Response.WriteAsync(result);
    }
}
