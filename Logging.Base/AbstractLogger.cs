using System;

namespace Logging.Base
{
    public abstract class AbstractLogger : ILogger
    {
        // Костыль (или нет?).
        public DateTime LogTime { get; set; }

        private readonly LogLevel _level;

        protected AbstractLogger(LogLevel level)
        {
            this._level = level;
        }

        #region Trace

        public void Trace(string msg)
        {
            if (!this.CanWriteTrace())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));

            this.Write(LogLevel.Trace, msg);
        }

        public void Trace(string msg, Exception ex)
        {
            if (!this.CanWriteTrace())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));

            this.Write(LogLevel.Trace, msg, ex);
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

        public void Debug(string msg, Exception ex)
        {
            if (!this.CanWriteDebug())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));

            this.Write(LogLevel.Debug, msg, ex);
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

        public void Info(string msg, Exception ex)
        {
            if (!this.CanWriteInfo())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));

            this.Write(LogLevel.Info, msg, ex);
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

        public void Warning(string msg, Exception ex)
        {
            if (!this.CanWriteWarning())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));

            this.Write(LogLevel.Warning, msg, ex);
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

        public void Error(string msg, Exception ex)
        {
            if (!this.CanWriteError())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));

            this.Write(LogLevel.Error, msg, ex);
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

        public void Fatal(string msg, Exception ex)
        {
            if (!this.CanWriteFatal())
            {
                return;
            }

            this.ThrowForNull(msg, nameof(msg));

            this.Write(LogLevel.Fatal, msg, ex);
        }

        #endregion

        /// <summary>
        /// Writes to log destination.
        /// </summary>
        /// <param name="logEntry">
        /// String that will be outputted into log destination.
        /// </param>
        protected abstract void Write(LogLevel level, string msg);

        /// <summary>
        /// Writes to log destination.
        /// </summary>
        /// <param name="logEntry">
        /// String that will be outputted into log destination.
        /// </param>
        /// <param name="ex">
        /// Exception that will be outputted into log destination.
        /// </param>
        protected abstract void Write(LogLevel level, string msg, Exception ex);

        private void ThrowForNull(object value, string name)
        {
            if (value == null)
            {
                throw new ArgumentNullException(name);
            }
        }

        private bool CanWriteTrace() => this._level == LogLevel.Trace;

        private bool CanWriteDebug() => this._level <= LogLevel.Debug;

        private bool CanWriteInfo() => this._level <= LogLevel.Info;

        private bool CanWriteWarning() => this._level <= LogLevel.Warning;

        private bool CanWriteError() => this._level <= LogLevel.Error;

        private bool CanWriteFatal() => this._level <= LogLevel.Fatal;
    }
}
