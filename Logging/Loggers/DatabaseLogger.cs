using System;

using Logging.Base;

namespace Logging.Loggers
{
    public class DatabaseLogger : AbstractLogger
    {
        private readonly string _connectionString;

        public DatabaseLogger(LogLevel level, string connectionString)
            : base(level)
        {
            this._connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        }

        protected override void Write(LogLevel level, string msg)
        {
            throw new NotImplementedException();
        }

        protected override void Write(LogLevel level, string msg, Exception ex)
        {
            throw new NotImplementedException();
        }
    }
}