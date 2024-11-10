using Microsoft.EntityFrameworkCore;
using UNIVidaPortalWeb.Convocatorias.Models.PostulantesModel;

namespace UNIVidaPortalWeb.Convocatorias.Repositories.Configuracion
{
    public static class PostulantesConfiguracion
    {
        public static void ConfigurarPostulantes(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Postulante>().ToTable("Postulante", "Postulantes");

            modelBuilder.Entity<Postulante>()
                .HasMany(p => p.Capacitaciones)
                .WithOne(c => c.Postulante)
                .HasForeignKey(c => c.PostulanteId)
                .HasPrincipalKey(p => p.Id);

            modelBuilder.Entity<Postulante>()
                .HasMany(p => p.ConocimientosIdiomas)
                .WithOne(ci => ci.Postulante)
                .HasForeignKey(ci => ci.PostulanteId)
                .HasPrincipalKey(p => p.Id);

            modelBuilder.Entity<Postulante>()
                .HasMany(p => p.ConocimientosSistemas)
                .WithOne(cs => cs.Postulante)
                .HasForeignKey(cs => cs.PostulanteId)
                .HasPrincipalKey(p => p.Id);

            modelBuilder.Entity<Postulante>()
                .HasMany(p => p.FormacionesAcademicas)
                .WithOne(fa => fa.Postulante)
                .HasForeignKey(fa => fa.PostulanteId)
                .HasPrincipalKey(p => p.Id);

            modelBuilder.Entity<Postulante>()
                .HasMany(p => p.ReferenciasLaborales)
                .WithOne(rl => rl.Postulante)
                .HasForeignKey(rl => rl.PostulanteId)
                .HasPrincipalKey(p => p.Id);

            modelBuilder.Entity<Postulante>()
                .HasMany(p => p.ReferenciasPersonales)
                .WithOne(rp => rp.Postulante)
                .HasForeignKey(rp => rp.PostulanteId)
                .HasPrincipalKey(p => p.Id);

            modelBuilder.Entity<Postulante>()
                .HasMany(p => p.ExperienciaLaboral)
                .WithOne(el => el.Postulante)
                .HasForeignKey(el => el.PostulanteId)
                .HasPrincipalKey(p => p.Id);

            modelBuilder.Entity<Capacitacion>().ToTable("Capacitacion", "Postulantes");

            modelBuilder.Entity<Capacitacion>()
                .HasOne(c => c.ParTipoCapacitacion)
                .WithMany()
                .HasForeignKey(c => c.ParTipoCapacitacionId)
                .HasPrincipalKey(ptc => ptc.Id);


            modelBuilder.Entity<ConocimientoIdioma>().ToTable("ConocimientoIdioma", "Postulantes");
            modelBuilder.Entity<ConocimientoIdioma>()
                .HasOne(c => c.ParIdioma)
                .WithMany()
                .HasForeignKey(c => c.ParIdiomaId)
                .HasPrincipalKey(pi => pi.Id);
            modelBuilder.Entity<ConocimientoIdioma>()
                .HasOne(c => c.ParNivelConocimientoLectura)
                .WithMany()
                .HasForeignKey(c => c.ParNivelConocimientoLecturaId)
                .HasPrincipalKey(pncl => pncl.Id);
            modelBuilder.Entity<ConocimientoIdioma>()
                .HasOne(c => c.ParNivelConocimientoEscritura)
                .WithMany()
                .HasForeignKey(c => c.ParNivelConocimientoEscrituraId)
                .HasPrincipalKey(pnce => pnce.Id);
            modelBuilder.Entity<ConocimientoIdioma>()
                .HasOne(c => c.ParNivelConocimientoConversacion)
                .WithMany()
                .HasForeignKey(c => c.ParNivelConocimientoConversacionId)
                .HasPrincipalKey(pncc => pncc.Id);

            modelBuilder.Entity<ConocimientoSistemas>().ToTable("ConocimientoSistemas", "Postulantes");
            modelBuilder.Entity<ConocimientoSistemas>()
                .HasOne(c=>c.ParPrograma)
                .WithMany()
                .HasForeignKey(c => c.ParProgramaId)
                .HasPrincipalKey(pp=> pp.Id);
            modelBuilder.Entity<ConocimientoSistemas>()
                .HasOne(c => c.ParNivelConocimiento)
                .WithMany()
                .HasForeignKey(c => c.ParNivelConocimientoId)
                .HasPrincipalKey(pnc => pnc.Id);


            modelBuilder.Entity<FormacionAcademica>().ToTable("FormacionAcademica", "Postulantes");
            modelBuilder.Entity<FormacionAcademica>()
               .HasOne(f => f.ParNivelFormacion)
               .WithMany()
               .HasForeignKey(f => f.ParNivelFormacionId)
               .HasPrincipalKey(pnf => pnf.Id);

            modelBuilder.Entity<ReferenciaLaboral>().ToTable("ReferenciaLaboral", "Postulantes");            

            modelBuilder.Entity<ReferenciaPersonal>().ToTable("ReferenciaPersonal", "Postulantes");
            modelBuilder.Entity<ReferenciaPersonal>()
                .HasOne(r=>r.ParParentesco)
                .WithMany()
                .HasForeignKey(r=>r.ParParentescoId)
                .HasPrincipalKey(pp => pp.Id);

            modelBuilder.Entity<ExperienciaLaboral>().ToTable("ExperienciaLaboral", "Postulantes");



        }
    }
}
