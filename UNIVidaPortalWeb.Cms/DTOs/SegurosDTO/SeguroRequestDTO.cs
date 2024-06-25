namespace UNIVidaPortalWeb.Cms.DTOs.SegurosDTO
{
    public class SeguroRequestDTO
    {
        public string Nombre { get; set; } = string.Empty;
        public string NombreCorto { get; set; } = string.Empty;
        public int? MenuId { get; set; }
        public string DetalleAdicional { get; set; } = string.Empty;
        public int? RecursoId { get; set; }
        public string? Icono { get; set; }
        public int Orden { get; set; }
        public bool Habilitado { get; set; } = true;
        public int? CatTipoSeguroId { get; set; }
    }
}
