using UNIVidaPortalWeb.Convocatorias.Models.ParametricasModel;

namespace UNIVidaPortalWeb.Convocatorias.Models.ConvocatoriasModel
{
    public class NivelFormacionPuntos: BaseDomainModel
    {
        public int ConvocatoriaId { get; set; }
        public int ParNivelFormacionId { get; set; }
        public int Puntos { get; set; }


        public virtual Convocatoria Convocatoria { get; set; }
        public virtual ParNivelFormacion ParNivelFormacion { get; set; }
    }
}
 