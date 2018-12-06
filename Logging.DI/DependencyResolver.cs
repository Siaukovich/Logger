using Logging.Base;

using Ninject;

namespace Logging.DI
{
    public static class DependencyResolver
    {
        public static void ResolveDependencies(this IKernel kernel)
        {
            kernel.Bind<ILogger>().ToMethod(ctx => LoggerFactory.GetLogger());
        }
    }
}
