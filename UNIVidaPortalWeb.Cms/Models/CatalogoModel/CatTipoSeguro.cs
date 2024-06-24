namespace UNIVidaPortalWeb.Cms.Models.CatalogoModel
{
    public class CatTipoSeguro : BaseDomainModel
    {
        public string Nombre { get; set; } = string.Empty;        
        public bool Habilitado { get; set; }
    }
}
