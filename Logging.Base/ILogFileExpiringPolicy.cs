namespace Logging.Base
{
    public interface ILogFileExpiringPolicy
    {
        bool IsExpired(string logFilePath);
    }
}