
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using System.Text.Json;
using UNIVidaPortalWeb.Common.Email.Src;
using UNIVidaPortalWeb.Common.Token.Src;
using UNIVidaPortalWeb.Seguridad.DTOs;
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
        private readonly EmailService _emailService;



        public AuthController(IAccessService servicioAcceso,
            IOptionsSnapshot<JwtOptions> opcionesJwt, EmailService emailService)
        {
            _servicioAcceso = servicioAcceso;
            _opcionesJwt = opcionesJwt.Value;
            _emailService = emailService;


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
       
           
            



           
            var claims = new List<Claim>
            {
                new Claim("userId", userId.Value.ToString()),
                new Claim("userEmail", email),
         
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
                token
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
        public IActionResult RegistrarUsuario([FromBody] AccessRequestDTO nuevoUsuario)
        {
            AccessModel usuario = new AccessModel();
            usuario.Username = nuevoUsuario.Username;
            usuario.Email = nuevoUsuario.Email;
            usuario.Password = nuevoUsuario.Password;
            usuario.TokenExpira = DateTime.MinValue;
            usuario.TokenRecuperacion = "";
            _servicioAcceso.RegistrarUsuario(usuario);
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
        [HttpPost("RecuperarContrasena")]
        public IActionResult RecuperarContraseña([FromBody] RecuperarContraseñaRequest request)
        {
            var resultado = _servicioAcceso.IniciarRecuperacionContraseña(request.Email);

            if (!resultado.Exito)
            {
                return NotFound(resultado);
            }

            return Ok(resultado);
        }
        [HttpPost("RestablecerContrasena")]
        public IActionResult RestablecerContraseña([FromBody] RestablecerContraseñaRequest request)
        {
            var resultado = _servicioAcceso.RestablecerContraseña(request.Token, request.NuevaContraseña);

            if (!resultado.Exito)
            {
                return BadRequest(resultado);
            }

            return Ok(resultado);
        }


        [HttpPost("enviar-correo")]
        public IActionResult EnviarCorreo([FromBody] EnviarCorreoRequest request)
        {
            var resultado = _emailService.EnviarCorreo(request.To, request.Subject, request.Body);

            if (resultado)
            {
               return Ok(resultado);
           }

            return BadRequest(resultado);
        }

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
