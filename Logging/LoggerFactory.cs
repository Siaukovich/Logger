using System.Collections.Generic;

using Logging.Base;
using Logging.Loggers;
using Logging.FileLogger.LogFileExpiringPolicies;

namespace Logging
{
    using Logging.DatabaseLogger;

    public static class LoggerFactory
    {
        public static ILogger GetLogger()
        {
            // In the best scenario, factory should read all targets from config file,
            // but I had no time for it, so let me just hardcode loggers.

            const string LAYOUT = "[${logLevel}] ${datetime}: ${message} | ${exception} ${newline}";

            const int TEN_SECONDS = 10;
            const string DIR = "${basedir}/logs";

            var targets = new List<AbstractLogger>
            {
                new ConsoleLogger(LogLevel.Debug, LAYOUT),
                new FileLogger.FileLogger(LogLevel.Error, LAYOUT, new ExpiringPolicyByTime(TEN_SECONDS), DIR),
                new DatabaseLogger.DatabaseLogger(LogLevel.Warning, new LogEntryContext())
            };

            ILogger wrapper = new LoggersWrapper(targets);

            return wrapper;
        }
    }
}
