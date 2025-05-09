using System.Text;
using UNIVidaPortalWeb.Seguridad.Models;
using UNIVidaPortalWeb.Seguridad.Respositories;
using System.Security.Cryptography;
using UNIVidaPortalWeb.Common.Http.Src;
using Polly;
using Polly.CircuitBreaker;
using System.Text.RegularExpressions;
using UNIVidaPortalWeb.Seguridad.Utilities;
using UNIVidaPortalWeb.Seguridad.Exceptions;
using UNIVidaPortalWeb.Common.Email.Src;
using System.Diagnostics.Eventing.Reader;


namespace UNIVidaPortalWeb.Seguridad.Services
{
    public class AccessService : IAccessService
    {
        public readonly ContextDatabase _contextoBaseDatos;
        private readonly IConfiguration _configuration;
        private readonly IHttpClient _httpClient;
        private readonly EmailService _emailService;

        public AccessService(ContextDatabase contextoBaseDatos, IConfiguration configuration, IHttpClient httpClient, EmailService emailService)
        {
            _contextoBaseDatos = contextoBaseDatos;
            _configuration = configuration;
            _httpClient = httpClient;
            _emailService=emailService;
        }

        public IEnumerable<AccessModel> ObtenerTodos()
        {
            return _contextoBaseDatos.Access.ToList();
        }

        public int? Validar(string nombreUsuarioEmail, string contraseña)
        {            
            var usuario = _contextoBaseDatos.Access
                .FirstOrDefault(x => x.Username == nombreUsuarioEmail || x.Email == nombreUsuarioEmail);
            if (usuario == null) return null;
            var contraseñaEncriptada = EncriptarContraseña(contraseña);
            if (usuario.Password != contraseñaEncriptada) return null;            
            return usuario.UserId;
        }


        private string EncriptarContraseña(string contraseña)
        {
            using (var sha256 = SHA256.Create())
            {
                var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(contraseña));
                return BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }
        }

