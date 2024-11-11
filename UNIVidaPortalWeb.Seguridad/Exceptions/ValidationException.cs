namespace UNIVidaPortalWeb.Seguridad.Exceptions
{
    public class ValidationException : Exception
    {
        //Es una excepción personalizada que se lanza cuando ocurre un error de validación Ej: El correo electrónico es obligatorio
        public ValidationException(string message) : base(message) { }

    }
}
