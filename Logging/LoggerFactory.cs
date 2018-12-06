using System.Collections.Generic;

using Logging.Base;
using Logging.Loggers;
using Logging.Loggers.FileLogger;
using Logging.Loggers.FileLogger.LogFileExpiringPolicies;

namespace Logging
{
    public static class LoggerFactory
    {
        public static ILogger GetFileLogger(LogLevel level, string messageLayout, ILogFileExpiringPolicy policy, string filepath)
        {
            // In the best scenario, factory should read all targets from config file,
            // but I had no time for it, so let me just hardcode loggers.

            const string layout = "[${logLevel}] ${datetime}: ${message} | ${ex} ${newline}";
            List<AbstractLogger> targets = new List<AbstractLogger>
            {
                new ConsoleLogger(LogLevel.Debug, layout),
                new FileLogger(LogLevel.Error, layout, new ExpiringPolicyBySize(1024), "${basedir}/logs")
            };

            ILogger wrapper = new LoggersWrapper(targets);

            return wrapper;
        }
    }
}
