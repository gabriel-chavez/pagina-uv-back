using Microsoft.EntityFrameworkCore;
using UNIVidaPortalWeb.Convocatorias.Models.ConvocatoriasModel;

namespace UNIVidaPortalWeb.Convocatorias.Repositories.Configuracion
{
    public static class ConvocatoriasContiguracion
    {
        public static void ConfigurarConvocatorias(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Convocatoria>().ToTable("Convocatoria", "Convocatorias");

            modelBuilder.Entity<Convocatoria>()
               .HasOne(c => c.ParEstadoConvocatoria)
               .WithMany()
               .HasForeignKey(c => c.ParEstadoConvocatoriaId)
               .HasPrincipalKey(pec => pec.Id);

            modelBuilder.Entity<Convocatoria>()               
               .HasMany(c=>c.Postulaciones)
               .WithOne(p=>p.Convocatoria)
               .HasForeignKey(p=>p.ConvocatoriaId)
               .HasPrincipalKey(c=>c.Id);

            modelBuilder.Entity<Convocatoria>()
               .HasMany(c => c.NivelFormacionPuntos)
               .WithOne(n => n.Convocatoria)
               .HasForeignKey(n => n.ConvocatoriaId)
               .HasPrincipalKey(c => c.Id);

            modelBuilder.Entity<Convocatoria>()
               .HasMany(c => c.ExperienciaPuntos)
               .WithOne(e => e.Convocatoria)
               .HasForeignKey(e => e.ConvocatoriaId)
               .HasPrincipalKey(c => c.Id);


            modelBuilder.Entity<Postulacion>().ToTable("Postulacion", "Convocatorias");
                modelBuilder.Entity<Postulacion>()
                .HasOne(pon=>pon.Postulante)
                .WithMany()
                .HasForeignKey(pon=>pon.PostulanteId)
                .HasPrincipalKey(pte=>pte.Id);

            modelBuilder.Entity<Postulacion>()
                .HasOne(pon => pon.ParEstadoPostulacion)
                .WithMany()
                .HasForeignKey(pon => pon.ParEstadoPostulacionId)
                .HasPrincipalKey(pep => pep.Id);

            modelBuilder.Entity<Postulacion>()
                .HasMany(p=>p.Notificaciones)
                .WithOne(n=>n.Postulacion)
                .HasForeignKey(n => n.PostulacionId)
                .HasPrincipalKey(p => p.Id);


            modelBuilder.Entity<Notificacion>().ToTable("Notificacion", "Convocatorias");


            modelBuilder.Entity<NivelFormacionPuntos>().ToTable("NivelFormacionPuntos", "Convocatorias");
            modelBuilder.Entity<NivelFormacionPuntos>()
                .HasOne(n => n.ParNivelFormacion)
                .WithMany()
                .HasForeignKey(p=> p.ParNivelFormacionId)
                .HasPrincipalKey(n => n.Id);

            modelBuilder.Entity<ExperienciaPuntos>().ToTable("ExperienciaPuntos", "Convocatorias");





        }
    }
}
