using System;
using System.Collections.Generic;

using Logging.Base;

namespace Logging.LogEntryParser
{
    public static class LogEntryParser
    {
        public static string ParseLogMessage(LogLevel level, string msg, DateTime logTime, string layout)
        {
            var layoutValues = GetLogLayoutValues(level, msg, logTime, null);
            return Parse(layoutValues, layout);
        }

        public static string ParseLogMessage(LogLevel level, string msg, DateTime logTime, Exception ex, string layout)
        {
            var layoutValues = GetLogLayoutValues(level, msg, logTime, ex);
            return Parse(layoutValues, layout);
        }

        private static Dictionary<string, string> GetLogLayoutValues(LogLevel level, string msg, DateTime logTime, Exception ex)
        {
            const string DT_FORMAT = "yyyy-MM-dd HH:mm:ss.fffffff";
            return new Dictionary<string, string>
                       {
                           { "datetime", logTime.ToString(DT_FORMAT) },
                           { "message", msg },
                           { "logLevel", level.ToString() },
                           { "newline", Environment.NewLine },
                           { "exception", ex?.ToString() ?? string.Empty }
                       };
        }

        private static string Parse(Dictionary<string, string> layoutValues, string layout)
        {
            var logMsg = layout;
            foreach (var layoutPair in layoutValues)
            {
                var searchFor = $"${{{layoutPair.Key}}}";
                var index = logMsg.IndexOf(searchFor, StringComparison.InvariantCulture);
                if (index != -1)
                {
                    logMsg = logMsg.Replace(searchFor, layoutPair.Value);
                }
            }

            return logMsg;
        }
    }
}
