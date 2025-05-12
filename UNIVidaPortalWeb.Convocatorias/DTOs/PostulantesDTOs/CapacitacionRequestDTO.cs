namespace UNIVidaPortalWeb.Convocatorias.DTOs.PostulantesDTOs
{
    public class CapacitacionRequestDTO
    {        
       public int ParTipoCapacitacionId { get; set; }
        public string Nombre { get; set; }
        public string CentroEstudios { get; set; }
        public string Pais { get; set; }
        public int HorasAcademicas { get; set; }
        public string Modalidad { get; set; }
        public DateOnly FechaInicio { get; set; }
        public DateOnly FechaFin { get; set; }

    }
}
