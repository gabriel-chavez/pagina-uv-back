namespace UNIVidaPortalWeb.Seguridad.Models
{
    namespace UNIVidaPortalWeb.Convocatorias.Utilidades
    {
        public class DatosPostulante
        {
            public string? Nombres { get; set; }
            public string? ApellidoPaterno { get; set; }
            public string? ApellidoMaterno { get; set; }
            public string? Email { get; set; }
            public string? NumeroDocumento { get; set; }
            public string? DocumentoExpedido { get; set; }
            public DateTime FechaNacimiento { get; set; }
            public string? CiudadNacimiento { get; set; }
            public string? PaisNacimiento { get; set; }
            public string? CiudadResidencia { get; set; }
            public string? PaisResidencia { get; set; }
            public string? Direccion { get; set; }
            public string? Zona { get; set; }
            public string? Telefono { get; set; }
            public string? TelefonoMovil { get; set; }
            public string? Fotografia { get; set; }
            public int UsuarioId { get; set; }
            public int Id { get; set; }
            public DateTime FechaCreacion { get; set; }
        }
    }

}
