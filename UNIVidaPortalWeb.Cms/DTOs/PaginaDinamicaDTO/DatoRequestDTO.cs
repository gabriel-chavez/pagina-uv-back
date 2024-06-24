namespace UNIVidaPortalWeb.Cms.DTOs.PaginaDinamicaDTO
{
    public class DatoRequestDTO
    {
        public string DatoTexto { get; set; }
        public DateTime DatoFechaHora { get; set; }
        public string DatoUrl { get; set; }
        public int RecursoId { get; set; }
        public int SeccionId { get; set; }
        public int Fila { get; set; }
        public int Columna { get; set; }
    }
}
