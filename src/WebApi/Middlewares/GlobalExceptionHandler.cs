using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CompraProgamada.Domain.Exceptions;
using FluentValidation; 

namespace CompraProgamada.WebApi.Middlewares
{
    public class GlobalExceptionHandler : IExceptionHandler
    {
        private readonly ILogger<GlobalExceptionHandler> _logger;

        public GlobalExceptionHandler(ILogger<GlobalExceptionHandler> logger)
        {
            _logger = logger;
        }

        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            _logger.LogError(exception, "Exception occurred: {Message}", exception.Message);

            int statusCode;
            object response;

            switch (exception)
            {
                case DomainException domainException:
                    statusCode = domainException.StatusCode;
                    response = new 
                    { 
                        erro = domainException.Message, 
                        codigo = domainException.Codigo 
                    };
                    break;
                case NotFoundException notFoundException:
                    statusCode = StatusCodes.Status404NotFound;
                    response = new 
                    { 
                        erro = notFoundException.Message, 
                        codigo = "NOT_FOUND" 
                    };
                    break;
                case ValidationException validationException:
                    statusCode = StatusCodes.Status400BadRequest;
                    response = new 
                    { 
                        erro = "Erro de validação", 
                        codigo = "VALIDATION_ERROR",
                        detalhes = validationException.Errors
                            .GroupBy(x => x.PropertyName)
                            .ToDictionary(
                                g => g.Key,
                                g => g.Select(x => x.ErrorMessage).ToArray()
                            )
                    };
                    break;
                default:
                    statusCode = StatusCodes.Status500InternalServerError;
                    response = new 
                    { 
                        erro = "Ocorreu um erro interno no servidor.", 
                        codigo = "INTERNAL_SERVER_ERROR" 
                    };
                    break;
            }

            httpContext.Response.StatusCode = statusCode;
            await httpContext.Response.WriteAsJsonAsync(response, cancellationToken);
            return true;
        }
    }
}