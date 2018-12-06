using System;

using Logging.Base;
using Parser = Logging.LogEntryParser.LogEntryParser;

namespace Logging.ConsoleLogger
{
    public class ConsoleLogger : AbstractLogger
    {
        private readonly string _logMessageLayout;

        private readonly object _syncObject = new object();

        public ConsoleLogger(LogLevel level, string logMessageLayout)
            : base(level)
        {
            this._logMessageLayout = logMessageLayout ?? throw new ArgumentNullException(nameof(logMessageLayout));
        }

        protected override void Write(LogLevel level, string msg)
        {
            lock (this._syncObject)
            {
                var logEntry = Parser.ParseLogMessage(level, msg, this.LogTime, this._logMessageLayout);
                Console.WriteLine(logEntry);
            }
        }

        protected override void Write(LogLevel level, string msg, Exception ex)
        {
            lock (this._syncObject)
            {
                var logEntry = Parser.ParseLogMessage(level, msg, this.LogTime, ex, this._logMessageLayout);
                Console.WriteLine(logEntry);
            }
        }
    }
}
