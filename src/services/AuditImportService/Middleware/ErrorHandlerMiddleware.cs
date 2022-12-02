using System.Net;
using System.Text.Json;
using AuditImportService.Data.Entities;
using AuditImportService.Data.Repositories;

namespace AuditImportService.Middleware;

public class ErrorHandlerMiddleware
{
    private readonly RequestDelegate _next;
    
    public ErrorHandlerMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception error)
        {
            ErrorRepository? errorRepository = context.RequestServices.GetService<ErrorRepository>();
            
            var response = context.Response;
            response.ContentType = "application/json";

            if (errorRepository != null)
            {
                var dataError = new SystemError()
                {
                    Message = error.Message,
                    EventDate = DateTime.Now,
                    ExceptionType = error.GetType().Name,
                    RemoteAddress = context.Request.HttpContext.Connection.RemoteIpAddress?.ToString(),
                    RequestHeaders = context.Request.Headers.ToString(),
                    StackTrace = error.StackTrace
                };
                
                errorRepository.AddError(dataError);
            }

            switch(error)
            {
                 default:
                    // unhandled error
                    
                    response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    break;
            }
            
            
            var result = JsonSerializer.Serialize(new { message = error?.Message });
            await response.WriteAsync(result);
        }
    }
}


public static class ErrorHandlerMiddlewareExtensions
{
    public static IApplicationBuilder UseErrorHandlerMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<ErrorHandlerMiddleware>();
    }
}