        public void RegistrarUsuario(AccessModel nuevoUsuario)
        {
            // Validar formato de email
            var emailRegex = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(nuevoUsuario.Email, emailRegex))
            {
                throw new ValidationException("El formato del correo electrónico es inválido.");
            }
            // Validar que ingrese el nombre de usuario
            if (string.IsNullOrWhiteSpace(nuevoUsuario.Username))
            {
                throw new ValidationException("El nombre de usuario es obligatorio.");
            }
            // Validar si el nombre de usuario ya existe
            if (_contextoBaseDatos.Access.Any(x => x.Username == nuevoUsuario.Username))
            {
                throw new ValidationException("El nombre de usuario ya existe.");
            }
            // Validar si el correo electrónico ya existe
            if (_contextoBaseDatos.Access.Any(x => x.Email == nuevoUsuario.Email))
            {
                throw new ValidationException("El correo electrónico ya está registrado.");
            }
            if (!EsContraseñaValida(nuevoUsuario.Password))
            {
                throw new ValidationException("La contraseña debe tener al menos 5 caracteres, una letra mayúscula, una minúscula, un número y un carácter especial.");
            }
            // Encriptar contraseña y registrar usuario
            nuevoUsuario.Password = EncriptarContraseña(nuevoUsuario.Password);
            _contextoBaseDatos.Access.Add(nuevoUsuario);
            _contextoBaseDatos.SaveChanges();
        }
        private bool EsContraseñaValida(string password)
        {
            // Al menos 8 caracteres, una mayúscula, una minúscula, un número y un carácter especial            
            var passwordRegex = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\w\d\s])[^\s]{5,}$";

            return Regex.IsMatch(password, passwordRegex);
        }


        public bool CambiarContraseña(int userId, string nuevaContraseña)
        {

            var usuario = _contextoBaseDatos.Access.FirstOrDefault(x => x.UserId == userId);
            if (usuario == null) return false;

            usuario.Password = EncriptarContraseña(nuevaContraseña);
            _contextoBaseDatos.SaveChanges();
            return true;
        }
        
        public AccessModel ObtenerPerfilUsuario(string nombreUsuarioEmail)
        {
            var usuario = _contextoBaseDatos.Access
                .FirstOrDefault(x => x.Username == nombreUsuarioEmail || x.Email == nombreUsuarioEmail);
            if (usuario == null) return null;

            return _contextoBaseDatos.Access.FirstOrDefault(x => x.UserId == usuario.UserId);
        }
        public async Task<string> ObtenerPostulanteId(int usuarioId)
        {
            string uri = _configuration["proxy:urlConvocatoria"];
            var response = await _httpClient.GetStringAsync(uri+usuarioId);
            
            return response;
        }
        public Resultado IniciarRecuperacionContraseña(string email)
        {
            var usuario = _contextoBaseDatos.Access.FirstOrDefault(x => x.Email == email);

            if (usuario == null)
            {
                return new Resultado(false, "Si el usuario existe, se enviará un correo de recuperación.");
            }

            var token = Guid.NewGuid().ToString();

            usuario.TokenRecuperacion = token;
            usuario.TokenExpira = DateTime.UtcNow.AddHours(1);
            _contextoBaseDatos.SaveChanges();

            var urlPagina = _configuration["urlPagina"];
            var enlaceRecuperacion = $"{urlPagina}/reestablecer-contrasena?token={token}";

            string cuerpoCorreo = $@"
                <html>
                <head>
                    <style>
                        .container {{
                            font-family: Arial, sans-serif;
                            text-align: center;
                            margin: 40px auto;
                            padding: 20px;
                            max-width: 600px;
                            border: 1px solid #ddd;
                            border-radius: 8px;
                            background-color: #f9f9f9;
                        }}
                        .btn {{
                            background-color: #007bff;
                            color: white;
                            padding: 10px 20px;
                            text-decoration: none;
                            border-radius: 5px;
                            display: inline-block;
                            margin-top: 20px;
                        }}
                        .footer {{
                            margin-top: 30px;
                            font-size: 12px;
                            color: #777;
                        }}
                    </style>
                </head>
                <body>
                    <div class='container'>
                        <h2>Hola {usuario.Username},</h2>
                        <p>Hemos recibido una solicitud para restablecer tu contraseña.</p>
                        <p>Si no realizaste esta solicitud, puedes ignorar este mensaje.</p>
                        <p>Para restablecer tu contraseña, haz clic en el botón de abajo:</p>
                        <a href='{enlaceRecuperacion}' class='btn'>Restablecer contraseña</a>
                        <p>O también puedes copiar y pegar el siguiente enlace en tu navegador:</p>
                        <p>{enlaceRecuperacion}</p>
                        <div class='footer'>
                            <p>Si tienes algún problema, no dudes en contactarnos.</p>
                            <p>&copy; {DateTime.Now.ToString("yyyy")} - Univida S.A.</p>
                        </div>
                    </div>
                </body>
                </html>";
            var correoEnmascarado = EnmascararCorreo(usuario.Email);
            
            if (_emailService.EnviarCorreo(usuario.Email, "Recuperar contraseña", cuerpoCorreo))
            {
                return new Resultado(true, $"Se ha enviado un enlace de recuperación a su correo electrónico ({correoEnmascarado}).");
            }
            else
            {
                return new Resultado(true, "No se pudo enviar el correo, intente nuevamente mas tarde.");
            }

            
        }

        public Resultado RestablecerContraseña(string token, string nuevaContraseña)
        {
            var usuario = _contextoBaseDatos.Access.FirstOrDefault(x => x.TokenRecuperacion == token && x.TokenExpira > DateTime.UtcNow);

            if (usuario == null)
            {
                return new Resultado(false, "El token no es válido o ha expirado.");
            }

            if (!EsContraseñaValida(nuevaContraseña))
            {
                throw new ValidationException("La contraseña debe tener al menos 5 caracteres, una letra mayúscula, una minúscula, un número y un carácter especial.");
            }
            
            usuario.Password = EncriptarContraseña(nuevaContraseña);
            usuario.TokenRecuperacion = "";  // Invalida el token después de usarlo
            usuario.TokenExpira = DateTime.MinValue;
            _contextoBaseDatos.SaveChanges();

            return new Resultado(true, "Contraseña actualizada correctamente.");
        }

        private string EnmascararCorreo(string email)
        {
            var partes = email.Split('@');
            if (partes.Length == 2)
            {
                var nombre = partes[0];
                var dominio = partes[1];

                if (nombre.Length > 3)
                {
                    return $"{nombre.Substring(0, 3)}***@{dominio}";
                }
                else
                {
                    return $"{nombre.Substring(0, 1)}***@{dominio}";
                }
            }
            return email;
        }

    }
}
