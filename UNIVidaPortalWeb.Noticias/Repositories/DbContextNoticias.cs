using Microsoft.EntityFrameworkCore;
using UNIVidaPortalWeb.Noticias.Models.Noticias;
using UNIVidaPortalWeb.Noticias.Models.Parametricas;
using UNIVidaPortalWeb.Noticias.Repositories.Configuracion;

namespace UNIVidaPortalWeb.Noticias.Repositories
{
    public class DbContextNoticias : DbContext
    {
        public static readonly ILoggerFactory MyLoggerFactory
       = LoggerFactory.Create(builder => { builder.AddConsole(); });

        // Definición de DbSets que representan las tablas de parametricas
        public DbSet<ParCategoriaModel> ParCategoria { get; set; }
        public DbSet<ParEstadoModel> ParEstado { get; set; }
        public DbSet<ParTipoRecursoModel> ParTipoRecurso { get; set; }

        // Definición de DbSets que representan las tablas de Noticias
        public DbSet<NoticiaModel> Noticia { get; set; }
        public DbSet<RecursoModel> Recurso { get; set; }
        // Constructor para pasar opciones al contexto
        public DbContextNoticias(DbContextOptions<DbContextNoticias> options) : base(options)
        {            

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLoggerFactory(MyLoggerFactory)  // Tie-up DbContext with LoggerFactory object
                .EnableSensitiveDataLogging();       // Enable sensitive data logging if needed
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ConfiguracionNoticias();
            modelBuilder.ConfiguracionParametricas();
            base.OnModelCreating(modelBuilder);


        }
    }
}

