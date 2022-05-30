using CrudOperations.API.Models;
using Microsoft.AspNetCore.Diagnostics;
using Newtonsoft.Json;
using System.Net;

namespace CrudOperations.API.Extensions
{
    public static class ExceptionMiddleware
    {
        public static void ConfigureExceptionHandler(this IApplicationBuilder app, ILoggerFactory loggerFactory,
          bool includeStackTrace = false)
        {
            app.UseExceptionHandler(builder =>
                builder.Run(async context =>
                {
                    var logger = loggerFactory.CreateLogger(nameof(ExceptionMiddleware));


                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    context.Response.ContentType = "application/json";

                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    if (contextFeature != null)
                    {

                        var currentException = contextFeature.Error;
                        logger.LogError(currentException, $"Something went wrong: {currentException}");

                        ErrorDetails errorDetails;

                        if (includeStackTrace)
                            errorDetails = new ExtendedErrorDetails
                            {
                                StatusCode = (HttpStatusCode)context.Response.StatusCode,
                                Message = currentException.Message,
                                StackTrace = currentException.StackTrace
                            };
                        else
                            errorDetails = new ErrorDetails
                            {
                                StatusCode = (HttpStatusCode)context.Response.StatusCode,
                                Message = "Internal Server Error."
                            };

                        // Write the response
                        await context.Response.WriteAsync(JsonConvert.SerializeObject(errorDetails));
                    }
                }));
        }

    }
}
