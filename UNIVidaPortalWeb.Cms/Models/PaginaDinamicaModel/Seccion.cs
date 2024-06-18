using UNIVidaPortalWeb.Cms.Models.CatalogoModel;

namespace UNIVidaPortalWeb.Cms.Models.PaginaDinamicaModel
{
    public class Seccion : BaseDomainModel
    {
        public int Id { get; set; }
        public int CatTipoSeccionId { get; set; }
        public string Nombre { get; set; }
        public string Titulo { get; set; }
        public string SubTitulo { get; set; }
        public string Clase { get; set; }
        public int PaginaDinamicaId { get; set; }
        public int Orden { get; set; }

        public virtual CatTipoSeccion CatTipoSeccion { get; set; }
        public virtual PaginaDinamica PaginaDinamica { get; set; }

    }
}
