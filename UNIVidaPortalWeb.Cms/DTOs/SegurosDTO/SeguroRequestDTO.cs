namespace UNIVidaPortalWeb.Cms.DTOs.SegurosDTO
{
    public class SeguroRequestDTO
    {
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public string DetalleAdicional { get; set; } = string.Empty;
        public int? RecursoId { get; set; }
        public string? Icono { get; set; }
        public int Orden { get; set; }
        public bool Visible { get; set; } = true;
    }
}
