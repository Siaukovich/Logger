using System;
using Logging.Base;

namespace Logging.DatabaseLogger
{
    public class LogEntry
    {
        public int Id { get; set; }

        public LogLevel Level { get; set; }

        public DateTime LogTime { get; set; }

        public string Message { get; set; }

        public string ExceptionInfo { get; set; }
    }
}
