namespace UNIVidaPortalWeb.Cms.DTOs.PaginaDinamicaDTO
{
    public class BannerPaginaPrincipalMaestroRequestDTO
    {
        public string Nombre { get; set; }
        public int CatTipoBannerPaginaPrincipalId { get; set; } //principal, secundario
        public int CatEstiloBannerId { get; set; }
        public bool Habilitado { get; set; }
    }
}
