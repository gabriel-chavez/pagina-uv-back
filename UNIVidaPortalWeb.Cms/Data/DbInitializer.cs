using UNIVidaPortalWeb.Cms.Models.CatalogoModel;
using UNIVidaPortalWeb.Cms.Repositories;

namespace UNIVidaPortalWeb.Cms.Data
{
    public class DbInitializer
    {
        public static void Initialize(DbContextCms context)
        {
            context.Database.EnsureCreated();

            // Seed CatTipoRecurso table
            //if (!context.CatTipoRecursos.Any())
            //{
            //    var catTipoRecursos = new CatTipoRecurso[]
            //    {
            //    new CatTipoRecurso { Nombre = "Imagen" },
            //    new CatTipoRecurso { Nombre = "Video" },
            //    new CatTipoRecurso { Nombre = "Archivo" }
            //    };

            //    foreach (var item in catTipoRecursos)
            //    {
            //        context.CatTipoRecursos.Add(item);
            //    }
            //    context.SaveChanges();
            //}

            //// Seed CatTipoSeccion table
            //if (!context.CatTipoSecciones.Any())
            //{
            //    var catTipoSecciones = new CatTipoSeccion[]
            //    {
            //    new CatTipoSeccion { Nombre = "SeccionContenidoTipo3", Descripcion = "2 columnas" },
            //    new CatTipoSeccion { Nombre = "SeccionSliderTipo1", Descripcion = "Seccion slider tipo 1" },
            //    new CatTipoSeccion { Nombre = "SeccionSliderTipo2", Descripcion = "Seccion slider tipo 2" },
            //    new CatTipoSeccion { Nombre = "SeccionAcordeonTipo1", Descripcion = "Seccion acordeon tipo 1" },
            //    };

            //    foreach (var item in catTipoSecciones)
            //    {
            //        context.CatTipoSecciones.Add(item);
            //    }
            //    context.SaveChanges();
            //}
            //if (!context.CatTipoSeguro.Any())
            //{
            //    var catTipoSeguro = new CatTipoSeguro[]
            //    {
            //        new CatTipoSeguro { Nombre = "Seguro de Vida", Ruta = "vida", Habilitado=true },
            //        new CatTipoSeguro { Nombre = "Seguro de Accidentes Personales", Ruta = "accidentes-personales", Habilitado=true },
            //    };

            //    foreach (var item in catTipoSeguro)
            //    {
            //        context.CatTipoSeguro.Add(item);
            //    }
            //    context.SaveChanges();
            //}


        }
    }

}
