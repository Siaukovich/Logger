using System;

namespace Logging.Base
{
    public abstract class AbstractLogger : ILogger
    {
        private readonly LogLevel _level;

        protected AbstractLogger(LogLevel level)
        {
            this._level = level;
        }

        #region Trace

        public void Trace(string msg)
        {
            this.ThrowForNull(msg, nameof(msg));

            this.Write(LogLevel.Trace, msg);
        }

        public void Trace(string msg, object arg)
        {
            this.ThrowForNull(msg, nameof(msg));
            this.ThrowForNull(arg, nameof(arg));

            var logMessage = string.Format(msg, arg);
            this.Write(LogLevel.Trace, logMessage);
        }

        public void Trace(string msg, object arg1, object arg2)
        {
            this.ThrowForNull(msg, nameof(msg));
            this.ThrowForNull(arg1, nameof(arg1));
            this.ThrowForNull(arg2, nameof(arg2));

            var logMessage = string.Format(msg, arg1, arg2);
            this.Write(LogLevel.Trace, logMessage);
        }

        public void Trace(string msg, object arg1, object arg2, object arg3)
        {
            this.ThrowForNull(msg, nameof(msg));
            this.ThrowForNull(arg1, nameof(arg1));
            this.ThrowForNull(arg2, nameof(arg2));
            this.ThrowForNull(arg3, nameof(arg3));

            var logMessage = string.Format(msg, arg1, arg2, arg3);
            this.Write(LogLevel.Trace, logMessage);
        }

        public void Trace(string msg, params object[] args)
        {
            this.ThrowForNull(msg, nameof(msg));
            this.ThrowIfAnyIsNull(args, nameof(args));

            var logMessage = string.Format(msg, args);
            this.Write(LogLevel.Trace, logMessage);
        }

        public void Trace(string msg, Exception ex)
        {
            this.ThrowForNull(msg, nameof(msg));

            this.Write(LogLevel.Trace, msg, ex);
        }

        public void Trace(string msg, object arg, Exception ex)
        {
            this.ThrowForNull(msg, nameof(msg));
            this.ThrowForNull(arg, nameof(arg));
            this.ThrowForNull(ex, nameof(ex));

            this.Write(LogLevel.Trace, msg, ex);
        }

        public void Trace(string msg, object arg1, object arg2, Exception ex)
        {
            this.ThrowForNull(msg, nameof(msg));
            this.ThrowForNull(arg1, nameof(arg1));
            this.ThrowForNull(arg2, nameof(arg2));
            this.ThrowForNull(ex, nameof(ex));

            var logMessage = string.Format(msg, arg1, arg2);
            this.Write(LogLevel.Trace, logMessage, ex);
        }

        public void Trace(string msg, object arg1, object arg2, object arg3, Exception ex)
        {
            this.ThrowForNull(msg, nameof(msg));
            this.ThrowForNull(arg1, nameof(arg1));
            this.ThrowForNull(arg2, nameof(arg2));
            this.ThrowForNull(arg3, nameof(arg3));
            this.ThrowForNull(ex, nameof(ex));

            var logMessage = string.Format(msg, arg1, arg2, arg3);
            this.Write(LogLevel.Trace, logMessage, ex);
        }

        public void Trace(string msg, object[] args, Exception ex)
        {
            this.ThrowForNull(msg, nameof(msg));
            this.ThrowIfAnyIsNull(args, nameof(args));
            this.ThrowForNull(ex, nameof(ex));

            var logMessage = string.Format(msg, args);
            this.Write(LogLevel.Trace, logMessage, ex);
        }

        #endregion

        #region Debug

        public void Debug(string msg)
        {
            if (!this.CanWriteDebug())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));

