using Logging.Base;

namespace Logging
{
    using Logging.Loggers;

    public static class LoggerFactory
    {
        public static AbstractLogger GetFileLogger(LogLevel level, string messageLayout, ILogFileExpiringPolicy policy, string filepath)
        {
            return new FileLogger(level, messageLayout, policy, filepath);
        }


    }
}
