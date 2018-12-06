using System;

namespace Logging.Base
{
    public interface ILogger
    {
        void Trace(string msg);

        void Trace(string msg, Exception ex);


        void Debug(string msg);

        void Debug(string msg, Exception ex);


        void Info(string msg);

        void Info(string msg, Exception ex);


        void Warning(string msg);

        void Warning(string msg, Exception ex);


        void Error(string msg);

        void Error(string msg, Exception ex);


        void Fatal(string msg);

        void Fatal(string msg, Exception ex);
    }
}
