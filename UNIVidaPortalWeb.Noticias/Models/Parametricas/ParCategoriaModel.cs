namespace UNIVidaPortalWeb.Noticias.Models.Parametricas
{
    public class ParCategoriaModel:BaseDomainModel
    {
        public string Nombre { get; set; } = string.Empty;
        public bool Habilitado { get; set; }
    }
}
