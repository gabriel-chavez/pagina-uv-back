using UNIVidaPortalWeb.Seguridad.Models;

namespace UNIVidaPortalWeb.Seguridad.Services
{
    public interface IAccessService
    {
        IEnumerable<AccessModel> ObtenerTodos();
        bool Validar(string nombreUsuario, string contraseña);
        bool RegistrarUsuario(AccessModel nuevoUsuario);
        bool CambiarContraseña(string nombreUsuario, string nuevaContraseña);
        AccessModel ObtenerPerfilUsuario(string nombreUsuario);
    }
}
