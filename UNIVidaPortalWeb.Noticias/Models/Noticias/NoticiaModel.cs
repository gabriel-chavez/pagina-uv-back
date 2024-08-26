using UNIVidaPortalWeb.Noticias.Models.Parametricas;

namespace UNIVidaPortalWeb.Noticias.Models.Noticias
{
    public class NoticiaModel:BaseDomainModel
    {        
        public string Titulo { get; set; } = string.Empty;
        public string TituloCorto { get; set; } = string.Empty;
        public string Contenido { get; set; } = string.Empty;
        public string Resumen { get; set; } = string.Empty;
        public int RecursoId_ImagenPrincipal { get; set; }
        public DateTime Fecha { get; set; }
        public int ParCategoriaId { get; set; }
        public int ParEstado { get; set; }
        public string Etiquetas { get; set; } = string.Empty;
        public int Orden { get; set; }

        // Relaciones
        public virtual ParCategoriaModel ParCategoria { get; set; }= new ParCategoriaModel();
        public virtual RecursoModel Recurso { get; set; } = new RecursoModel();
    }
}
