using Microsoft.EntityFrameworkCore;
using UNIVidaPortalWeb.Cms.Models.CatalogoModel;
using UNIVidaPortalWeb.Cms.Models.PaginaDinamicaModel;
using UNIVidaPortalWeb.Cms.Models.RecursoModel;
using UNIVidaPortalWeb.Cms.Models.SeguroModel;
using UNIVidaPortalWeb.Cms.Repositories.Configuracion;

namespace UNIVidaPortalWeb.Cms.Repositories
{

    public class DbContextCms : DbContext
    {
        public static readonly ILoggerFactory MyLoggerFactory
       = LoggerFactory.Create(builder => { builder.AddConsole(); });

        // Definición de DbSets, que representan las tablas de parametricas
        public DbSet<CatTipoRecurso> CatTipoRecursos { get; set; }
        public DbSet<CatTipoSeccion> CatTipoSecciones { get; set; }
        public DbSet<CatTipoSeguro> CatTipoSeguro { get; set; }

        // Definición de DbSets, que representan las tablas de Paginas dinamicas
        public DbSet<PaginaDinamica> PaginasDinamicas { get; set; }
        public DbSet<Recurso> Recursos { get; set; }
        public DbSet<Seccion> Secciones { get; set; }
        public DbSet<Dato> Datos { get; set; }
        public DbSet<BannerPagina> BannersPaginasDinamicas { get; set; }

        // Definición de DbSets, que representan las tablas de Seguros
        public DbSet<Plan> Planes { get; set; }
        public DbSet<Seguro> Seguros { get; set; }
        public DbSet<SeguroDetalle> SeguroDetalles { get; set; }



        // Constructor para pasar opciones al contexto
        public DbContextCms(DbContextOptions<DbContextCms> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLoggerFactory(MyLoggerFactory)  // Tie-up DbContext with LoggerFactory object
                .EnableSensitiveDataLogging();       // Enable sensitive data logging if needed
        }

        // Método para configurar el modelo y las relaciones entre entidades
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ConfiguracionCatalogo();
            modelBuilder.ConfiguracionPaginaDinamica();            
            modelBuilder.ConfiguracionSeguros();            
            base.OnModelCreating(modelBuilder);


        }
    }
}
