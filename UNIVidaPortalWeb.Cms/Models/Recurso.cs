namespace UNIVidaPortalWeb.Cms.Models
{
    public class Recurso
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int CatTipoRecursoId { get; set; }
        public string RecursoEscritorio { get; set; }
        public string RecursoMovil { get; set; }

        public virtual CatTipoRecurso CatTipoRecurso { get; set; }
    }
}
