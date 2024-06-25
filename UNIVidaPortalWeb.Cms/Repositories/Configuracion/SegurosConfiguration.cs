using Microsoft.EntityFrameworkCore;
using UNIVidaPortalWeb.Cms.Models.PaginaDinamicaModel;
using UNIVidaPortalWeb.Cms.Models.RecursoModel;
using UNIVidaPortalWeb.Cms.Models.SeguroModel;

namespace UNIVidaPortalWeb.Cms.Repositories.Configuracion
{
    public static class SegurosConfiguration
    {
        public static void ConfiguracionSeguros(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Seguro>().ToTable("Seguros", "Seguro");
            modelBuilder.Entity<Plan>().ToTable("Planes", "Seguro");
            modelBuilder.Entity<SeguroDetalle>().ToTable("SeguroDetalles", "Seguro");


            modelBuilder.Entity<Plan>()
            .HasOne(p => p.Seguro)
            .WithMany(s => s.Planes)
            .HasForeignKey(p => p.SeguroId);
            

            modelBuilder.Entity<SeguroDetalle>()
            .HasOne(sd => sd.Seguro)
            .WithMany(s => s.SeguroDetalles)
            .HasForeignKey(sd => sd.SeguroId);


            modelBuilder.Entity<BannerPagina>()
            .HasOne(p => p.Seguro)
            .WithMany(s => s.BannerPagina)
            .HasForeignKey(p => p.SeguroId);

            modelBuilder.Entity<Seguro>()
                .HasOne(b => b.MenuPrincipal)
                .WithMany()
                .HasForeignKey(b => b.MenuPrincipalId);

        }

    }
}
