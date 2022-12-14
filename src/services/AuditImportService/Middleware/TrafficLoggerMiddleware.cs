using System.Text;
using AuditImportService.Data.Entities;
using AuditImportService.Data.Repositories;

namespace AuditImportService.Middleware;

public class TrafficLoggerMiddleware
{
     private readonly RequestDelegate next;

        public TrafficLoggerMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context /* other dependencies */)
        {
            TrafficLogRepository? repo = context.RequestServices.GetService<TrafficLogRepository>();

            if (repo != null)
            {
                repo.AddTrafficLog(CreateLog(context));
            }

            await next(context);
        }

        private TrafficLog CreateLog(HttpContext ctx)
        {
            var parseQueryString = () =>
            {

                StringBuilder sb = new StringBuilder();

                foreach (var q in ctx.Request.Query)
                {
                    sb.AppendLine($"Name: {q.Key}, Value: {q.Value}");
                }

                return sb.ToString();

            };

            var parseRequestHeaders = () =>
            {
                StringBuilder sb = new StringBuilder();

                foreach (var hdr in ctx.Request.Headers)
                {
                    sb.AppendLine($"Name: {hdr.Key}, Value: {hdr.Value}");
                }

                return sb.ToString();
            };

            var parseRequestBody = () =>
            {
                string body = null;

                using (var mem = new MemoryStream())
                using (var reader = new StreamReader(mem))
                {
                    ctx.Request.Body.CopyTo(mem);

                    body = reader.ReadToEnd();

                    // Do something

                    mem.Seek(0, SeekOrigin.Begin);

                    body = reader.ReadToEnd();
                }
            };

            var parseRequestCookies = () =>
            {
                StringBuilder sb = new StringBuilder();

                foreach (var cookie in ctx.Request.Cookies)
                {
                    sb.AppendLine($"Name: {cookie.Key}, Value: {cookie.Value}");
                }

                return sb.ToString();
            };

            TrafficLog log = new TrafficLog();

            log.Host = ctx.Request.Host.Host;
            log.LocalPort = ctx.Connection.LocalPort;
            log.RemotePort = ctx.Connection.RemotePort;
            log.RequestCookies = parseRequestCookies();
            log.RequestHeaders = parseRequestHeaders();
            log.RequestLength = ctx.Request.ContentLength;
            log.RequestMethod = ctx.Request.Method;
            log.RequestPath = ctx.Request.Path;
            log.RequestProtocol = ctx.Request.Protocol;
            log.RequestQuery = parseQueryString();
            log.RequestScheme = ctx.Request.Scheme;
            log.LocalIP = ctx.Connection.LocalIpAddress?.ToString();
            log.RemoteIP = ctx.Connection.RemoteIpAddress?.ToString();
            log.RequestContentType = ctx.Request.ContentType;
            log.RequestQueryString = ctx.Request.QueryString.Value;
            log.TrafficDate = DateTime.Now;

            return log;
        }
}

public static class TrafficLoggerMiddlewareExtensions
{
    public static IApplicationBuilder UseTrafficLoggerMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<TrafficLoggerMiddleware>();
    }
}