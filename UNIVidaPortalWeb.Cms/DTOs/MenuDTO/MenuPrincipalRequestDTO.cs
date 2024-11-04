namespace UNIVidaPortalWeb.Cms.DTOs.MenuDTO
{
    public class MenuPrincipalRequestDTO
    {
        public string Nombre { get; set; } = string.Empty;
        public string? Url { get; set; } = string.Empty;
        public int? IdPadre { get; set; }
        public bool Habilitado { get; set; } = true;
        public bool Visible { get; set; } = true;
        public int Orden { get; set; }
        public int? IdPaginaDinamica { get; set; } // Permitir nulo
        public int? IdSeguro { get; set; } // Permitir nulo
    }
}
