using Microsoft.Extensions.DependencyInjection;
using System.ServiceModel;
using System.ServiceModel.Channels;



namespace UNIVidaPortalWeb.Common.Email.Extensions
{
    public static class SoapClientExtensions
    {
        public static IServiceCollection AddSoapEmailClient(this IServiceCollection services, string wsdlUrl)
        {
            services.AddSingleton(provider =>
            {
                var binding = new BasicHttpBinding
                {
                    Security = new BasicHttpSecurity
                    {
                        Mode = BasicHttpSecurityMode.Transport,
                        Transport = new HttpTransportSecurity
                        {
                            ClientCredentialType = HttpClientCredentialType.None
                        }
                    },
                    MaxReceivedMessageSize = 65536
                };

                var endpoint = new EndpointAddress(wsdlUrl);
                return new Service1Client(binding, endpoint);
            });

            services.AddTransient<IEmailService, EmailService>();

            return services;
        }
    }
}
