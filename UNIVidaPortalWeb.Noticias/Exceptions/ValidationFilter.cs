using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace UNIVidaPortalWeb.Noticias.Exceptions
{
    public class ValidationFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var problemDetails = new ValidationProblemDetails(context.ModelState)
                {
                    Status = StatusCodes.Status400BadRequest,
                    Title = "Se produjeron uno o más errores de validación."
                };

                context.Result = new BadRequestObjectResult(problemDetails);
            }
        }

        public void OnActionExecuted(ActionExecutedContext context) { }
    }
}
