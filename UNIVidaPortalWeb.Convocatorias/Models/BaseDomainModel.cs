using System.ComponentModel.DataAnnotations.Schema;

namespace UNIVidaPortalWeb.Convocatorias.Models
{
    public abstract class BaseDomainModel
    {
        public int Id { get; set; }
        [Column(TypeName = "timestamp without time zone")]

        public DateTime? FechaCreacion { get; set; }
        public string? CreadoPor { get; set; }
        [Column(TypeName = "timestamp without time zone")]

        public DateTime? FechaModificacion { get; set; }
        public string? ModificadoPor { get; set; }
    }
}
