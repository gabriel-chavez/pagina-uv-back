

using Microsoft.Extensions.Options;

using System.Text;

namespace UNIVidaPortalWeb.Common.Email.Src
{
    public class EmailService
    {
        private readonly HttpClient _httpClient;
        private readonly EmailSettings _settings;

        public EmailService(HttpClient httpClient, IOptions<EmailSettings> settings)
        {
            _httpClient = httpClient;
            _settings = settings.Value;
        }

        public async Task<string> EnviarCorreo(string to, string subject, string message)
        {
            var soapRequest = $@"<?xml version=""1.0"" encoding=""utf-8""?>
    <soap:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" 
                   xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" 
                   xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/"">
        <soap:Body>
            <EnviarCorreo xmlns=""http://tempuri.org/"">
                <to>{to}</to>
                <from>{_settings.Usuario}</from>
                <subject>{subject}</subject>
                <body>{message}</body>
                <smtpCliente>{_settings.SmtpCliente}</smtpCliente>
                <puerto>{_settings.Puerto}</puerto>
                <usuario>{_settings.Usuario}</usuario>
                <contrasenia>{_settings.Contrasenia}</contrasenia>
            </EnviarCorreo>
        </soap:Body>
    </soap:Envelope>";

            var content = new StringContent(soapRequest, Encoding.UTF8, "text/xml");
            content.Headers.Clear();
            content.Headers.Add("SOAPAction", "http://tempuri.org/IService1/EnviarCorreo");
            content.Headers.Add("Content-Type", "text/xml; charset=utf-8");

            try
            {
                var response = await _httpClient.PostAsync("", content);
                var responseBody = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"Error en el servidor: {response.StatusCode} - {responseBody}");
                }

                return responseBody;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Error de conexión: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Excepción inesperada: {ex.Message}");
                throw;
            }
        }
    }
}
