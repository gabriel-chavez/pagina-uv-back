using System.Text;
using UNIVidaPortalWeb.Seguridad.Models;
using UNIVidaPortalWeb.Seguridad.Respositories;
using System.Security.Cryptography;
using UNIVidaPortalWeb.Common.Http.Src;
using Polly;
using Polly.CircuitBreaker;


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

        public bool Validar(string nombreUsuario, string contraseña)
        {
            var usuario = _contextoBaseDatos.Access.FirstOrDefault(x => x.Username == nombreUsuario);
            if (usuario == null) return false;

            var contraseñaEncriptada = EncriptarContraseña(contraseña);
            return usuario.Password == contraseñaEncriptada;
        }

        private string EncriptarContraseña(string contraseña)
        {
            using (var sha256 = SHA256.Create())
            {
                var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(contraseña));
                return BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }
        }

        public bool RegistrarUsuario(AccessModel nuevoUsuario)
        {
            if (_contextoBaseDatos.Access.Any(x => x.Username == nuevoUsuario.Username))
                return false; // Usuario ya existe

            nuevoUsuario.Password = EncriptarContraseña(nuevoUsuario.Password);
            _contextoBaseDatos.Access.Add(nuevoUsuario);
            _contextoBaseDatos.SaveChanges();
            return true;
        }

        public bool CambiarContraseña(string nombreUsuario, string nuevaContraseña)
        {
            var usuario = _contextoBaseDatos.Access.FirstOrDefault(x => x.Username == nombreUsuario);
            if (usuario == null) return false;

            usuario.Password = EncriptarContraseña(nuevaContraseña);
            _contextoBaseDatos.SaveChanges();
            return true;
        }
        
        public AccessModel ObtenerPerfilUsuario(string nombreUsuario)
        {
            return _contextoBaseDatos.Access.FirstOrDefault(x => x.Username == nombreUsuario);
        }
        public async Task<string> ObtenerPostulanteId(int usuarioId)
        {
            string uri = _configuration["proxy:urlConvocatoria"];
            var response = await _httpClient.GetStringAsync(uri+usuarioId);
            
            return response;
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
