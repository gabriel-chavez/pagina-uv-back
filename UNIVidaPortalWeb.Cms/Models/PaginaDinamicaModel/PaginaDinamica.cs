using UNIVidaPortalWeb.Cms.Models.MenuModel;

namespace UNIVidaPortalWeb.Cms.Models.PaginaDinamicaModel
{
    public class PaginaDinamica : BaseDomainModel
    {
        public string Nombre { get; set; } = "";
        public int? MenuPrincipalId { get; set; }
        public bool Habilitado { get; set; } = true;

        public virtual MenuPrincipal? MenuPrincipal { get; set; }
    }

}
