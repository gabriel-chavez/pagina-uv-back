using System.Threading.Tasks;
using Consul;

namespace Aforo255.Cross.Discovery.Consul
{
    public interface IConsulServicesRegistry
    {
        Task<AgentService> GetAsync(string name);
    }
}