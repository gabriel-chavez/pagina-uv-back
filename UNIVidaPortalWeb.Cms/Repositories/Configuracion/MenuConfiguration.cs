using Microsoft.EntityFrameworkCore;
using UNIVidaPortalWeb.Cms.Models.MenuModel;

namespace UNIVidaPortalWeb.Cms.Repositories.Configuracion
{
    public static class MenuConfiguration
    {
        public static void ConfiguracionMenu(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MenuPrincipal>().ToTable("MenuPrincipal", "Menu");

            modelBuilder.Entity<MenuPrincipal>()
            .HasOne(m => m.Padre)
            .WithMany(m => m.SubMenus)
            .HasForeignKey(m => m.IdPadre)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<MenuPrincipal>()
            .HasOne(m => m.PaginaDinamica)
            .WithMany(p => p.MenuPrincipal)
            .HasForeignKey(m => m.IdPaginaDinamica);

            modelBuilder.Entity<MenuPrincipal>()
                .HasOne(m => m.Seguro)
                .WithMany(s => s.MenuPrincipal)
                .HasForeignKey(m => m.IdSeguro);
        }
    }
}
