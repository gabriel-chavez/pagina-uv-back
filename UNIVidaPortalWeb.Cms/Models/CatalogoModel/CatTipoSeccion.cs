namespace UNIVidaPortalWeb.Cms.Models.CatalogoModel
{
    public class CatTipoSeccion : BaseDomainModel
    {
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } =string.Empty;
        public bool Habilitado { get; set; }
    }

}
