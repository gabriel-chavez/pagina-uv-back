using Jose;
using Newtonsoft.Json;
using System.Security.Cryptography;
using System.Text;
using UNIVidaPortalWeb.GatewayExterno.Utilities;

namespace UNIVidaPortalWeb.GatewayExterno.Middleware
{
    public class MiddlewareCifradoJwt
    {
        private readonly RequestDelegate _next;
        private readonly string _secretKey;

        public MiddlewareCifradoJwt(RequestDelegate next, IConfiguration configuration)
        {
            _next = next;
            _secretKey = configuration["claveCifrado"];  // Obtener la clave secreta desde appsettings.json
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Verificar si la solicitud es al endpoint de login
            if (context.Request.Path.Equals("/api/auth/login", StringComparison.OrdinalIgnoreCase) && context.Request.Method == "POST")
            {
                var response = context.Response;
                var originalBodyStream = response.Body;
                using (var responseBody = new System.IO.MemoryStream())
                {
                    response.Body = responseBody;

                    // Continuar con el siguiente middleware
                    await _next(context);

                    responseBody.Seek(0, System.IO.SeekOrigin.Begin);
                    var jsonResponse = new System.IO.StreamReader(responseBody).ReadToEnd();

                    // Si la respuesta contiene un token, lo firmamos con HS256
                    if (jsonResponse.Contains("token"))
                    {
                        try
                        {
                            var resultado = JsonConvert.DeserializeObject<Resultado<ResultadoToken>>(jsonResponse);


                            var token = resultado.Datos.Token;

                            var jwtFirmado = CifrarJwt(token);

                            resultado.Datos.Token = jwtFirmado;

                            jsonResponse = JsonConvert.SerializeObject(resultado);
                        }
                        catch (Exception ex)
                        {

                            throw;
                        }



                    }
                    response.Body = originalBodyStream;  
                    await response.Body.WriteAsync(Encoding.UTF8.GetBytes(jsonResponse));
                }
            }
            else
            {
                await _next(context);
            }
        }

        private string CifrarJwt(string jwt)
        {
            
            byte[] key = Encoding.UTF8.GetBytes(_secretKey);
            string jwtFirmado = JWT.Encode(
                jwt,
                key,
                JweAlgorithm.DIR,
                JweEncryption.A256GCM
            );

            return jwtFirmado;
        }
    }

}
