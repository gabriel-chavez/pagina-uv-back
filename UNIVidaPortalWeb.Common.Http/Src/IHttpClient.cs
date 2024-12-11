namespace UNIVidaPortalWeb.Common.Http.Src
{
    public interface IHttpClient
    {
        Task<string> GetStringAsync(string uri);

        Task<HttpResponseMessage> PostAsync<T>(string uri, T item);
    }
}
