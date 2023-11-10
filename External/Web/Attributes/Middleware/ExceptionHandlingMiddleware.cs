
using Domain.Exceptions.Base;
using System.Text.Json;
using Domain.Exceptions;

namespace Web.Attributes.Middleware
{
    public sealed class ExceptionHandlingMiddleware : IMiddleware
    {
        private readonly ILogger<ExceptionHandlingMiddleware> _logger;

        public ExceptionHandlingMiddleware(ILogger<ExceptionHandlingMiddleware> logger) =>
            _logger = logger;

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                await HandleExceptionAsync(context, ex);
            }
        }

        private static async Task HandleExceptionAsync(HttpContext httpContext, Exception ex)
        {
            var statusCode = GetStatusCode(ex);

            var response = new
            {
                title = GetTitle(ex),
                status = statusCode,
                detail = ex.Message,
                errors = GetErrors(ex),
            };

            httpContext.Response.ContentType = "application/json";
            httpContext.Response.StatusCode = statusCode;

            await httpContext.Response.WriteAsync(JsonSerializer.Serialize(response));
        }

        private static string GetTitle(Exception exception) =>
            exception switch
            {
                BaseException baseException => baseException.Title,
                _ => "Server Error"
            };

        private static IReadOnlyDictionary<string, string[]>? GetErrors(Exception ex)
        {
            IReadOnlyDictionary<string, string[]>? errors = null;

            if (ex is ValidationException validationException)
            {
                errors = validationException.ErrorsDictionary;
            }

            return errors;
        }

        private static int GetStatusCode(Exception exception) =>
             exception switch
             {
                 BadRequestException => StatusCodes.Status400BadRequest,
                 NotFoundException => StatusCodes.Status404NotFound,
                 ConflictException => StatusCodes.Status409Conflict,
                 ValidationException => StatusCodes.Status422UnprocessableEntity,
                 UnauthorizedException => StatusCodes.Status401Unauthorized,
                  _ => StatusCodes.Status500InternalServerError,
             };
    }
}
