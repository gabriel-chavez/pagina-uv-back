using System.ComponentModel.DataAnnotations.Schema;

namespace UNIVidaPortalWeb.Cms.Models.MenuModel
{
    public class MenuPrincipal: BaseDomainModel
    {
        public string Nombre { get; set; }=string.Empty;
        public string? Url { get; set; }= string.Empty;  
        public int? IdPadre { get; set; }
        public bool Habilitado { get; set; }=true;
        public bool Visible { get; set; } = true;
        public int Orden { get; set; }

        // Propiedad de navegación para el elemento padre
        public virtual MenuPrincipal? Padre { get; set; }

        // Propiedad de navegación para los submenús
        public virtual ICollection<MenuPrincipal>? SubMenus { get; set; }
        //NotMapped para no mapear en la base de datos
        [NotMapped]
        public string UrlCompleta => ObtenerUrlCompleta();

        public string ObtenerUrlCompleta()
        {
            if (Padre == null)
            {
                return $"/{Url}".TrimEnd('/');
            }
            else
            {
                return $"{Padre.UrlCompleta}/{Url}".TrimEnd('/');
            }
        }
    }

}
