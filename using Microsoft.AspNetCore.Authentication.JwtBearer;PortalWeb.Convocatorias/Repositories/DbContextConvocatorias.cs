using Microsoft.EntityFrameworkCore;
using UNIVidaPortalWeb.Convocatorias.Models.ConvocatoriasModel;
using UNIVidaPortalWeb.Convocatorias.Models.ParametricasModel;
using UNIVidaPortalWeb.Convocatorias.Models.PostulantesModel;
using UNIVidaPortalWeb.Convocatorias.Repositories.Configuracion;

namespace UNIVidaPortalWeb.Convocatorias.Repositories
{
    public class DbContextConvocatorias : DbContext
    {
        public static readonly ILoggerFactory MyLoggerFactory
       = LoggerFactory.Create(builder => { builder.AddConsole(); });


        // Definición de DbSets, que representan las tablas de parametricas
        public DbSet<ParEstadoConvocatoria> ParEstadoConvocatoria { get; set; }
        public DbSet<ParEstadoPostulacion> ParEstadoPostulacion { get; set; }
        public DbSet<ParIdioma> ParIdioma { get; set; }
        public DbSet<ParNivelConocimiento> ParNivelConocimiento { get; set; }
        public DbSet<ParNivelFormacion> ParNivelFormacion { get; set; }
        public DbSet<ParParentesco> ParParentesco { get; set; }
        public DbSet<ParPrograma> ParPrograma { get; set; }
        public DbSet<ParTipoCapacitacion> ParTipoCapacitacion { get; set; }

        // Definición de DbSets, que representan las tablas de postulantes
        public DbSet<Capacitacion> Capacitacion { get; set; }
        public DbSet<ConocimientoIdioma> ConocimientoIdioma { get; set; }
        public DbSet<ConocimientoSistemas> ConocimientoSistemas { get; set; }
        public DbSet<FormacionAcademica> FormacionAcademica { get; set; }
        public DbSet<Postulante> Postulante { get; set; }
        public DbSet<ReferenciaLaboral> ReferenciaLaboral { get; set; }
        public DbSet<ReferenciaPersonal> ReferenciaPersonal { get; set; }
        public DbSet<ExperienciaLaboral> ExperienciaLaboral { get; set; }
        // Definición de DbSets, que representan las tablas de postulantes
        public DbSet<Convocatoria> Convocatoria { get; set; }
        public DbSet<Notificacion> Notificacion { get; set; }
        public DbSet<Postulacion> Postulacion { get; set; }


        public DbContextConvocatorias(DbContextOptions<DbContextConvocatorias> options) : base(options)
        {
            //this.ChangeTracker.LazyLoadingEnabled = true;

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLoggerFactory(MyLoggerFactory)  // Tie-up DbContext with LoggerFactory object
                .EnableSensitiveDataLogging();       // Enable sensitive data logging if needed
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ConfigurarConvocatorias();
            modelBuilder.ConfigurarPostulantes();
            modelBuilder.ConfigurarParametricas();
            base.OnModelCreating(modelBuilder);


        }
    }

}

