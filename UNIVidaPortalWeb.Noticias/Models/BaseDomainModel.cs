using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace UNIVidaPortalWeb.Noticias.Models
{
    public abstract class BaseDomainModel
    {
        [JsonProperty(Order = 1)]
        public int Id { get; set; }
        [Column(TypeName = "timestamp without time zone")]
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        [Column(TypeName = "timestamp without time zone")]
        public DateTime? LastModifiedDate { get; set; }
        public string? LastModifiedBy { get; set; }
    }
}
