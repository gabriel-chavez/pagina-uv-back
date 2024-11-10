using Microsoft.EntityFrameworkCore;
using UNIVidaPortalWeb.Seguridad.Models;

namespace UNIVidaPortalWeb.Seguridad.Respositories
{
    public class ContextDatabase:DbContext
    {
        public ContextDatabase(DbContextOptions<ContextDatabase> options):base(options)
        {                
        }
        public DbSet<AccessModel> Access { get; set; }
    }
}
