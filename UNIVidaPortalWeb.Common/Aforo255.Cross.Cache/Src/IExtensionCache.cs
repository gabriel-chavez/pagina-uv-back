namespace Aforo255.Cross.Cache.Src
{
    public interface IExtensionCache
    {
        void SetData<T>(T TEntity, string key, int lifeTimeInMinutes);
        T GetData<T>(string key);
    }
}
