namespace UNIVidaPortalWeb.Cms.DTOs.SegurosDTO
{
    public class SeguroRequestDTO
    {
        public int SeguroId { get; set; }

        public string Titulo { get; set; } = string.Empty;
        public string Respuesta { get; set; } = string.Empty;
        public int Orden { get; set; }

    }
}
