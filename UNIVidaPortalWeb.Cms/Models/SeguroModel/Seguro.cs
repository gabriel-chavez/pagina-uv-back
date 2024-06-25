using UNIVidaPortalWeb.Cms.Models.CatalogoModel;
using UNIVidaPortalWeb.Cms.Models.MenuModel;
using UNIVidaPortalWeb.Cms.Models.RecursoModel;

namespace UNIVidaPortalWeb.Cms.Models.SeguroModel
{
    public class Seguro : BaseDomainModel
    {
        public string Nombre { get; set; } = string.Empty;
        public string NombreCorto { get; set; } = string.Empty;
        public int? MenuPrincipalId { get; set; }
        public string DetalleAdicional { get; set; } = string.Empty;
        public int? RecursoId { get; set; }
        public string? Icono { get; set; }
        public int Orden { get; set; }
        public bool Habilitado { get; set; } = true;
        public int? CatTipoSeguroId { get; set; }

        // Propiedades de navegación
        public virtual Recurso? Recurso { get; set; }
        public virtual MenuPrincipal? MenuPrincipal { get; set; }
        public virtual CatTipoSeguro CatTipoSeguro { get; set; } = new CatTipoSeguro();
        public virtual ICollection<Plan> Planes { get; set; } = new List<Plan>();
        public virtual ICollection<SeguroDetalle> SeguroDetalles { get; set; } = new List<SeguroDetalle>();
        public virtual ICollection<BannerPagina> BannerPagina { get; set; } = new List<BannerPagina>();
        


    }
}
