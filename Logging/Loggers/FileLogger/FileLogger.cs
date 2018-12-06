using System;
using System.Collections.Generic;
using System.IO;
using Logging.Base;

namespace Logging.Loggers.FileLogger
{
    internal class FileLogger : AbstractLogger
    {
        private readonly object _syncObject = new object();

        private string _logFilePath;

        private readonly ILogFileExpiringPolicy _expiringPolicy;

        public FileLogger(LogLevel level, string logMessageLayout, ILogFileExpiringPolicy expiringPolicy, string logDirPath)
            : base(level, logMessageLayout)
        {
            if (string.IsNullOrEmpty(logDirPath))
            {
                throw new ArgumentException($"{nameof(logDirPath)} must not be null or empty.");
            }

            this._expiringPolicy = expiringPolicy ?? throw new ArgumentNullException(nameof(expiringPolicy));

            this._logFilePath = GetLogFileFullPath(logDirPath);
            this.CreateNewLogFile();
        }

        protected override void Write(string logEntry)
        {
            lock (_syncObject)
            {
                if (this._expiringPolicy.IsExpired(this._logFilePath))
                {
                    CreateNewLogFile();
                }

                using (var file = File.AppendText(this._logFilePath))
                {
                    file.Write(logEntry);
                }
            }
        }

        private string GetLogFileFullPath(string filepath)
        {
            var path = ParseFilePath(filepath);
            var logFileName = GetNewLogFileName();

            return Path.Combine(path, logFileName);
        }

        private void CreateNewLogFile()
        {
            var dir = Path.GetDirectoryName(this._logFilePath);

            var newLogFileName = GetNewLogFileName();
            var newLogFilePath = Path.Combine(dir, newLogFileName);
            this._logFilePath = newLogFilePath;
        }

        private string GetNewLogFileName()
        {
            const string DT_FORMAT = "yyyy.MM.dd.HH.mm.ss";
            const string EXTENSION = ".txt";

            return DateTime.UtcNow.ToString(DT_FORMAT) + EXTENSION;
        }

        private string ParseFilePath(string filepath)
        {
            var pathValues = GetFilePathConfigValues();
            var prevIndex = 0;
            foreach (var layoutPair in pathValues)
            {
                var searchFor = $"{{{layoutPair.Key}}}";
                var index = filepath.IndexOf(searchFor, prevIndex, StringComparison.InvariantCultureIgnoreCase);
                if (index != -1)
                {
                    filepath = filepath.Replace(searchFor, layoutPair.Value);
                    prevIndex = index + 1;
                }
            }

            return filepath;
        }

        private Dictionary<string, string> GetFilePathConfigValues()
        {
            return new Dictionary<string, string>
                       {
                           { "basedir", Directory.GetCurrentDirectory() }
                       };
        }
    }
}
