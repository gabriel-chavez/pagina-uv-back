using UNIVidaPortalWeb.Seguridad.Models;

namespace UNIVidaPortalWeb.Seguridad.Services
{
    public interface IAccessService
    {
        IEnumerable<AccessModel> GetAll();
        bool Validate(string userName, string password);
    }
}
