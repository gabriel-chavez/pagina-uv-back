using UNIVidaPortalWeb.Cms.Models.SeguroModel;
using UNIVidaPortalWeb.Cms.Repositories;

namespace UNIVidaPortalWeb.Cms.Services.SeguroServices
{
    public class PlanService : RepositoryBase<Plan>, IPlanService
    {
        private readonly DbContextCms _context;
        public PlanService(DbContextCms context) : base(context)
        {
            _context = context;
        }
    }
}
