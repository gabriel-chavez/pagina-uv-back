namespace UNIVidaPortalWeb.Cms.DTOs.SegurosDTO
{
    public class SeguroDetalleRequestDTO
    {
        public int SeguroId { get; set; }
        public int CatTipoSeguroDetalleId { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Respuesta { get; set; } = string.Empty;
        public int Orden { get; set; }
        public string DetalleAdicional { get; set; } = string.Empty;

    }
}
