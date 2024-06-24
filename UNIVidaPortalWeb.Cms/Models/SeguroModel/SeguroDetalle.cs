using UNIVidaPortalWeb.Cms.Models.CatalogoModel;

namespace UNIVidaPortalWeb.Cms.Models.SeguroModel
{
    public class SeguroDetalle : BaseDomainModel
    {
        public int SeguroId { get; set; }

        public string Titulo { get; set; } = string.Empty;
        public string Respuesta { get; set; }   =string.Empty;
        public int Orden { get; set; }

        // Propiedad de navegación
        public virtual Seguro Seguro { get; set; }
  
    }
}
