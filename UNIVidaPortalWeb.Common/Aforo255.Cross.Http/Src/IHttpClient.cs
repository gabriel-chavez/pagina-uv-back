using System.Net.Http;
using System.Threading.Tasks;

namespace Aforo255.Cross.Http.Src
{
    public interface IHttpClient
    {
        Task<string> GetStringAsync(string uri);

        Task<HttpResponseMessage> PostAsync<T>(string uri, T item);
    }
}
