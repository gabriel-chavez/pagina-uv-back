namespace UNIVidaPortalWeb.Convocatorias.Models.ConvocatoriasModel
{
    public class ExperienciaPuntos:BaseDomainModel
    {
        public int ConvocatoriaId { get; set; }
        public int Desde { get; set; }
        public int Hasta { get; set; }
        public int Puntos { get; set; }

        public bool Especifica { get; set; }

        public virtual Convocatoria Convocatoria { get; set; }
    }
}
