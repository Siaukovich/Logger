using Ninject;

namespace Logging.DI
{
    public static class DependencyResolver
    {
        public static void ResolveDependencies(this IKernel kernel)
        {
            //BindToFileLogger(kernel);

            //BindToDbLogger(kernel);

            //BindToConsoleLogger(kernel);
        }
    }
}
