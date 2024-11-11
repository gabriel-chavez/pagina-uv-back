using Microsoft.EntityFrameworkCore;
using UNIVidaPortalWeb.Noticias.Models.Noticias;

namespace UNIVidaPortalWeb.Noticias.Repositories.Configuracion
{
    public static class NoticiasConfiguration
    {
        public static void ConfiguracionNoticias(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NoticiaModel>().ToTable("Noticia", "Noticias");
            modelBuilder.Entity<RecursoModel>().ToTable("Recurso", "Noticias");

            modelBuilder.Entity<NoticiaModel>()
               .HasOne(r => r.ParCategoria)
               .WithMany()
               .HasForeignKey(r => r.ParCategoriaId);

            modelBuilder.Entity<NoticiaModel>()
               .HasOne(r => r.ParEstado)
               .WithMany()
               .HasForeignKey(r => r.ParEstadoId);

            modelBuilder.Entity<NoticiaModel>()
              .HasOne(r => r.Recurso)
              .WithMany(c => c.Noticia)
              .HasForeignKey(r => r.RecursoId_ImagenPrincipal);

            modelBuilder.Entity<RecursoModel>()
               .HasOne(r => r.ParTipoRecurso)
               .WithMany()
               .HasForeignKey(r => r.ParTipoRecursoId);

            


        }
    }
}
