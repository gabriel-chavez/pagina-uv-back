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


namespace UNIVidaPortalWeb.Seguridad.Services
{
    public class AccessService : IAccessService
    {
        public readonly ContextDatabase _contextoBaseDatos;
        private readonly IConfiguration _configuration;
        private readonly IHttpClient _httpClient;

        public AccessService(ContextDatabase contextoBaseDatos, IConfiguration configuration, IHttpClient httpClient)
        {
            _contextoBaseDatos = contextoBaseDatos;
            _configuration = configuration;
            _httpClient = httpClient;
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
                return new Resultado(false, "El correo electrónico no está registrado.");
            }
            
            var token = Guid.NewGuid().ToString();

            usuario.TokenRecuperacion = token;
            usuario.TokenExpira = DateTime.UtcNow.AddHours(1);  // Token expira en 1 hora
            _contextoBaseDatos.SaveChanges();

            // Enviar correo con enlace de recuperación
            //var enlaceRecuperacion = $"{_servicioCorreo.ObtenerUrlFrontend()}/recuperar?token={token}";
            //_servicioCorreo.EnviarCorreoRecuperacion(usuario.Email, enlaceRecuperacion);

            return new Resultado(true, "Se ha enviado un enlace de recuperación a su correo electrónico.");
        }
        public Resultado RestablecerContraseña(string token, string nuevaContraseña)
        {
            var usuario = _contextoBaseDatos.Access.FirstOrDefault(x => x.TokenRecuperacion == token && x.TokenExpira > DateTime.UtcNow);

            if (usuario == null)
            {
                return new Resultado(false, "El token no es válido o ha expirado.");
            }

            // Validar longitud mínima de la contraseña
            if (nuevaContraseña.Length < 8)
            {
                throw new ValidationException("La contraseña debe tener al menos 8 caracteres.");
            }

            // Encriptar y actualizar la contraseña
            usuario.Password = EncriptarContraseña(nuevaContraseña);
            usuario.TokenRecuperacion = null;  // Invalida el token después de usarlo
            usuario.TokenExpira = DateTime.MinValue;
            _contextoBaseDatos.SaveChanges();

            return new Resultado(true, "Contraseña actualizada correctamente.");
        }







        //string uri = _configuration["proxy:urlConvocatoria"];

        //HttpResponseMessage response = _httpClient.GetAsync(uri  + usuarioId).GetAwaiter().GetResult();

        //if (response.IsSuccessStatusCode)
        //{
        //    string responseBody = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
        //    Console.WriteLine("Respuesta exitosa: " + responseBody);
        //}

        //response.EnsureSuccessStatusCode();
        //return response;



    }
}
