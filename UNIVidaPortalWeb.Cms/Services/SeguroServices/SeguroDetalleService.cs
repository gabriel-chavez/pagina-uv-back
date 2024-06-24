using UNIVidaPortalWeb.Cms.Models.SeguroModel;
using UNIVidaPortalWeb.Cms.Repositories;

namespace UNIVidaPortalWeb.Cms.Services.SeguroServices
{
    public class SeguroDetalleService : RepositoryBase<SeguroDetalle>, ISeguroDetalleService
    {
        private readonly DbContextCms _context;
        public SeguroDetalleService(DbContextCms context) : base(context)
        {
            _context = context;
        }
    }
}