            this.Write(LogLevel.Debug, msg);
        }

        public void Debug(string msg, object arg)
        {
            if (!this.CanWriteDebug())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));
            this.ThrowForNull(arg, nameof(arg));

            var logMessage = string.Format(msg, arg);
            this.Write(LogLevel.Debug, logMessage);
        }

        public void Debug(string msg, object arg1, object arg2)
        {
            if (!this.CanWriteDebug())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));
            this.ThrowForNull(arg1, nameof(arg1));
            this.ThrowForNull(arg2, nameof(arg2));

            var logMessage = string.Format(msg, arg1, arg2);
            this.Write(LogLevel.Debug, logMessage);
        }

        public void Debug(string msg, object arg1, object arg2, object arg3)
        {
            if (!this.CanWriteDebug())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));
            this.ThrowForNull(arg1, nameof(arg1));
            this.ThrowForNull(arg2, nameof(arg2));
            this.ThrowForNull(arg3, nameof(arg3));

            var logMessage = string.Format(msg, arg1, arg2, arg3);
            this.Write(LogLevel.Debug, logMessage);
        }

        public void Debug(string msg, params object[] args)
        {
            if (!this.CanWriteDebug())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));
            this.ThrowIfAnyIsNull(args, nameof(args));

            var logMessage = string.Format(msg, args);
            this.Write(LogLevel.Debug, logMessage);
        }

        public void Debug(string msg, Exception ex)
        {
            if (!this.CanWriteDebug())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));

            this.Write(LogLevel.Debug, msg, ex);
        }

        public void Debug(string msg, object arg, Exception ex)
        {
            if (!this.CanWriteDebug())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));
            this.ThrowForNull(arg, nameof(arg));
            this.ThrowForNull(ex, nameof(ex));

            this.Write(LogLevel.Debug, msg, ex);
        }

        public void Debug(string msg, object arg1, object arg2, Exception ex)
        {
            if (!this.CanWriteDebug())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));
            this.ThrowForNull(arg1, nameof(arg1));
            this.ThrowForNull(arg2, nameof(arg2));
            this.ThrowForNull(ex, nameof(ex));

            var logMessage = string.Format(msg, arg1, arg2);
            this.Write(LogLevel.Debug, logMessage, ex);
        }

        public void Debug(string msg, object arg1, object arg2, object arg3, Exception ex)
        {
            if (!this.CanWriteDebug())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));
            this.ThrowForNull(arg1, nameof(arg1));
            this.ThrowForNull(arg2, nameof(arg2));
            this.ThrowForNull(arg3, nameof(arg3));
            this.ThrowForNull(ex, nameof(ex));

            var logMessage = string.Format(msg, arg1, arg2, arg3);
            this.Write(LogLevel.Debug, logMessage, ex);
        }

        public void Debug(string msg, object[] args, Exception ex)
        {
            if (!this.CanWriteDebug())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));
            this.ThrowIfAnyIsNull(args, nameof(args));
            this.ThrowForNull(ex, nameof(ex));

            var logMessage = string.Format(msg, args);
            this.Write(LogLevel.Debug, logMessage, ex);
        }

        #endregion

        #region Info

        public void Info(string msg)
        {
            if (!this.CanWriteInfo())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));

            this.Write(LogLevel.Info, msg);
        }

        public void Info(string msg, object arg)
        {
            if (!this.CanWriteInfo())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));
            this.ThrowForNull(arg, nameof(arg));

            var logMessage = string.Format(msg, arg);
            this.Write(LogLevel.Info, logMessage);
        }

        public void Info(string msg, object arg1, object arg2)
        {
            if (!this.CanWriteInfo())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));
            this.ThrowForNull(arg1, nameof(arg1));
            this.ThrowForNull(arg2, nameof(arg2));

            var logMessage = string.Format(msg, arg1, arg2);
            this.Write(LogLevel.Info, logMessage);
        }

        public void Info(string msg, object arg1, object arg2, object arg3)
        {
            if (!this.CanWriteInfo())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));
            this.ThrowForNull(arg1, nameof(arg1));
            this.ThrowForNull(arg2, nameof(arg2));
            this.ThrowForNull(arg3, nameof(arg3));

            var logMessage = string.Format(msg, arg1, arg2, arg3);
            this.Write(LogLevel.Info, logMessage);
        }

        public void Info(string msg, params object[] args)
        {
            if (!this.CanWriteInfo())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));
            this.ThrowIfAnyIsNull(args, nameof(args));

            var logMessage = string.Format(msg, args);
            this.Write(LogLevel.Info, logMessage);
        }

        public void Info(string msg, Exception ex)
        {
            if (!this.CanWriteInfo())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));

            this.Write(LogLevel.Info, msg, ex);
        }

        public void Info(string msg, object arg, Exception ex)
        {
            if (!this.CanWriteInfo())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));
            this.ThrowForNull(arg, nameof(arg));
            this.ThrowForNull(ex, nameof(ex));

            this.Write(LogLevel.Info, msg, ex);
        }

        public void Info(string msg, object arg1, object arg2, Exception ex)
        {
            if (!this.CanWriteInfo())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));
            this.ThrowForNull(arg1, nameof(arg1));
            this.ThrowForNull(arg2, nameof(arg2));
            this.ThrowForNull(ex, nameof(ex));

            var logMessage = string.Format(msg, arg1, arg2);
            this.Write(LogLevel.Info, logMessage, ex);
        }

        public void Info(string msg, object arg1, object arg2, object arg3, Exception ex)
        {
            if (!this.CanWriteInfo())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));
            this.ThrowForNull(arg1, nameof(arg1));
            this.ThrowForNull(arg2, nameof(arg2));
            this.ThrowForNull(arg3, nameof(arg3));
            this.ThrowForNull(ex, nameof(ex));

            var logMessage = string.Format(msg, arg1, arg2, arg3);
            this.Write(LogLevel.Info, logMessage, ex);
        }

        public void Info(string msg, object[] args, Exception ex)
        {
            if (!this.CanWriteInfo())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));
            this.ThrowIfAnyIsNull(args, nameof(args));
            this.ThrowForNull(ex, nameof(ex));

            var logMessage = string.Format(msg, args);
            this.Write(LogLevel.Info, logMessage, ex);
        }

        #endregion

        #region Warning

        public void Warning(string msg)
        {
            if (!this.CanWriteWarning())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));

            this.Write(LogLevel.Warning, msg);
        }

        public void Warning(string msg, object arg)
        {
            if (!this.CanWriteWarning())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));
            this.ThrowForNull(arg, nameof(arg));

            var logMessage = string.Format(msg, arg);
            this.Write(LogLevel.Warning, logMessage);
        }

        public void Warning(string msg, object arg1, object arg2)
        {
            if (!this.CanWriteWarning())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));
            this.ThrowForNull(arg1, nameof(arg1));
            this.ThrowForNull(arg2, nameof(arg2));

            var logMessage = string.Format(msg, arg1, arg2);
            this.Write(LogLevel.Warning, logMessage);
        }

        public void Warning(string msg, object arg1, object arg2, object arg3)
        {
            if (!this.CanWriteWarning())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));
            this.ThrowForNull(arg1, nameof(arg1));
            this.ThrowForNull(arg2, nameof(arg2));
            this.ThrowForNull(arg3, nameof(arg3));

            var logMessage = string.Format(msg, arg1, arg2, arg3);
            this.Write(LogLevel.Warning, logMessage);
        }

        public void Warning(string msg, params object[] args)
        {
            if (!this.CanWriteWarning())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));
            this.ThrowIfAnyIsNull(args, nameof(args));

            var logMessage = string.Format(msg, args);
            this.Write(LogLevel.Warning, logMessage);
        }

        public void Warning(string msg, Exception ex)
        {
            if (!this.CanWriteWarning())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));

            this.Write(LogLevel.Warning, msg, ex);
        }

        public void Warning(string msg, object arg, Exception ex)
        {
            if (!this.CanWriteWarning())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));
            this.ThrowForNull(arg, nameof(arg));
            this.ThrowForNull(ex, nameof(ex));

            this.Write(LogLevel.Warning, msg, ex);
        }

        public void Warning(string msg, object arg1, object arg2, Exception ex)
        {
            if (!this.CanWriteWarning())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));
            this.ThrowForNull(arg1, nameof(arg1));
            this.ThrowForNull(arg2, nameof(arg2));
            this.ThrowForNull(ex, nameof(ex));

            var logMessage = string.Format(msg, arg1, arg2);
            this.Write(LogLevel.Warning, logMessage, ex);
        }

        public void Warning(string msg, object arg1, object arg2, object arg3, Exception ex)
        {
            if (!this.CanWriteWarning())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));
            this.ThrowForNull(arg1, nameof(arg1));
            this.ThrowForNull(arg2, nameof(arg2));
            this.ThrowForNull(arg3, nameof(arg3));
            this.ThrowForNull(ex, nameof(ex));

            var logMessage = string.Format(msg, arg1, arg2, arg3);
            this.Write(LogLevel.Warning, logMessage, ex);
        }

        public void Warning(string msg, object[] args, Exception ex)
        {
            if (!this.CanWriteWarning())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));
            this.ThrowIfAnyIsNull(args, nameof(args));
            this.ThrowForNull(ex, nameof(ex));

            var logMessage = string.Format(msg, args);
            this.Write(LogLevel.Warning, logMessage, ex);
        }

        #endregion

        #region Error

        public void Error(string msg)
        {
            if (!this.CanWriteError())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));

            this.Write(LogLevel.Error, msg);
        }

        public void Error(string msg, object arg)
        {
            if (!this.CanWriteError())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));
            this.ThrowForNull(arg, nameof(arg));

            var logMessage = string.Format(msg, arg);
            this.Write(LogLevel.Error, logMessage);
        }

        public void Error(string msg, object arg1, object arg2)
        {
            if (!this.CanWriteError())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));
            this.ThrowForNull(arg1, nameof(arg1));
            this.ThrowForNull(arg2, nameof(arg2));

            var logMessage = string.Format(msg, arg1, arg2);
            this.Write(LogLevel.Error, logMessage);
        }

        public void Error(string msg, object arg1, object arg2, object arg3)
        {
            if (!this.CanWriteError())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));
            this.ThrowForNull(arg1, nameof(arg1));
            this.ThrowForNull(arg2, nameof(arg2));
            this.ThrowForNull(arg3, nameof(arg3));

            var logMessage = string.Format(msg, arg1, arg2, arg3);
            this.Write(LogLevel.Error, logMessage);
        }

        public void Error(string msg, params object[] args)
        {
            if (!this.CanWriteError())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));
            this.ThrowIfAnyIsNull(args, nameof(args));

            var logMessage = string.Format(msg, args);
            this.Write(LogLevel.Error, logMessage);
        }

        public void Error(string msg, Exception ex)
        {
            if (!this.CanWriteError())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));

            this.Write(LogLevel.Error, msg, ex);
        }

        public void Error(string msg, object arg, Exception ex)
        {
            if (!this.CanWriteError())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));
            this.ThrowForNull(arg, nameof(arg));
            this.ThrowForNull(ex, nameof(ex));

            this.Write(LogLevel.Error, msg, ex);
        }

        public void Error(string msg, object arg1, object arg2, Exception ex)
        {
            if (!this.CanWriteError())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));
            this.ThrowForNull(arg1, nameof(arg1));
            this.ThrowForNull(arg2, nameof(arg2));
            this.ThrowForNull(ex, nameof(ex));

            var logMessage = string.Format(msg, arg1, arg2);
            this.Write(LogLevel.Error, logMessage, ex);
        }

        public void Error(string msg, object arg1, object arg2, object arg3, Exception ex)
        {
            if (!this.CanWriteError())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));
            this.ThrowForNull(arg1, nameof(arg1));
            this.ThrowForNull(arg2, nameof(arg2));
            this.ThrowForNull(arg3, nameof(arg3));
            this.ThrowForNull(ex, nameof(ex));

            var logMessage = string.Format(msg, arg1, arg2, arg3);
            this.Write(LogLevel.Error, logMessage, ex);
        }

        public void Error(string msg, object[] args, Exception ex)
        {
            if (!this.CanWriteError())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));
            this.ThrowIfAnyIsNull(args, nameof(args));
            this.ThrowForNull(ex, nameof(ex));

            var logMessage = string.Format(msg, args);
            this.Write(LogLevel.Error, logMessage, ex);
        }

        #endregion

        #region Fatal

        public void Fatal(string msg)
        {
            if (!this.CanWriteFatal())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));

            this.Write(LogLevel.Fatal, msg);
        }

        public void Fatal(string msg, object arg)
        {
            if (!this.CanWriteFatal())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));
            this.ThrowForNull(arg, nameof(arg));

            var logMessage = string.Format(msg, arg);
            this.Write(LogLevel.Fatal, logMessage);
        }

        public void Fatal(string msg, object arg1, object arg2)
        {
            if (!this.CanWriteFatal())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));
            this.ThrowForNull(arg1, nameof(arg1));
            this.ThrowForNull(arg2, nameof(arg2));

            var logMessage = string.Format(msg, arg1, arg2);
            this.Write(LogLevel.Fatal, logMessage);
        }

        public void Fatal(string msg, object arg1, object arg2, object arg3)
        {
            if (!this.CanWriteFatal())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));
            this.ThrowForNull(arg1, nameof(arg1));
            this.ThrowForNull(arg2, nameof(arg2));
            this.ThrowForNull(arg3, nameof(arg3));

            var logMessage = string.Format(msg, arg1, arg2, arg3);
            this.Write(LogLevel.Fatal, logMessage);
        }

        public void Fatal(string msg, params object[] args)
        {
            if (!this.CanWriteFatal())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));
            this.ThrowIfAnyIsNull(args, nameof(args));

            var logMessage = string.Format(msg, args);
            this.Write(LogLevel.Fatal, logMessage);
        }

        public void Fatal(string msg, Exception ex)
        {
            if (!this.CanWriteFatal())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));

            this.Write(LogLevel.Fatal, msg, ex);
        }

        public void Fatal(string msg, object arg, Exception ex)
        {
            if (!this.CanWriteFatal())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));
            this.ThrowForNull(arg, nameof(arg));
            this.ThrowForNull(ex, nameof(ex));

            this.Write(LogLevel.Fatal, msg, ex);
        }

        public void Fatal(string msg, object arg1, object arg2, Exception ex)
        {
            if (!this.CanWriteFatal())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));
            this.ThrowForNull(arg1, nameof(arg1));
            this.ThrowForNull(arg2, nameof(arg2));
            this.ThrowForNull(ex, nameof(ex));

            var logMessage = string.Format(msg, arg1, arg2);
            this.Write(LogLevel.Fatal, logMessage, ex);
        }

        public void Fatal(string msg, object arg1, object arg2, object arg3, Exception ex)
        {
            if (!this.CanWriteFatal())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));
            this.ThrowForNull(arg1, nameof(arg1));
            this.ThrowForNull(arg2, nameof(arg2));
            this.ThrowForNull(arg3, nameof(arg3));
            this.ThrowForNull(ex, nameof(ex));

            var logMessage = string.Format(msg, arg1, arg2, arg3);
            this.Write(LogLevel.Fatal, logMessage, ex);
        }

        public void Fatal(string msg, object[] args, Exception ex)
        {
            if (!this.CanWriteFatal())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));
            this.ThrowIfAnyIsNull(args, nameof(args));
            this.ThrowForNull(ex, nameof(ex));

            var logMessage = string.Format(msg, args);
            this.Write(LogLevel.Fatal, logMessage, ex);
        }

        #endregion

        protected abstract void Write(LogLevel level, string msg);

        protected abstract void Write(LogLevel level, string msg, Exception ex);

        private void ThrowForNull(object value, string name)
        {
            if (value == null)
            {
                throw new ArgumentNullException(name);
            }
        }

        private void ThrowIfAnyIsNull(object[] values, string name)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == null)
                {
                    throw new ArgumentNullException($"{name}[{i}]");
                }
            }
        }

        private bool CanWriteDebug() => this._level >= LogLevel.Debug;

        private bool CanWriteInfo() => this._level >= LogLevel.Info;

        private bool CanWriteWarning() => this._level >= LogLevel.Warning;

        private bool CanWriteError() => this._level >= LogLevel.Error;

        private bool CanWriteFatal() => this._level >= LogLevel.Fatal;
    }
}
