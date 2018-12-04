using System;

namespace Logging.Base
{
    public interface ILogger
    {
        void Trace(string msg);

        void Trace(string msg, object arg);

        void Trace(string msg, object arg1, object arg2);

        void Trace(string msg, object arg1, object arg2, object arg3);

        void Trace(string msg, params object[] args);

        void Trace(string msg, Exception ex);

        void Trace(string msg, object arg, Exception ex);

        void Trace(string msg, object arg1, object arg2, Exception ex);

        void Trace(string msg, object arg1, object arg2, object arg3, Exception ex);

        void Trace(string msg, object[] args, Exception ex);


        void Debug(string msg);

        void Debug(string msg, object arg);

        void Debug(string msg, object arg1, object arg2);

        void Debug(string msg, object arg1, object arg2, object arg3);

        void Debug(string msg, params object[] args);

        void Debug(string msg, Exception ex);

        void Debug(string msg, object arg, Exception ex);

        void Debug(string msg, object arg1, object arg2, Exception ex);

        void Debug(string msg, object arg1, object arg2, object arg3, Exception ex);

        void Debug(string msg, object[] args, Exception ex);


        void Info(string msg);

        void Info(string msg, object arg);

        void Info(string msg, object arg1, object arg2);

        void Info(string msg, object arg1, object arg2, object arg3);

        void Info(string msg, params object[] args);

        void Info(string msg, Exception ex);

        void Info(string msg, object arg, Exception ex);

        void Info(string msg, object arg1, object arg2, Exception ex);

        void Info(string msg, object arg1, object arg2, object arg3, Exception ex);

        void Info(string msg, object[] args, Exception ex);


        void Warning(string msg);

        void Warning(string msg, object arg);

        void Warning(string msg, object arg1, object arg2);

        void Warning(string msg, object arg1, object arg2, object arg3);

        void Warning(string msg, params object[] args);

        void Warning(string msg, Exception ex);

        void Warning(string msg, object arg, Exception ex);

        void Warning(string msg, object arg1, object arg2, Exception ex);

        void Warning(string msg, object arg1, object arg2, object arg3, Exception ex);

        void Warning(string msg, object[] args, Exception ex);



        void Error(string msg);

        void Error(string msg, object arg);

        void Error(string msg, object arg1, object arg2);

        void Error(string msg, object arg1, object arg2, object arg3);

        void Error(string msg, params object[] args);

        void Error(string msg, Exception ex);

        void Error(string msg, object arg, Exception ex);

        void Error(string msg, object arg1, object arg2, Exception ex);

        void Error(string msg, object arg1, object arg2, object arg3, Exception ex);

        void Error(string msg, object[] args, Exception ex);



        void Fatal(string msg);

        void Fatal(string msg, object arg);

        void Fatal(string msg, object arg1, object arg2);

        void Fatal(string msg, object arg1, object arg2, object arg3);

        void Fatal(string msg, params object[] args);

        void Fatal(string msg, Exception ex);

        void Fatal(string msg, object arg, Exception ex);

        void Fatal(string msg, object arg1, object arg2, Exception ex);

        void Fatal(string msg, object arg1, object arg2, object arg3, Exception ex);

        void Fatal(string msg, object[] args, Exception ex);
    }
}
