using System.Net;
using UNIVidaPortalWeb.Convocatorias.Utilidades; // Importar tu clase Resultado

namespace UNIVidaPortalWeb.Convocatorias.Exceptions
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionMiddleware> _logger;

        public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Excepción no controlada: {ex.Message}");
                await HandleExceptionAsync(httpContext, ex);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            // Definir el código de estado para el error
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            // Crear el objeto Resultado para manejar el error
            var resultadoError = new Resultado(false, "Ocurrió un error en el servidor");
           

            // Puedes incluir más detalles en el mensaje, si lo prefieres
            if (context.Response.StatusCode == (int)HttpStatusCode.InternalServerError)
            {
                _logger.LogError($"Detalles del error: {exception.Message}");
                resultadoError = new Resultado(false, $"Ocurrió un error: {exception.Message}");
            }

            return context.Response.WriteAsJsonAsync(resultadoError);
        }
    }
}
