using System;
using System.IO;
using System.Collections.Generic;

using Logging.Base;

namespace Logging.Loggers
{
    public class FileLogger : AbstractLogger
    {
        private readonly object _syncObject = new object();

        private string _logFilePath;

        private int _logFilesCount = 1;

        protected ILogFileExpiringPolicy _expiringPolicy;

        public FileLogger(LogLevel level, string logMessageLayout, ILogFileExpiringPolicy expiringPolicy, string filepath)
            : base(level, logMessageLayout)
        {
            if (string.IsNullOrEmpty(filepath))
            {
                throw new ArgumentException($"{nameof(filepath)} must not be null or empty.");
            }

            this._logFilePath = ParseFileName(filepath);
            this._expiringPolicy = expiringPolicy ?? throw new ArgumentNullException(nameof(expiringPolicy));

            this.CreateLogFileIfNotExist();
        }

        protected override void Write(string logEntry)
        {
            lock (_syncObject)
            {
                if (this._expiringPolicy.IsExpired(this._logFilePath))
                {
                    RecreateLogFile();
                }

                using (var file = File.AppendText(this._logFilePath))
                {
                    file.Write(logEntry);
                }
            }
        }

        private void RecreateLogFile()
        {
            var dir = Path.GetDirectoryName(this._logFilePath);
            var ext = Path.GetExtension(this._logFilePath);

            const string DT_FORMAT = "yyyy.MM.dd.HH.mm.ss";

            var newPath = Path.Combine(dir, DateTime.UtcNow.ToString(DT_FORMAT) + ext);
            this._logFilePath = newPath;
        }

        private string ParseFileName(string filepath)
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

        private void CreateLogFileIfNotExist()
        {
            if (File.Exists(this._logFilePath))
            {
                return;
            }

            var dirName = Path.GetDirectoryName(this._logFilePath);
            Directory.CreateDirectory(dirName);

            File.Create(this._logFilePath);
        }
    }
}
