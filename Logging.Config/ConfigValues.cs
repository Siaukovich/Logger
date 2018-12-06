using System.Configuration;

namespace Logging.Config
{
    public static class ConfigValues
    {
        public static string DateTimeFormat { get; set; }

        public static string LogDatetimePlaceholder { get; set; }

        public static string LogMessagePlaceholder { get; set; }

        public static string LogLevelPlaceholder { get; set; }

        public static string NewlinePlaceholder { get; set; }

        public static string ExceptionPlaceholder { get; set; }

        public static string BasedirPlaceholder { get; set; }

        public static string LogDbName { get; set; }

        static ConfigValues()
        {
            DateTimeFormat = GetValueFromConfig("dtFormat");
            LogDatetimePlaceholder = GetValueFromConfig("logDatetimePlaceholder");
            LogMessagePlaceholder = GetValueFromConfig("logMessagePlaceholder");
            LogLevelPlaceholder = GetValueFromConfig("logLevelPlaceholder");
            NewlinePlaceholder = GetValueFromConfig("newlinePlaceholder");
            ExceptionPlaceholder = GetValueFromConfig("exceptionPlaceholder");
            BasedirPlaceholder = GetValueFromConfig("basedirPlaceholder");
            LogDbName = GetValueFromConfig("logDbName");
        }

        private static string GetValueFromConfig(string key) => ConfigurationManager.AppSettings[key];
    }
}
