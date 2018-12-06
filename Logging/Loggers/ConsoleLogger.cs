using System;

using Logging.Base;

namespace Logging.Loggers
{
    public class ConsoleLogger : AbstractLogger
    {
        private readonly object _syncObject = new object();

        public ConsoleLogger(LogLevel level, string logMessageLayout)
            : base(level, logMessageLayout)
        {
        }

        protected override void Write(string logEntry)
        {
            lock (_syncObject)
            {
                Console.WriteLine(logEntry);
            }
        }
    }
}
