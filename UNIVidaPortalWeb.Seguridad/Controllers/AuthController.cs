using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using UNIVidaPortalWeb.Common.Token.Src;
using UNIVidaPortalWeb.Seguridad.Models;
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
            if (!_servicioAcceso.Validar(solicitud.UserName, solicitud.Password))
            {
                return Unauthorized(new Resultado(false, "Credenciales incorrectas"));
            }

            var token = JwtToken.Create(_opcionesJwt);
            Response.Headers.Add("access-control-expose-headers", "Authorization");
            Response.Headers.Add("Authorization", token);

            var datos = new { token };
            var resultado = new Resultado<object>(datos, true, "Inicio de sesión exitoso");
            return Ok(resultado);
        }

        [HttpPost("registrar")]
        public IActionResult RegistrarUsuario([FromBody] AccessModel nuevoUsuario)
        {
            if (!_servicioAcceso.RegistrarUsuario(nuevoUsuario))
            {
                return BadRequest(new Resultado(false, "El usuario ya existe"));
            }

            return Ok(new Resultado(true, "Usuario registrado exitosamente"));
        }

        [HttpPost("cambiar-contraseña")]
        public IActionResult CambiarContraseña([FromBody] ChangePasswordRequest solicitud)
        {
            if (!_servicioAcceso.CambiarContraseña(solicitud.UserName, solicitud.NewPassword))
            {
                return NotFound(new Resultado(false, "Usuario no encontrado"));
            }

            return Ok(new Resultado(true, "Contraseña cambiada exitosamente"));
        }

        [HttpGet("perfil")]
        public IActionResult ObtenerPerfilUsuario(string nombreUsuario)
        {
            var perfil = _servicioAcceso.ObtenerPerfilUsuario(nombreUsuario);
            if (perfil == null)
            {
                return NotFound(new Resultado(false, "Usuario no encontrado"));
            }

            var resultado = new Resultado<AccessModel>(perfil, true, "Perfil obtenido correctamente");
            return Ok(resultado);
        }
    }
}
