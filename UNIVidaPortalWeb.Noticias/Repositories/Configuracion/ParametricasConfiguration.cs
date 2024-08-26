using Microsoft.EntityFrameworkCore;
using UNIVidaPortalWeb.Noticias.Models.Noticias;
using UNIVidaPortalWeb.Noticias.Models.Parametricas;

namespace UNIVidaPortalWeb.Noticias.Repositories.Configuracion
{
    public static class ParametricasConfiguration
    {
        public static void ConfiguracionParametricas(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ParCategoriaModel>().ToTable("ParCategoria", "Parametricas");
            modelBuilder.Entity<ParEstadoModel>().ToTable("ParEstado", "Parametricas");
            modelBuilder.Entity<ParTipoRecursoModel>().ToTable("ParTipoRecurso", "Parametricas");


        }
    }
}
