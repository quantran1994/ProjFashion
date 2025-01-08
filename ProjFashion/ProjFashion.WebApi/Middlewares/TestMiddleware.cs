
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace ProjFashion.WebApi.Middlewares
{
    public class TestffffMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            ClaimsIdentity _identity = new ClaimsIdentity(new List<Claim>
            {
                new Claim(ClaimTypes.DateOfBirth,"21",ClaimValueTypes.Integer32)
            });
            context.User = new System.Security.Claims.ClaimsPrincipal(_identity);
            //if (context.Request.Path.Value.Equals("/api/WeatherForecast"))
            //{
            //    Console.WriteLine("CheckAcessMiddleware: Cấm truy cập");
            //    await Task.Run(
            //      async () =>
            //      {
            //          string html = "<h1>CAM KHONG DUOC TRUY CAP</h1>";
            //          context.Response.StatusCode = StatusCodes.Status200OK;
            //          await context.Response.WriteAsync(html);
            //      }
            //    );
            //}
            //else
            //{
                context.Response.Headers.Add("X-Custom-Header", "Hello World");
                await next(context);
            //}
                
        }
    }
    //public class LogURLMiddleware
    //{
    //    private readonly RequestDelegate _next;
    //    private readonly ILogger<LogURLMiddleware> _logger;
    //    public LogURLMiddleware(RequestDelegate next, ILoggerFactory loggerFactory)
    //    {
    //        _next = next;
    //        _logger = loggerFactory?.CreateLogger<LogURLMiddleware>() ??
    //        throw new ArgumentNullException(nameof(loggerFactory));
    //    }
    //    public async Task InvokeAsync(HttpContext context)
    //    {
    //        _logger.LogInformation($"Request URL: {Microsoft.AspNetCore.Http.Extensions.UriHelper.GetDisplayUrl(context.Request)}");
    //        await this._next(context);
    //    }
    //}
}
