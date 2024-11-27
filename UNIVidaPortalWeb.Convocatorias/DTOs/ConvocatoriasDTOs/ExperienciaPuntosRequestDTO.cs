namespace UNIVidaPortalWeb.Convocatorias.DTOs.ConvocatoriasDTOs
{
    public class ExperienciaPuntosRequestDTO
    {
        public int ConvocatoriaId { get; set; }
        public int Desde { get; set; }
        public int Hasta { get; set; }
        public int Puntos { get; set; }
    }
}
