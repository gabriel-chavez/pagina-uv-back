
using UNIVidaPortalWeb.Cms.Models.MenuModel;
using UNIVidaPortalWeb.Cms.Models.RecursoModel;

namespace UNIVidaPortalWeb.Cms.Models.PaginaDinamicaModel
{
    public class PaginaDinamica : BaseDomainModel
    {
        public string Nombre { get; set; } = string.Empty;        
        public bool Habilitado { get; set; } = true;

        // Propiedad de navegación para los menús asociados
        public virtual ICollection<MenuPrincipal>? MenuPrincipal { get; set; } = new List<MenuPrincipal>();

        public virtual ICollection<BannerPagina>? BannerPaginas { get; set; }
    }
}
