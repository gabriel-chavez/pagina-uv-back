using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using UNIVidaPortalWeb.Cms.Models.PaginaDinamicaModel;
using UNIVidaPortalWeb.Cms.Models.SeguroModel;

namespace UNIVidaPortalWeb.Cms.Models.MenuModel
{
    public class MenuPrincipal : BaseDomainModel
    {
        public string Nombre { get; set; } = string.Empty;
        public string? Url { get; set; } = string.Empty;
        public int? IdPadre { get; set; }
        public bool Habilitado { get; set; } = true;
        public bool Visible { get; set; } = true;
        public int Orden { get; set; }
        public int? IdPaginaDinamica { get; set; } // Permitir nulo
        public int? IdSeguro { get; set; } // Permitir nulo

        // Propiedad de navegación para el elemento padre
        [ForeignKey("IdPadre")]
        public virtual MenuPrincipal? Padre { get; set; }

        // Propiedad de navegación para los submenús
        public virtual ICollection<MenuPrincipal>? SubMenus { get; set; } = new List<MenuPrincipal>();

        // Propiedad de navegación para la página dinámica
        [ForeignKey("IdPaginaDinamica")]
        public virtual PaginaDinamica? PaginaDinamica { get; set; }

        // Propiedad de navegación para el seguro
        [ForeignKey("IdSeguro")]
        public virtual Seguro? Seguro { get; set; }

        // NotMapped para no mapear en la base de datos
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
