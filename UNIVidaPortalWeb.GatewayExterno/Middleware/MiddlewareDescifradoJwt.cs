using Jose;
using System.Text;

namespace UNIVidaPortalWeb.GatewayExterno.Middleware
{
    public class MiddlewareDescifradoJwt
    {
        private readonly RequestDelegate _next;
        private readonly string _secretKey;

        public MiddlewareDescifradoJwt(RequestDelegate next, IConfiguration configuration)
        {
            _next = next;
            _secretKey = configuration["claveCifrado"];   // Obtener la clave secreta desde appsettings.json
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Verificar si la solicitud tiene un JWT cifrado en el encabezado "Authorization"
            var tokenCifrado = context.Request.Headers["Authorization"].ToString().Replace("Bearer ", "");

            if (!string.IsNullOrEmpty(tokenCifrado))
            {
                try
                {
                    // Descifrar el JWT utilizando la misma clave secreta
                    var jwtDescifrado = DescifrarJwt(tokenCifrado);

                    // Reemplazar el token cifrado con el token descifrado en la cabecera Authorization
                    context.Request.Headers["Authorization"] = "Bearer " + jwtDescifrado;

                    // Continuar con el siguiente middleware
                    await _next(context);
                }
                catch (Exception ex)
                {
                    context.Request.Headers["Authorization"] = "Bearer " + tokenCifrado;
                    await _next(context);
                }
            }
            else
            {
                // Si no hay token cifrado, continuar con la solicitud
                await _next(context);
            }
        }

        private string DescifrarJwt(string jwtCifrado)
        {
            try
            {
                // Usamos la misma clave secreta para descifrar
                var key = Encoding.UTF8.GetBytes(_secretKey);

                // Descifrar el JWT utilizando JOSE (JWE)
                var jwtDescifrado = JWT.Decode(jwtCifrado, key, JweAlgorithm.DIR, JweEncryption.A256GCM);

                return jwtDescifrado;  // Retornar el JWT descifrado
            }
            catch (Exception ex)
            {
                // Manejo de errores en caso de que el descifrado falle
                Console.WriteLine("Error al descifrar el JWT: " + ex.Message);
                throw;
            }
        }
    }
}
