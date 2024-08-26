namespace UNIVidaPortalWeb.Cms.DTOs.PaginaDinamicaDTO
{
    public class SeccionRequestDTO
    {
        public int CatTipoSeccionId { get; set; }
        public string Nombre { get; set; }
        public string Titulo { get; set; }
        public string SubTitulo { get; set; }
        public string Clase { get; set; }
        public bool Habilitado { get; set; }
        public int PaginaDinamicaId { get; set; }
        public int Orden { get; set; }
    }
}
