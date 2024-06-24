namespace UNIVidaPortalWeb.Cms.DTOs.SegurosDTO
{
    public class PlanRequestDTO
    {
        public int SeguroId { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string SubTitulo { get; set; } = string.Empty;
        public decimal Precio { get; set; }
        public string Cobertura { get; set; } = string.Empty;
        public int Orden { get; set; }
    }
}
