using Microsoft.EntityFrameworkCore;
using UNIVidaPortalWeb.Cms.Models.CatalogoModel;
using UNIVidaPortalWeb.Cms.Models.PaginaDinamicaModel;
using UNIVidaPortalWeb.Cms.Models.RecursoModel;

namespace UNIVidaPortalWeb.Cms.Repositories.Configuracion
{
    public static class PaginaDinamicaConfiguration
    {
        public static void ConfiguracionPaginaDinamica(this ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<PaginaDinamica>().ToTable("PaginasDinamicas", "PaginaDinamica");
            modelBuilder.Entity<Recurso>().ToTable("Recursos", "Recurso");
            modelBuilder.Entity<Seccion>().ToTable("Secciones", "PaginaDinamica");
            modelBuilder.Entity<Dato>().ToTable("Datos", "PaginaDinamica");
            modelBuilder.Entity<BannerPagina>().ToTable("BannerPagina", "Recurso");
            


            // Configuración de las relaciones entre las tablas

            modelBuilder.Entity<Seccion>()
                .HasOne(s => s.PaginaDinamica)
                .WithMany()
                .HasForeignKey(s => s.PaginaDinamicaId);

            modelBuilder.Entity<Dato>()
                .HasOne(d => d.Recurso)
                .WithMany()
                .HasForeignKey(d => d.RecursoId);

            modelBuilder.Entity<Dato>()
                .HasOne(d => d.Seccion)
                .WithMany()
                .HasForeignKey(d => d.SeccionId);


            modelBuilder.Entity<BannerPagina>()
                .HasOne(b => b.PaginaDinamica)
                .WithMany()
                .HasForeignKey(b => b.PaginaDinamicaId);

            modelBuilder.Entity<BannerPagina>()
                .HasOne(b => b.Seguro)
                .WithMany()
                .HasForeignKey(b => b.SeguroId);

            modelBuilder.Entity<BannerPagina>()
                .HasOne(b => b.Recurso)
                .WithMany(s=>s.BannerPagina)
                .HasForeignKey(b => b.RecursoId);

            

        }
    }
}
