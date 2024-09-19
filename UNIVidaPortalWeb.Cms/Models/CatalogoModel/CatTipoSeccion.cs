namespace UNIVidaPortalWeb.Cms.Models.CatalogoModel
{
    public class CatTipoSeccion : BaseDomainModel
    {
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } =string.Empty;
        public string ImagenSeccion { get; set; } = string.Empty;
        public string ImagenSeccionGuia { get; set; } = string.Empty;
        public bool Habilitado { get; set; }
    }

}
