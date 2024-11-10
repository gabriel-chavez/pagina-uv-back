using UNIVidaPortalWeb.Convocatorias.Models.ConvocatoriasModel;
using UNIVidaPortalWeb.Convocatorias.Repositories;

namespace UNIVidaPortalWeb.Convocatorias.Services.ConvocatoriasServices
{
    public class NotificacionService : RepositoryBase<Notificacion>, INotificacionService
    {
        public NotificacionService(DbContextConvocatorias context) : base(context)
        {
        }
    }
}
