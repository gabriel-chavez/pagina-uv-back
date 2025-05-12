namespace UNIVidaPortalWeb.Convocatorias.Services.UsuariosServices
{
    public interface IUserService
    {
        int UserId { get; }
        void SetUserId(int userId);
        Task<int> PostulanteId();
    }
}
