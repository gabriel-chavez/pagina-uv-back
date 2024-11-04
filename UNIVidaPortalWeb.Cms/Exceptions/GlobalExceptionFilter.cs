using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using UNIVidaPortalWeb.Cms.Utilidades; // Importar la clase Resultado

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
            // Código de estado predeterminado para errores internos del servidor
            var statusCode = StatusCodes.Status500InternalServerError;
            string mensajePorDefecto = "Ocurrió un error inesperado en el servidor";
            string mensaje = mensajePorDefecto;

            // Manejar diferentes tipos de excepciones
            if (context.Exception is NotFoundException)
            {
                mensaje = "Recurso no encontrado";
                _logger.LogInformation(context.Exception, string.IsNullOrWhiteSpace(context.Exception.Message) ? mensaje : context.Exception.Message);
                statusCode = StatusCodes.Status404NotFound;
                
            }
            else if (context.Exception is ValidationException)
            {
                mensaje = "Error de validación";
                _logger.LogInformation(context.Exception, string.IsNullOrWhiteSpace(context.Exception.Message) ? mensaje : context.Exception.Message);
                statusCode = StatusCodes.Status400BadRequest;
                
            }
            else if (context.Exception is ArgumentNullException)
            {
                mensaje = "Argumento nulo detectado";
                _logger.LogError(context.Exception, "Argumento nulo detectado");
                statusCode = StatusCodes.Status400BadRequest;
                
            }
            else
            {
                _logger.LogError(context.Exception, string.IsNullOrWhiteSpace(context.Exception.Message) ? mensaje : context.Exception.Message);                
            }

            // Si la excepción tiene un mensaje, mantenerlo; de lo contrario, usar el mensaje por defecto
            mensaje = string.IsNullOrWhiteSpace(context.Exception.Message) ? mensaje : context.Exception.Message;

            // Crear el objeto Resultado para el error
            var resultadoError = new Resultado(false, mensaje);

            // Devolver la respuesta usando el objeto Resultado
            context.Result = new ObjectResult(resultadoError)
            {
                StatusCode = statusCode
            };

            context.ExceptionHandled = true;
        }
    }
}
