using System.Collections.Generic;
using System;

using Logging.Base;

namespace Logging
{
    public class LoggersWrapper : ILogger
    {
        private readonly List<AbstractLogger> _innerLoggers;

        internal LoggersWrapper(List<AbstractLogger> innerLoggers)
        {
            this._innerLoggers = innerLoggers ?? throw new ArgumentNullException(nameof(innerLoggers));
        }

        #region Trace

        public void Trace(string msg)
        {
            ThrowForNull(msg, nameof(msg));

            var now = DateTime.UtcNow;
            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].LogTime = now;
                this._innerLoggers[i].Trace(msg);
            }
        }

        public void Trace(string msg, Exception ex)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(ex, nameof(ex));

            var now = DateTime.UtcNow;
            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].LogTime = now;
                this._innerLoggers[i].Trace(msg, ex);
            }
        }

        #endregion

        #region Debug

        public void Debug(string msg)
        {
            ThrowForNull(msg, nameof(msg));

            var now = DateTime.UtcNow;
            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].LogTime = now;
                this._innerLoggers[i].Debug(msg);
            }
        }

        public void Debug(string msg, Exception ex)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(ex, nameof(ex));

            var now = DateTime.UtcNow;
            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].LogTime = now;
                this._innerLoggers[i].Debug(msg, ex);
            }
        }

        #endregion

        #region Info

        public void Info(string msg)
        {
            ThrowForNull(msg, nameof(msg));

            var now = DateTime.UtcNow;
            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].LogTime = now;
                this._innerLoggers[i].Info(msg);
            }
        }

        public void Info(string msg, Exception ex)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(ex, nameof(ex));

            var now = DateTime.UtcNow;
            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].LogTime = now;
                this._innerLoggers[i].Info(msg, ex);
            }
        }

        #endregion

        #region Warning

        public void Warning(string msg)
        {
            ThrowForNull(msg, nameof(msg));

            var now = DateTime.UtcNow;
            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].LogTime = now;
                this._innerLoggers[i].Warning(msg);
            }
        }

        public void Warning(string msg, Exception ex)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(ex, nameof(ex));

            var now = DateTime.UtcNow;
            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].LogTime = now;
                this._innerLoggers[i].Warning(msg, ex);
            }
        }

        #endregion

        #region Error

        public void Error(string msg)
        {
            ThrowForNull(msg, nameof(msg));

            var now = DateTime.UtcNow;
            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].LogTime = now;
                this._innerLoggers[i].Error(msg);
            }
        }

        public void Error(string msg, Exception ex)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(ex, nameof(ex));

            var now = DateTime.UtcNow;
            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].LogTime = now;
                this._innerLoggers[i].Error(msg, ex);
            }
        }

        #endregion

        #region Fatal

        public void Fatal(string msg)
        {
            ThrowForNull(msg, nameof(msg));

            var now = DateTime.UtcNow;
            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].LogTime = now;
                this._innerLoggers[i].Fatal(msg);
            }
        }

        public void Fatal(string msg, Exception ex)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(ex, nameof(ex));

            var now = DateTime.UtcNow;
            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].LogTime = now;
                this._innerLoggers[i].Fatal(msg, ex);
            }
        }

        #endregion

        private void ThrowForNull(object value, string name)
        {
            if (value == null)
            {
                throw new ArgumentNullException(name);
            }
        }
    }
}
