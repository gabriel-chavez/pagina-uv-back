namespace UNIVidaPortalWeb.Convocatorias.DTOs.ParametricasDTOs
{
    public class ParEstadoPostulacionRequestDTO
    {
        public string Descripcion { get; set; }
        public bool Notificar { get; set; }
        public string ContenidoNotificacion { get; set; }
        public bool Habilitado { get; set; }
    }
}
