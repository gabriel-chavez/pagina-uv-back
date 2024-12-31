using UNIVidaPortalWeb.Seguridad.Models;
using UNIVidaPortalWeb.Seguridad.Utilities;

namespace UNIVidaPortalWeb.Seguridad.Services
{
    public interface IAccessService
    {
        IEnumerable<AccessModel> ObtenerTodos();
        int? Validar(string nombreUsuarioEmail, string contraseña);
        void RegistrarUsuario(AccessModel nuevoUsuario);
        bool CambiarContraseña(int userId, string nuevaContraseña);
        AccessModel ObtenerPerfilUsuario(string nombreUsuarioEmail);

        Task<string> ObtenerPostulanteId(int usuarioId);
        Resultado IniciarRecuperacionContraseña(string email);
        Resultado RestablecerContraseña(string token, string nuevaContraseña);
    }
}
