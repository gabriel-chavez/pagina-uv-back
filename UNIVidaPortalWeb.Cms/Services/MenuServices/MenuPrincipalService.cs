using UNIVidaPortalWeb.Cms.Models.MenuModel;
using UNIVidaPortalWeb.Cms.Repositories;

namespace UNIVidaPortalWeb.Cms.Services.MenuServices
{
    public class MenuPrincipalService : RepositoryBase<MenuPrincipal>, IMenuPrincipalService
    {
        public MenuPrincipalService(DbContextCms context) : base(context)
        {
        }
    }
}
