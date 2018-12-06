using System;
using System.IO;
using Logging.Base;

namespace Logging.Loggers.FileLogger.LogFileExpiringPolicies
{
    internal class ExpiringPolicyByTime : ILogFileExpiringPolicy
    {
        private readonly int _maxFileLifetimeSeconds;

        public ExpiringPolicyByTime(int maxFileLifetimeSeconds)
        {
            if (maxFileLifetimeSeconds <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(maxFileLifetimeSeconds));
            }

            _maxFileLifetimeSeconds = maxFileLifetimeSeconds;
        }

        public bool IsExpired(string logFilePath)
        {
            if (string.IsNullOrEmpty(logFilePath))
            {
                throw new ArgumentException($"{nameof(logFilePath)} must not be empty.", nameof(logFilePath));
            }

            if (!File.Exists(logFilePath))
            {
                throw new FileNotFoundException($"{nameof(logFilePath)} was not found.", nameof(logFilePath));
            }

            var file = new FileInfo(logFilePath);
            var creationTime = file.CreationTime;
            var lifetime = (DateTime.Now - creationTime).Seconds;

            return lifetime >= _maxFileLifetimeSeconds;
        }
    }
}
