namespace UNIVidaPortalWeb.Cms.Models.SeguroModel
{
    public class Plan:BaseDomainModel
    {        
        public int SeguroId { get; set; }
        public string Titulo { get; set; } = string.Empty;      
        public string SubTitulo { get; set; } = string.Empty;
        public decimal Precio { get; set; }
        public string Cobertura { get; set; } = string.Empty;
        public int Orden { get; set; }
        public bool Habilitado { get; set; } = true;

        // Propiedad de navegación
        public virtual Seguro Seguro { get; set; }
    }
}
