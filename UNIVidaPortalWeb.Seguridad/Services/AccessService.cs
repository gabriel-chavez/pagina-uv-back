using UNIVidaPortalWeb.Seguridad.Models;
using UNIVidaPortalWeb.Seguridad.Respositories;

namespace UNIVidaPortalWeb.Seguridad.Services
{
    public class AccessService : IAccessService
    {
        public readonly ContextDatabase _contextDatabase;
        public AccessService(ContextDatabase contextDatabase)
        {
            _contextDatabase = contextDatabase;
        }
        public IEnumerable<AccessModel> GetAll()
        {
            return _contextDatabase.Access.ToList();
        }

        public bool Validate(string userName, string password)
        {
            var list = _contextDatabase.Access.ToList();
            var access = list.Where(x => x.Username == userName && x.Password == password).FirstOrDefault();
            if(access!=null)
                return true;
            return false;
        }
    }
}
