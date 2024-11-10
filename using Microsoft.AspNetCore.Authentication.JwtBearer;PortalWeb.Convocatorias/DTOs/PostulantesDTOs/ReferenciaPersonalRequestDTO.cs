namespace UNIVidaPortalWeb.Convocatorias.DTOs.PostulantesDTOs
{
    public class ReferenciaPersonalRequestDTO
    {
        public int PostulanteId { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public string Empresa { get; set; }
        public string Telefono { get; set; }
        public string TelefonoMovil { get; set; }
        public int ParParentescoId { get; set; }
        public string Email { get; set; }
    }
}
