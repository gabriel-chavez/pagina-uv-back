namespace UNIVidaPortalWeb.Convocatorias.DTOs.ConvocatoriasDTOs
{
    public class NotificacionRequestDTO
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int ParEstadoConvocatoriaId { get; set; }
        public DateOnly FechaInicio { get; set; }
        public DateOnly FechaTermino { get; set; }
        public int PuntajeMinimo { get; set; }
        public int PuntajeTotal { get; set; }
        public string Descripcion { get; set; }
    }
}
