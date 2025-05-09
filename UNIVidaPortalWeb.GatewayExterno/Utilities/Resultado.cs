using Newtonsoft.Json;

namespace UNIVidaPortalWeb.GatewayExterno.Utilities
{
    public class Resultado
    {

        public bool Exito { get; }
        public string? Mensaje { get; }

        public Resultado(bool exito, string mensaje)
        {
            Exito = exito;
            Mensaje = mensaje;
        }

        public Resultado(bool exito)
        {
            Exito = exito;
        }
        private Resultado()
        {
        }
    }

    public class Resultado<T> : Resultado
    {
        // Propiedad de solo lectura
        public T? Datos { get; set; }


        [JsonConstructor]
        public Resultado(bool exito, string mensaje) : base(exito, mensaje)
        {
        }

        public Resultado(bool exito) : base(exito)
        {
        }

        public Resultado(T datos, bool exito, string mensaje) : base(exito, mensaje)
        {
            Datos = datos;
        }

        public Resultado(T datos, bool exito) : base(exito)
        {
            Datos = datos;
        }
    }
}
