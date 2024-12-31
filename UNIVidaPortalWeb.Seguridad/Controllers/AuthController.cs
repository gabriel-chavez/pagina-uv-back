
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using System.Text.Json;
using UNIVidaPortalWeb.Common.Token.Src;
using UNIVidaPortalWeb.Seguridad.Models;
using UNIVidaPortalWeb.Seguridad.Models.UNIVidaPortalWeb.Convocatorias.Utilidades;
using UNIVidaPortalWeb.Seguridad.Services;
using UNIVidaPortalWeb.Seguridad.Utilities;

namespace UNIVidaPortalWeb.Seguridad.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAccessService _servicioAcceso;
        private readonly JwtOptions _opcionesJwt;
       


        public AuthController(IAccessService servicioAcceso,
            IOptionsSnapshot<JwtOptions> opcionesJwt)
        {
            _servicioAcceso = servicioAcceso;
            _opcionesJwt = opcionesJwt.Value;
       

        }

        [HttpGet]
        public IActionResult ObtenerUsuarios()
        {
            var usuarios = _servicioAcceso.ObtenerTodos();
            var resultado = new Resultado<IEnumerable<AccessModel>>(usuarios, true, "Usuarios obtenidos correctamente");
            return Ok(resultado);
        }

        [HttpPost("login")]
        public IActionResult IniciarSesion([FromBody] AuthRequest solicitud)
        {
            var userId = _servicioAcceso.Validar(solicitud.UserNameEmail, solicitud.Password);

            if (userId == null)
            {
                return Unauthorized(new Resultado(false, "Credenciales incorrectas"));
            }
            var usuario = _servicioAcceso.ObtenerPerfilUsuario(solicitud.UserNameEmail);
            var email = usuario.Email;
            var postulanteId = 0;
            var respuesta = _servicioAcceso.ObtenerPostulanteId(userId.Value).Result;
            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                PropertyNameCaseInsensitive = true
            };
            var datosPostulante = JsonSerializer.Deserialize<Resultado<DatosPostulante>>(respuesta, options);



            if (datosPostulante.Exito)
            {
                postulanteId = datosPostulante.Datos.Id;
            }
            var claims = new List<Claim>
            {
                new Claim("userId", userId.Value.ToString()),
                new Claim("userEmail", email),
                new Claim("postulanteId", postulanteId.ToString())
            };
            var token = JwtToken.Create(_opcionesJwt, claims);

            Response.Cookies.Append("jwt", token, new CookieOptions
            {
                HttpOnly = true,
                Secure = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Production", // Solo en producción
                SameSite = SameSiteMode.Strict,
                Path = "/"
            });

            var datos = new
            {
                token,
                postulanteId
            };
            var resultado = new Resultado<object>(datos, true, "Inicio de sesión exitoso");
            return Ok(resultado);
        }
        [HttpPost("logout")]
        public IActionResult CerrarSesion()
        {
            Response.Cookies.Delete("jwt", new CookieOptions
            {
                HttpOnly = true,
                Secure = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Production",
                SameSite = SameSiteMode.Strict,
                Path = "/"
            });

            var resultado = new Resultado(true, "Sesión cerrada exitosamente");
            return Ok(resultado);
        }

        [HttpPost("registrar")]
        public IActionResult RegistrarUsuario([FromBody] AccessModel nuevoUsuario)
        {
            _servicioAcceso.RegistrarUsuario(nuevoUsuario);
            return Ok(new Resultado(true, "Usuario registrado con éxito."));
        }

        [HttpPost("cambiar-contraseña")]
        public IActionResult CambiarContraseña([FromBody] ChangePasswordRequest solicitud)
        {
            var userId = _servicioAcceso.Validar(solicitud.UserNameEmail, solicitud.Password);

            if (userId == null)
            {
                return Unauthorized(new Resultado(false, "Credenciales incorrectas"));
            }

            if (!_servicioAcceso.CambiarContraseña(userId.Value, solicitud.NewPassword))
            {
                return NotFound(new Resultado(false, "Usuario no encontrado"));
            }

            return Ok(new Resultado(true, "Contraseña cambiada exitosamente"));
        }
        [HttpPost("RecuperarContraseña")]
        public IActionResult RecuperarContraseña([FromBody] RecuperarContraseñaRequest request)
        {
            var resultado = _servicioAcceso.IniciarRecuperacionContraseña(request.Email);

            if (!resultado.Exito)
            {
                return NotFound(resultado);
            }

            return Ok(resultado);
        }
        //[HttpPost("RestablecerContraseña")]
        //public IActionResult RestablecerContraseña([FromBody] RestablecerContraseñaRequest request)
        //{
        //    var resultado = _servicioAcceso.RestablecerContraseña(request.Token, request.NuevaContraseña);

        //    if (!resultado.Exito)
        //    {
        //        return BadRequest(resultado);
        //    }

        //    return Ok(resultado);
        //}


        //[HttpPost("enviar-correo")]
        //public IActionResult EnviarCorreo([FromBody] EnviarCorreoRequest request)
        //{
        //    var resultado = _emailService.EnviarCorreo(request.To, request.Subject, request.Body);

        //    if (resultado.Exito)
        //    {
        //        return Ok(resultado);
        //    }

        //    return BadRequest(resultado);
        //}

        [HttpGet("perfil")]
        public IActionResult ObtenerPerfilUsuario(string nombreUsuarioEmail)
        {
            var perfil = _servicioAcceso.ObtenerPerfilUsuario(nombreUsuarioEmail);
            if (perfil == null)
            {
                return NotFound(new Resultado(false, "Usuario no encontrado"));
            }

            var resultado = new Resultado<AccessModel>(perfil, true, "Perfil obtenido correctamente");
            return Ok(resultado);
        }
    }
}
