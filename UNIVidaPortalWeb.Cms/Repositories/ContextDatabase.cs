using Microsoft.EntityFrameworkCore;
using UNIVidaPortalWeb.Cms.Models.CatalogoModel;
using UNIVidaPortalWeb.Cms.Models.PaginaDinamicaModel;
using UNIVidaPortalWeb.Cms.Models.RecursoModel;

namespace UNIVidaPortalWeb.Cms.Repositories
{

    public class ContextDatabase : DbContext
    {
        public static readonly ILoggerFactory MyLoggerFactory
       = LoggerFactory.Create(builder => { builder.AddConsole(); });

        // Definición de DbSets, que representan las tablas en la base de datos
        public DbSet<CatTipoRecurso> CatTipoRecursos { get; set; }
        public DbSet<CatTipoSeccion> CatTipoSecciones { get; set; }
        public DbSet<PaginaDinamica> PaginasDinamicas { get; set; }
        public DbSet<Recurso> Recursos { get; set; }
        public DbSet<Seccion> Secciones { get; set; }
        public DbSet<Dato> Datos { get; set; }
        public DbSet<BannerPaginaDinamica> BannersPaginasDinamicas { get; set; }


        // Constructor opcional para pasar opciones al contexto
        public ContextDatabase(DbContextOptions<ContextDatabase> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLoggerFactory(MyLoggerFactory)  // Tie-up DbContext with LoggerFactory object
                .EnableSensitiveDataLogging();       // Enable sensitive data logging if needed
        }

        // Método para configurar el modelo y las relaciones entre entidades
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuración para la tabla CatTipoRecurso
            modelBuilder.Entity<CatTipoRecurso>().ToTable("CatTipoRecurso");

            // Configuración para la tabla CatTipoSeccion
            modelBuilder.Entity<CatTipoSeccion>().ToTable("CatTipoSeccion");

            // Configuración para la tabla PaginasDinamicas
            modelBuilder.Entity<PaginaDinamica>().ToTable("PaginasDinamicas");

            // Configuración para la tabla Recursos
            modelBuilder.Entity<Recurso>().ToTable("Recursos");

            // Configuración para la tabla Secciones
            modelBuilder.Entity<Seccion>().ToTable("Secciones");

            // Configuración para la tabla Datos
            modelBuilder.Entity<Dato>().ToTable("Datos");

            // Configuración para la tabla BannerPaginaDinamica
            modelBuilder.Entity<BannerPaginaDinamica>().ToTable("BannerPaginaDinamica");


            // Configuración de las relaciones entre las tablas
            modelBuilder.Entity<Recurso>()
                .HasOne(r => r.CatTipoRecurso)
                .WithMany()
                .HasForeignKey(r => r.CatTipoRecursoId);

            modelBuilder.Entity<Seccion>()
                .HasOne(s => s.CatTipoSeccion)
                .WithMany()
                .HasForeignKey(s => s.CatTipoSeccionId);

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
           

            modelBuilder.Entity<BannerPaginaDinamica>()
                .HasOne(b => b.PaginaDinamica)
                .WithMany()
                .HasForeignKey(b => b.PaginaDinamicaId);

            modelBuilder.Entity<BannerPaginaDinamica>()
                .HasOne(b => b.Recurso)
                .WithMany()
                .HasForeignKey(b => b.RecursoId);
        }
    }
}
