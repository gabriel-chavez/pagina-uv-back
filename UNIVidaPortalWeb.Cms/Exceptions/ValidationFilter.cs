using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using UNIVidaPortalWeb.Cms.Utilidades; // Importar la clase Resultado

namespace UNIVidaPortalWeb.Cms.Exceptions
{
    public class ValidationFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                // Generar una lista de errores de validación
                var errores = context.ModelState
                    .Where(ms => ms.Value.Errors.Count > 0)
                    .ToDictionary(
                        ms => ms.Key,
                        ms => ms.Value.Errors.Select(e => e.ErrorMessage).ToArray()
                    );

                // Crear un mensaje de error combinado
                string mensajeError = "Se produjeron uno o más errores de validación.";

                // Crear la respuesta genérica usando el objeto Resultado
                var resultado = new Resultado<Dictionary<string, string[]>>(errores, false, mensajeError);

                // Retornar el resultado con un BadRequest usando el objeto Resultado
                context.Result = new BadRequestObjectResult(resultado);
            }
        }

        public void OnActionExecuted(ActionExecutedContext context) { }
    }
}
