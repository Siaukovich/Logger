using System;
using System.Collections.Generic;
using System.IO;

using Logging.Base;
using Parser = Logging.LogEntryParser.LogEntryParser;

namespace Logging.FileLogger
{
    public class FileLogger : AbstractLogger
    {
        private readonly object _syncObject = new object();

        private string _logFilePath;

        private readonly string _logMessageLayout;

        private readonly ILogFileExpiringPolicy _expiringPolicy;

        public FileLogger(LogLevel level, string logMessageLayout, ILogFileExpiringPolicy expiringPolicy, string logDirPath)
            : base(level)
        {
            if (string.IsNullOrEmpty(logDirPath))
            {
                throw new ArgumentException($"{nameof(logDirPath)} must not be null or empty.");
            }

            this._logMessageLayout = logMessageLayout ?? throw new ArgumentNullException(nameof(logMessageLayout));
            this._expiringPolicy = expiringPolicy ?? throw new ArgumentNullException(nameof(expiringPolicy));

            this._logFilePath = this.GetLogFileFullPath(logDirPath);
            this.CreateNewLogFile();
        }

        protected override void Write(LogLevel level, string msg)
        {
            lock (this._syncObject)
            {
                if (this._expiringPolicy.IsExpired(this._logFilePath))
                {
                    this.CreateNewLogFile();
                }

                using (var file = File.AppendText(this._logFilePath))
                {
                    var logEntry = Parser.ParseLogMessage(level, msg, this.LogTime, this._logMessageLayout);
                    file.Write(logEntry);
                }
            }
        }

        protected override void Write(LogLevel level, string msg, Exception ex)
        {
            lock (this._syncObject)
            {
                if (this._expiringPolicy.IsExpired(this._logFilePath))
                {
                    this.CreateNewLogFile();
                }

                using (var file = File.AppendText(this._logFilePath))
                {
                    var logEntry = Parser.ParseLogMessage(level, msg, this.LogTime, ex, this._logMessageLayout);
                    file.Write(logEntry);
                }
            }
        }

        private string GetLogFileFullPath(string filepath)
        {
            var path = this.ParseFilePath(filepath);
            var logFileName = this.GetNewLogFileName();

            return Path.Combine(path, logFileName);
        }

        private void CreateNewLogFile()
        {
            var dir = Path.GetDirectoryName(this._logFilePath);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            var newLogFileName = this.GetNewLogFileName();
            var newLogFilePath = Path.Combine(dir, newLogFileName);
            this._logFilePath = newLogFilePath;

            File.Create(this._logFilePath).Dispose();
        }

        private string GetNewLogFileName()
        {
            const string DT_FORMAT = "yyyy.MM.dd.HH.mm.ss";
            const string EXTENSION = ".txt";

            return DateTime.UtcNow.ToString(DT_FORMAT) + EXTENSION;
        }

        private string ParseFilePath(string filepath)
        {
            var pathValues = this.GetFilePathConfigValues();
            var prevIndex = 0;
            foreach (var layoutPair in pathValues)
            {
                var searchFor = $"${{{layoutPair.Key}}}";
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
