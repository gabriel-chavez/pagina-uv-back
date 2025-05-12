using UNIVidaPortalWeb.Convocatorias.Services.UsuariosServices;

namespace UNIVidaPortalWeb.Convocatorias.Middleware
{
    public class UserIdMiddleware
    {
        private readonly RequestDelegate _next;

        public UserIdMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext, IUserService userContextService)
        {
            if (httpContext.Request.Headers.TryGetValue("userId", out var userIdHeader))
            {
                if (int.TryParse(userIdHeader, out var userId))
                {
                    userContextService.SetUserId(userId);
                }
                else
                {
                    userContextService.SetUserId(0);
                }
            }
            else
            {
                userContextService.SetUserId(0);
            }

            await _next(httpContext);
        }
    }
}