using System.Threading.Tasks;

namespace Aforo255.Cross.Discovery.Fabio
{
    public interface IFabioHttpClient
    {
        Task<T> GetAsync<T>(string requestUri);
    }
}