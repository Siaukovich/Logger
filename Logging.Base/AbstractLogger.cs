using System;
using System.Collections.Generic;

namespace Logging.Base
{
    public abstract class AbstractLogger : ILogger
    {
        private readonly LogLevel _level;

        private readonly string _logMessageLayout;

        protected AbstractLogger(LogLevel level, string logMessageLayout)
        {
            this._level = level;

            this._logMessageLayout = logMessageLayout ?? throw new ArgumentNullException(nameof(logMessageLayout));
        }

        #region Trace

        public void Trace(string msg)
        {
            this.ThrowForNull(msg, nameof(msg));

            var logEntry = ParseLogMessage(LogLevel.Trace, msg);
            this.Write(logEntry);
        }

        public void Trace(string msg, object arg)
        {
            this.ThrowForNull(msg, nameof(msg));
            this.ThrowForNull(arg, nameof(arg));

            var logMessage = string.Format(msg, arg);
            var logEntry = ParseLogMessage(LogLevel.Trace, logMessage);
            this.Write(logEntry);
        }

        public void Trace(string msg, object arg1, object arg2)
        {
            this.ThrowForNull(msg, nameof(msg));
            this.ThrowForNull(arg1, nameof(arg1));
            this.ThrowForNull(arg2, nameof(arg2));

            var logMessage = string.Format(msg, arg1, arg2);
            var logEntry = ParseLogMessage(LogLevel.Trace, logMessage);
            this.Write(logEntry);
        }

        public void Trace(string msg, object arg1, object arg2, object arg3)
        {
            this.ThrowForNull(msg, nameof(msg));
            this.ThrowForNull(arg1, nameof(arg1));
            this.ThrowForNull(arg2, nameof(arg2));
            this.ThrowForNull(arg3, nameof(arg3));

            var logMessage = string.Format(msg, arg1, arg2, arg3);
            var logEntry = ParseLogMessage(LogLevel.Trace, logMessage);
            this.Write(logEntry);
        }

        public void Trace(string msg, params object[] args)
        {
            this.ThrowForNull(msg, nameof(msg));
            this.ThrowIfAnyIsNull(args, nameof(args));

            var logMessage = string.Format(msg, args);
            var logEntry = ParseLogMessage(LogLevel.Trace, logMessage);
            this.Write(logEntry);
        }

        public void Trace(string msg, Exception ex)
        {
            this.ThrowForNull(msg, nameof(msg));

            var logEntry = ParseLogMessage(LogLevel.Trace, msg, ex);
            this.Write(logEntry);
        }

        public void Trace(string msg, object arg, Exception ex)
        {
            this.ThrowForNull(msg, nameof(msg));
            this.ThrowForNull(arg, nameof(arg));
            this.ThrowForNull(ex, nameof(ex));

            var logMessage = string.Format(msg, arg);
            var logEntry = ParseLogMessage(LogLevel.Trace, logMessage, ex);
            this.Write(logEntry);
        }

        public void Trace(string msg, object arg1, object arg2, Exception ex)
        {
            this.ThrowForNull(msg, nameof(msg));
            this.ThrowForNull(arg1, nameof(arg1));
            this.ThrowForNull(arg2, nameof(arg2));
            this.ThrowForNull(ex, nameof(ex));

            var logMessage = string.Format(msg, arg1, arg2);
            var logEntry = ParseLogMessage(LogLevel.Trace, logMessage, ex);
            this.Write(logEntry);
        }

        public void Trace(string msg, object arg1, object arg2, object arg3, Exception ex)
        {
            this.ThrowForNull(msg, nameof(msg));
            this.ThrowForNull(arg1, nameof(arg1));
            this.ThrowForNull(arg2, nameof(arg2));
            this.ThrowForNull(arg3, nameof(arg3));
            this.ThrowForNull(ex, nameof(ex));

            var logMessage = string.Format(msg, arg1, arg2, arg3);
            var logEntry = ParseLogMessage(LogLevel.Trace, logMessage, ex);
            this.Write(logEntry);
        }

