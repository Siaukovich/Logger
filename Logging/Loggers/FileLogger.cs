using System;
using System.IO;

using Logging.Base;

namespace Logging.Loggers
{
    public class FileLogger : AbstractLogger
    {
        private readonly object _syncObject = new object();

        private readonly string _filepath;

        protected ILogFileExpiringPolicy _expiringPolicy;

        public FileLogger(LogLevel level, ILogFileExpiringPolicy expiringPolicy, string filepath): base(level)
        {
            if (string.IsNullOrEmpty(filepath))
            {
                throw new ArgumentException($"{nameof(filepath)} must not be null or empty.");
            }

            this._expiringPolicy = expiringPolicy ?? throw new ArgumentNullException(nameof(expiringPolicy));

            this.CreateLogFileIfNotExist();
        }

        protected override void Write(LogLevel level, string msg)
        {
            lock (_syncObject)
            {
                // TODO: Expiring policy check
                using (var file = File.AppendText(this._filepath))
                {
                    file.Write(msg);
                }
            }
        }

        protected override void Write(LogLevel level, string msg, Exception ex)
        {
            lock (_syncObject)
            {
                // TODO: Expiring policy check
                using (var file = File.AppendText(this._filepath))
                {
                    file.Write(msg);
                    file.Write($"EXCEPTION: {ex}");
                }
            }
        }

        private void CreateLogFileIfNotExist()
        {
            if (File.Exists(this._filepath))
            {
                return;
            }

            var dirName = Path.GetDirectoryName(this._filepath);
            Directory.CreateDirectory(dirName);

            File.Create(this._filepath);
        }
    }
}
