namespace UNIVidaPortalWeb.Convocatorias.Models.PostulantesModel
{
    public class ReferenciaLaboral:BaseDomainModel
    {        
        public int PostulanteId { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public string Empresa { get; set; }
        public string Telefono { get; set; }
        public string TelefonoMovil { get; set; }
        public string Relacion { get; set; }
        public string Email { get; set; }

        // Relaciones
        public Postulante Postulante { get; set; }
    }

}
