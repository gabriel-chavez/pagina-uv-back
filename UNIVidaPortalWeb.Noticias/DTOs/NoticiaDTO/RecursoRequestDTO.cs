namespace UNIVidaPortalWeb.Noticias.DTOs.NoticiaDTO
{
    public class RecursoRequestDTO
    {        
        public string Nombre { get; set; } = "";
        public int ParTipoRecursoId { get; set; }
        public string RecursoEscritorio { get; set; } = "";
        public string? RecursoMovil { get; set; }
    }
}
