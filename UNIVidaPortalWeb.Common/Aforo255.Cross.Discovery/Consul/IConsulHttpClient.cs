using System.Threading.Tasks;

namespace Aforo255.Cross.Discovery.Consul
{
    public interface IConsulHttpClient
    {
        Task<T> GetAsync<T>(string requestUri);
    }
}

