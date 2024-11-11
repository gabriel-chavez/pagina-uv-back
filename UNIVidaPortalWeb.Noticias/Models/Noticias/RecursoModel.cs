using UNIVidaPortalWeb.Noticias.Models.Parametricas;

namespace UNIVidaPortalWeb.Noticias.Models.Noticias
{
    public class RecursoModel : BaseDomainModel
    {
        public string Nombre { get; set; } = "";
        public int ParTipoRecursoId { get; set; }
        public string RecursoEscritorio { get; set; } = "";
        public string? RecursoMovil { get; set; }

        public virtual ParTipoRecursoModel ParTipoRecurso { get; set; }
        // Relación inversa
        public virtual ICollection<NoticiaModel> Noticia { get; set; }

    }
}