        public void Trace(string msg, object[] args, Exception ex)
        {
            this.ThrowForNull(msg, nameof(msg));
            this.ThrowIfAnyIsNull(args, nameof(args));
            this.ThrowForNull(ex, nameof(ex));

            var logMessage = string.Format(msg, args);
            var logEntry = ParseLogMessage(LogLevel.Trace, logMessage, ex);
            this.Write(logEntry);
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

            var logEntry = ParseLogMessage(LogLevel.Debug, msg);
            this.Write(logEntry);
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
            var logEntry = ParseLogMessage(LogLevel.Debug, logMessage);
            this.Write(logEntry);
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
            var logEntry = ParseLogMessage(LogLevel.Debug, logMessage);
            this.Write(logEntry);
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
            var logEntry = ParseLogMessage(LogLevel.Debug, logMessage);
            this.Write(logEntry);
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
            var logEntry = ParseLogMessage(LogLevel.Debug, logMessage);
            this.Write(logEntry);
        }

        public void Debug(string msg, Exception ex)
        {
            if (!this.CanWriteDebug())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));

            var logEntry = ParseLogMessage(LogLevel.Debug, msg, ex);
            this.Write(logEntry);
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

            var logMessage = string.Format(msg, arg);
            var logEntry = ParseLogMessage(LogLevel.Debug, logMessage, ex);
            this.Write(logEntry);
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
            var logEntry = ParseLogMessage(LogLevel.Debug, logMessage, ex);
            this.Write(logEntry);
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
            var logEntry = ParseLogMessage(LogLevel.Debug, logMessage, ex);
            this.Write(logEntry);
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
            var logEntry = ParseLogMessage(LogLevel.Debug, logMessage, ex);
            this.Write(logEntry);
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

