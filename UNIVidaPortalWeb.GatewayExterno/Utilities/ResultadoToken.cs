using Newtonsoft.Json;

namespace UNIVidaPortalWeb.GatewayExterno.Utilities
{
    public class ResultadoToken
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("postulanteId")]
        public int PostulanteId { get; set; }
    }

}
