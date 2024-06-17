using UNIVidaPortalWeb.Cms.Models.CatalogoModel;
using UNIVidaPortalWeb.Cms.Repositories;

namespace UNIVidaPortalWeb.Cms.Data
{
    public class DbInitializer
    {
        public static void Initialize(ContextDatabase context)
        {
            context.Database.EnsureCreated();

            // Seed CatTipoRecurso table
            if (!context.CatTipoRecursos.Any())
            {
                var catTipoRecursos = new CatTipoRecurso[]
                {
                new CatTipoRecurso { Nombre = "Imagen" },
                new CatTipoRecurso { Nombre = "Video" },
                new CatTipoRecurso { Nombre = "Archivo" }
                };

                foreach (var item in catTipoRecursos)
                {
                    context.CatTipoRecursos.Add(item);
                }
                context.SaveChanges();
            }

            // Seed CatTipoSeccion table
            if (!context.CatTipoSecciones.Any())
            {
                var catTipoSecciones = new CatTipoSeccion[]
                {
                new CatTipoSeccion { Nombre = "Titulo Contenido 1", Descripcion = "2 columnas" },
                new CatTipoSeccion { Nombre = "Planes", Descripcion = "Card de planes" },
                new CatTipoSeccion { Nombre = "Card Carousel 1", Descripcion = "Compra Soat" },
                new CatTipoSeccion { Nombre = "Card Carousel 2", Descripcion = "Servicios Soat" },
                new CatTipoSeccion { Nombre = "Card Carousel 3", Descripcion = "Noticias" },
                new CatTipoSeccion { Nombre = "Solo titulo", Descripcion = "Titulo y subtitulo" }
                };

                foreach (var item in catTipoSecciones)
                {
                    context.CatTipoSecciones.Add(item);
                }
                context.SaveChanges();
            }
        }
    }

}