            var logEntry = ParseLogMessage(LogLevel.Info, msg);
            this.Write(logEntry);
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
            var logEntry = ParseLogMessage(LogLevel.Info, logMessage);
            this.Write(logEntry);
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
            var logEntry = ParseLogMessage(LogLevel.Info, logMessage);
            this.Write(logEntry);
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
            var logEntry = ParseLogMessage(LogLevel.Info, logMessage);
            this.Write(logEntry);
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
            var logEntry = ParseLogMessage(LogLevel.Info, logMessage);
            this.Write(logEntry);
        }

        public void Info(string msg, Exception ex)
        {
            if (!this.CanWriteInfo())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));

            var logEntry = ParseLogMessage(LogLevel.Info, msg, ex);
            this.Write(logEntry);
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

            var logMessage = string.Format(msg, arg);
            var logEntry = ParseLogMessage(LogLevel.Info, logMessage, ex);
            this.Write(logEntry);
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
            var logEntry = ParseLogMessage(LogLevel.Info, logMessage, ex);
            this.Write(logEntry);
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
            var logEntry = ParseLogMessage(LogLevel.Info, logMessage, ex);
            this.Write(logEntry);
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
            var logEntry = ParseLogMessage(LogLevel.Info, logMessage, ex);
            this.Write(logEntry);
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

            var logEntry = ParseLogMessage(LogLevel.Warning, msg);
            this.Write(logEntry);
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
            var logEntry = ParseLogMessage(LogLevel.Warning, logMessage);
            this.Write(logEntry);
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
            var logEntry = ParseLogMessage(LogLevel.Warning, logMessage);
            this.Write(logEntry);
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
            var logEntry = ParseLogMessage(LogLevel.Warning, logMessage);
            this.Write(logEntry);
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
            var logEntry = ParseLogMessage(LogLevel.Warning, logMessage);
            this.Write(logEntry);
        }

        public void Warning(string msg, Exception ex)
        {
            if (!this.CanWriteWarning())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));

            var logEntry = ParseLogMessage(LogLevel.Warning, msg, ex);
            this.Write(logEntry);
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

            var logMessage = string.Format(msg, arg);
            var logEntry = ParseLogMessage(LogLevel.Warning, logMessage, ex);
            this.Write(logEntry);
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
            var logEntry = ParseLogMessage(LogLevel.Warning, logMessage, ex);
            this.Write(logEntry);
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
            var logEntry = ParseLogMessage(LogLevel.Warning, logMessage, ex);
            this.Write(logEntry);
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
            var logEntry = ParseLogMessage(LogLevel.Warning, logMessage, ex);
            this.Write(logEntry);
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

            var logEntry = ParseLogMessage(LogLevel.Error, msg);
            this.Write(logEntry);
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
            var logEntry = ParseLogMessage(LogLevel.Error, logMessage);
            this.Write(logEntry);
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
            var logEntry = ParseLogMessage(LogLevel.Error, logMessage);
            this.Write(logEntry);
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
            var logEntry = ParseLogMessage(LogLevel.Error, logMessage);
            this.Write(logEntry);
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
            var logEntry = ParseLogMessage(LogLevel.Error, logMessage);
            this.Write(logEntry);
        }

        public void Error(string msg, Exception ex)
        {
            if (!this.CanWriteError())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));

            var logEntry = ParseLogMessage(LogLevel.Error, msg, ex);
            this.Write(logEntry);
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

            var logMessage = string.Format(msg, arg);
            var logEntry = ParseLogMessage(LogLevel.Error, logMessage, ex);
            this.Write(logEntry);
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
            var logEntry = ParseLogMessage(LogLevel.Error, logMessage, ex);
            this.Write(logEntry);
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
            var logEntry = ParseLogMessage(LogLevel.Error, logMessage, ex);
            this.Write(logEntry);
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
            var logEntry = ParseLogMessage(LogLevel.Error, logMessage, ex);
            this.Write(logEntry);
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

            var logEntry = ParseLogMessage(LogLevel.Fatal, msg);
            this.Write(logEntry);
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
            var logEntry = ParseLogMessage(LogLevel.Fatal, logMessage);
            this.Write(logEntry);
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
            var logEntry = ParseLogMessage(LogLevel.Fatal, logMessage);
            this.Write(logEntry);
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
            var logEntry = ParseLogMessage(LogLevel.Fatal, logMessage);
            this.Write(logEntry);
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
            var logEntry = ParseLogMessage(LogLevel.Fatal, logMessage);
            this.Write(logEntry);
        }

        public void Fatal(string msg, Exception ex)
        {
            if (!this.CanWriteFatal())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));

            var logEntry = ParseLogMessage(LogLevel.Fatal, msg, ex);
            this.Write(logEntry);
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

            var logMessage = string.Format(msg, arg);
            var logEntry = ParseLogMessage(LogLevel.Fatal, logMessage, ex);
            this.Write(logEntry);
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
            var logEntry = ParseLogMessage(LogLevel.Fatal, logMessage, ex);
            this.Write(logEntry);
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
            var logEntry = ParseLogMessage(LogLevel.Fatal, logMessage, ex);
            this.Write(logEntry);
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
            var logEntry = ParseLogMessage(LogLevel.Fatal, logMessage, ex);
            this.Write(logEntry);
        }

        #endregion

        /// <summary>
        /// Writes to log destination.
        /// </summary>
        /// <param name="logEntry">
        /// String that will be outputted into log destination.
        /// </param>
        protected abstract void Write(string logEntry);

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

        private string ParseLogMessage(LogLevel level, string msg)
        {
            var layoutValues = GetLogLayoutValues(level, msg, null);
            return Parse(layoutValues);
        }

        private string ParseLogMessage(LogLevel level, string msg, Exception ex)
        {
            var layoutValues = GetLogLayoutValues(level, msg, ex);
            return Parse(layoutValues);
        }

        private string Parse(Dictionary<string, string> layoutValues)
        {
            var prevIndex = 0;
            var logMsg = this._logMessageLayout;
            foreach (var layoutPair in layoutValues)
            {
                var searchFor = $"{{{layoutPair.Key}}}";
                var index = logMsg.IndexOf(searchFor, prevIndex, StringComparison.InvariantCulture);
                if (index != -1)
                {
                    logMsg = logMsg.Replace(searchFor, layoutPair.Value);
                    prevIndex = index + 1;
                }
            }

            return logMsg;
        }

        private Dictionary<string, string> GetLogLayoutValues(LogLevel level, string msg, Exception ex)
        {
            const string DT_FORMAT = "yyyy-MM-dd HH:mm:ss.fffffff";
            return new Dictionary<string, string>
            {
                { "datetime", DateTime.UtcNow.ToString(DT_FORMAT) },
                { "message", msg },
                { "logLevel", level.ToString() },
                { "newline", Environment.NewLine },
                { "exception", ex?.ToString() ?? string.Empty }
            };
        }
    }
}
