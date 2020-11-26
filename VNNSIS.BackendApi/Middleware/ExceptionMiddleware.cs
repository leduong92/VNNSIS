using System;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using VNNSIS.BackendApi.Errors;

namespace VNNSIS.BackendApi.Middleware
{
     public class ExceptionMiddleware
     {

          public RequestDelegate _next { get; }
          public ILogger<ExceptionMiddleware> _logger { get; }
          public IHostEnvironment _env { get; }
          public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger, IHostEnvironment env)
          {
               _next = next;
               _logger = logger;
               _env = env;
          }

          public async Task InvokeAsync(HttpContext context)
          {
               try
               {
                    await _next(context);
               }
               catch (Exception ex)
               {
                    _logger.LogError(ex, ex.Message);
                    context.Response.ContentType = "application/json";
                    var statusCode = (int)HttpStatusCode.InternalServerError;
                    context.Response.StatusCode = statusCode;

                    var response = _env.IsDevelopment() ? new ApiException(statusCode, ex.Message, ex.StackTrace.ToString())
                    : new ApiException(statusCode, ex.Message, ex.StackTrace.ToString());

                    var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
                    var json = JsonSerializer.Serialize(response, options);

                    await context.Response.WriteAsync(json);
               }
          }

     }
}