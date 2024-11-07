using Microsoft.EntityFrameworkCore;
using UNIVidaPortalWeb.Convocatorias.Models.ParametricasModel;
using UNIVidaPortalWeb.Convocatorias.Models.PostulantesModel;

namespace UNIVidaPortalWeb.Convocatorias.Repositories.Configuracion
{
    public static class ParametricasConfiguracion
    {
        public static void ConfigurarParametricas(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ParEstadoConvocatoria>().ToTable("ParEstadoConvocatoria", "Parametricas");
            modelBuilder.Entity<ParEstadoPostulacion>().ToTable("ParEstadoPostulacion", "Parametricas");
            modelBuilder.Entity<ParIdioma>().ToTable("ParIdioma", "Parametricas");
            modelBuilder.Entity<ParNivelConocimiento>().ToTable("ParNivelConocimiento", "Parametricas");
            modelBuilder.Entity<ParNivelFormacion>().ToTable("ParNivelFormacion", "Parametricas");
            modelBuilder.Entity<ParParentesco>().ToTable("ParParentesco", "Parametricas");
            modelBuilder.Entity<ParPrograma>().ToTable("ParPrograma", "Parametricas");
            modelBuilder.Entity<ParTipoCapacitacion>().ToTable("ParTipoCapacitacion", "Parametricas");

        }
    }
}
