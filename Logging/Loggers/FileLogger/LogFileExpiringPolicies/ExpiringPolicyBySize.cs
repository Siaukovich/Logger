using System;
using System.IO;
using Logging.Base;

namespace Logging.Loggers.FileLogger.LogFileExpiringPolicies
{
    internal class ExpiringPolicyBySize : ILogFileExpiringPolicy
    {
        private readonly int _maxSizeKB;

        public ExpiringPolicyBySize(int maxSizeKB)
        {
            if (maxSizeKB <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(maxSizeKB));
            }

            _maxSizeKB = maxSizeKB;
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
            var fileLengthBytes = file.Length;
            var BYTES_IN_KB = 1024;

            return fileLengthBytes * BYTES_IN_KB >= _maxSizeKB;
        }
    }
}
