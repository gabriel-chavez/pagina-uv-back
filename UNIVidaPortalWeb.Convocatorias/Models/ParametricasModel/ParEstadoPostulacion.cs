namespace UNIVidaPortalWeb.Convocatorias.Models.ParametricasModel
{
    public class ParEstadoPostulacion : BaseDomainModel
    {
        public string Descripcion { get; set; }
        public bool Notificar { get; set; } 
        public string ContenidoNotificacion { get; set; } 
        public bool Habilitado { get; set; }
    }

}
