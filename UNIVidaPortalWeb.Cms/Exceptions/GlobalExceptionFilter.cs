using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace UNIVidaPortalWeb.Cms.Exceptions
{
    public class GlobalExceptionFilter : IExceptionFilter
    {
        private readonly ILogger<GlobalExceptionFilter> _logger;

        public GlobalExceptionFilter(ILogger<GlobalExceptionFilter> logger)
        {
            _logger = logger;
        }

        public void OnException(ExceptionContext context)
        {
            
            if (context.Exception is NotFoundException)
            {
                _logger.LogInformation(context.Exception, "Recurso no encontrado");
                context.Result = new NotFoundObjectResult(new ProblemDetails
                {
                    Status = StatusCodes.Status404NotFound,
                    Title = "Recurso no encontrado",
                    Detail = context.Exception.Message
                });
            }
            else if (context.Exception is ValidationException)
            {
                _logger.LogInformation(context.Exception, "Error de validación");
                context.Result = new BadRequestObjectResult(new ProblemDetails
                {
                    Status = StatusCodes.Status400BadRequest,
                    Title = "Error de validación",
                    Detail = context.Exception.Message
                });
            }
            else
            {       
                _logger.LogError(context.Exception, "Ocurrió una excepción no controlada.");
                context.Result = new ObjectResult(new ProblemDetails
                {
                    Status = StatusCodes.Status500InternalServerError,
                    Title = "¡Ocurrió un error inesperado!",
                    Detail = context.Exception.Message
                })
                {
                    StatusCode = StatusCodes.Status500InternalServerError
                };
            }

            context.ExceptionHandled = true;
        }

    }
}
