using System;

using Logging.Base;

namespace Logging.DatabaseLogger
{
    public class DatabaseLogger : AbstractLogger
    {
        private readonly LogEntryContext _context;

        public DatabaseLogger(LogLevel level, LogEntryContext context)
            : base(level)
        {
            this._context = context ?? throw new ArgumentNullException(nameof(context));
        }

        protected override void Write(LogLevel level, string msg)
        {
            var entry = new LogEntry
            {
                ExceptionInfo = null,
                Level = level,
                LogTime = this.LogTime,
                Message = msg
            };

            this._context.LogEntries.Add(entry);
            this._context.SaveChanges();
        }

        protected override void Write(LogLevel level, string msg, Exception ex)
        {
            var entry = new LogEntry
            {
                ExceptionInfo = ex.ToString(),
                Level = level,
                LogTime = this.LogTime,
                Message = msg
            };

            this._context.LogEntries.Add(entry);
            this._context.SaveChanges();
        }
    }
}