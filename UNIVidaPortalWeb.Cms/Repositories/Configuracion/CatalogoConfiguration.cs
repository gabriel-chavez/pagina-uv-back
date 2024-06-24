using Microsoft.EntityFrameworkCore;
using UNIVidaPortalWeb.Cms.Models.CatalogoModel;
using UNIVidaPortalWeb.Cms.Models.PaginaDinamicaModel;
using UNIVidaPortalWeb.Cms.Models.RecursoModel;
using UNIVidaPortalWeb.Cms.Models.SeguroModel;

namespace UNIVidaPortalWeb.Cms.Repositories.Configuracion
{
    public static class CatalogoConfiguration
    {
        public static void ConfiguracionCatalogo(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CatTipoRecurso>().ToTable("CatTipoRecurso", "Catalogo");
            modelBuilder.Entity<CatTipoSeccion>().ToTable("CatTipoSeccion", "Catalogo");
            modelBuilder.Entity<CatTipoSeguro>().ToTable("CatTipoSeguro", "Catalogo");


            modelBuilder.Entity<Recurso>()
               .HasOne(r => r.CatTipoRecurso)
               .WithMany()
               .HasForeignKey(r => r.CatTipoRecursoId);

            modelBuilder.Entity<Seccion>()
                .HasOne(s => s.CatTipoSeccion)
                .WithMany()
                .HasForeignKey(s => s.CatTipoSeccionId);

            modelBuilder.Entity<Seguro>()
                .HasOne(s => s.CatTipoSeguro)
                .WithMany()
                .HasForeignKey(s => s.CatTipoSeguroId);


        }
    }
}
