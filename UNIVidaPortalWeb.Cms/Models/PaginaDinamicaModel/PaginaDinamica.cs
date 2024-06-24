namespace UNIVidaPortalWeb.Cms.Models.PaginaDinamicaModel
{
    public class PaginaDinamica : BaseDomainModel
    {
        public string Nombre { get; set; } = "";
        public string Ruta { get; set; } = "";
        public bool Visible { get; set; } = true;
    }

}
