using System;
using System.Threading;

using Logging.Base;
using Logging.DI;

using Ninject;

namespace Logging.Console
{
    using Console = System.Console;

    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel();
            kernel.ResolveDependencies();

            var logger = kernel.Get<ILogger>();

            logger.Trace("Trace message");

            logger.Debug("Debug message");

            logger.Info("Info message 1", new ArgumentOutOfRangeException("param name1"));

            logger.Error("Error message 1", new ArgumentNullException("param name2", new Exception("inner")));

            logger.Info("Info message 2");

            Thread.Sleep(11_000); // So FileLogger will expire and create new file.

            logger.Error("Error message 2");

            logger.Fatal("Fatal message");

            Console.ReadKey();
        }
    }
}
