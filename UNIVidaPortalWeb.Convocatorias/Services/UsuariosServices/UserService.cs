using Microsoft.EntityFrameworkCore;
using Nacos;
using UNIVidaPortalWeb.Convocatorias.Exceptions;
using UNIVidaPortalWeb.Convocatorias.Models.PostulantesModel;
using UNIVidaPortalWeb.Convocatorias.Services.PostulantesServices;

namespace UNIVidaPortalWeb.Convocatorias.Services.UsuariosServices
{
    public class UserService : IUserService
    {
        private readonly IPostulanteService _postulanteService;

        public int UserId { get; private set; }
        public UserService(IPostulanteService postulanteService)
        {
            _postulanteService = postulanteService;
        }
        public void SetUserId(int userId)
        {
            UserId = userId;
        }
        public async Task<int> PostulanteId()
        {
            if (UserId == 0)
            {
                throw new NotFoundException("El ID de usuario es obligatorio");
            }
            var postulante = await _postulanteService.ObtenerPorUsuarioIdAsync(UserId);
            
            if (postulante == null)
            {
                throw new NotFoundException("El usuario no tiene registros como postulante. Por favor, asegúrese de haber completado el registro de los datos del postulante antes de continuar.");
            }
            return postulante.Id;
        }

    }
}
