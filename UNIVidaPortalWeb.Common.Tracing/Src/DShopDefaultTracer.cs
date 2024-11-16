using Jaeger;
using Jaeger.Reporters;
using Jaeger.Samplers;
using OpenTracing;
using System.Reflection;

namespace UNIVidaPortalWeb.Common.Tracing.Src
{
    public class DShopDefaultTracer
    {
        public static ITracer Create()
            => new Tracer.Builder(Assembly.GetEntryAssembly().FullName)
                .WithReporter(new NoopReporter())
                .WithSampler(new ConstSampler(false))
                .Build();
    }
}
