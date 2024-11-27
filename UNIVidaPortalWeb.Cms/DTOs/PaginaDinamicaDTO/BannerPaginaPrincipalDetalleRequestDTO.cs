namespace UNIVidaPortalWeb.Cms.DTOs.PaginaDinamicaDTO
{
    public class BannerPaginaPrincipalDetalleRequestDTO
    {
        public string Titulo { get; set; }
        public string? Texto { get; set; }
        public string Enlace { get; set; }
        public int RecursoId { get; set; }
        public int BannerPaginaPrincipalMaestroId { get; set; }
        public bool Habilitado { get; set; }
    }
}
