namespace UNIVidaPortalWeb.Convocatorias.DTOs.PostulantesDTOs
{
    public class FormacionAcademicaRequestDTO
    {        
        public int ParNivelFormacionId { get; set; }
        public string CentroEstudios { get; set; }
        public string TituloObtenido { get; set; }
        public DateOnly FechaTitulo { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }
    }
}
