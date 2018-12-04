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

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Trace(msg);
            }
        }

        public void Trace(string msg, object arg)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(arg, nameof(arg));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Trace(msg, arg);
            }
        }

        public void Trace(string msg, object arg1, object arg2)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(arg1, nameof(arg1));
            ThrowForNull(arg2, nameof(arg2));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Trace(msg, arg1, arg2);
            }
        }

        public void Trace(string msg, object arg1, object arg2, object arg3)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(arg1, nameof(arg1));
            ThrowForNull(arg2, nameof(arg2));
            ThrowForNull(arg3, nameof(arg3));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Trace(msg, arg1, arg2, arg3);
            }
        }

        public void Trace(string msg, params object[] args)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowIfAnyIsNull(args, nameof(args));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Trace(msg, args);
            }
        }

        public void Trace(string msg, Exception ex)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(ex, nameof(ex));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Trace(msg, ex);
            }
        }

        public void Trace(string msg, object arg, Exception ex)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(arg, nameof(arg));
            ThrowForNull(ex, nameof(ex));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Trace(msg, arg, ex);
            }
        }

        public void Trace(string msg, object arg1, object arg2, Exception ex)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(arg1, nameof(arg1));
            ThrowForNull(arg2, nameof(arg2));
            ThrowForNull(ex, nameof(ex));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Trace(msg, arg1, arg2, ex);
            }
        }

        public void Trace(string msg, object arg1, object arg2, object arg3, Exception ex)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(arg1, nameof(arg1));
            ThrowForNull(arg2, nameof(arg2));
            ThrowForNull(arg3, nameof(arg3));
            ThrowForNull(ex, nameof(ex));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Trace(msg, arg1, arg2, arg3, ex);
            }
        }

        public void Trace(string msg, object[] args, Exception ex)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(ex, nameof(ex));
            ThrowIfAnyIsNull(args, nameof(args));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Trace(msg, args, ex);
            }
        }

        #endregion

        #region Debug

        public void Debug(string msg)
        {
            ThrowForNull(msg, nameof(msg));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Debug(msg);
            }
        }

        public void Debug(string msg, object arg)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(arg, nameof(arg));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Debug(msg, arg);
            }
        }

        public void Debug(string msg, object arg1, object arg2)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(arg1, nameof(arg1));
            ThrowForNull(arg2, nameof(arg2));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Debug(msg, arg1, arg2);
            }
        }

        public void Debug(string msg, object arg1, object arg2, object arg3)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(arg1, nameof(arg1));
            ThrowForNull(arg2, nameof(arg2));
            ThrowForNull(arg3, nameof(arg3));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Debug(msg, arg1, arg2, arg3);
            }
        }

        public void Debug(string msg, params object[] args)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowIfAnyIsNull(args, nameof(args));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Debug(msg, args);
            }
        }

        public void Debug(string msg, Exception ex)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(ex, nameof(ex));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Debug(msg, ex);
            }
        }

        public void Debug(string msg, object arg, Exception ex)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(arg, nameof(arg));
            ThrowForNull(ex, nameof(ex));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Debug(msg, arg, ex);
            }
        }

        public void Debug(string msg, object arg1, object arg2, Exception ex)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(arg1, nameof(arg1));
            ThrowForNull(arg2, nameof(arg2));
            ThrowForNull(ex, nameof(ex));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Debug(msg, arg1, arg2, ex);
            }
        }

        public void Debug(string msg, object arg1, object arg2, object arg3, Exception ex)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(arg1, nameof(arg1));
            ThrowForNull(arg2, nameof(arg2));
            ThrowForNull(arg3, nameof(arg3));
            ThrowForNull(ex, nameof(ex));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Debug(msg, arg1, arg2, arg3, ex);
            }
        }

        public void Debug(string msg, object[] args, Exception ex)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(ex, nameof(ex));
            ThrowIfAnyIsNull(args, nameof(args));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Debug(msg, args, ex);
            }
        }

        #endregion

        #region Info

        public void Info(string msg)
        {
            ThrowForNull(msg, nameof(msg));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Info(msg);
            }
        }

        public void Info(string msg, object arg)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(arg, nameof(arg));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Info(msg, arg);
            }
        }

        public void Info(string msg, object arg1, object arg2)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(arg1, nameof(arg1));
            ThrowForNull(arg2, nameof(arg2));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Info(msg, arg1, arg2);
            }
        }

        public void Info(string msg, object arg1, object arg2, object arg3)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(arg1, nameof(arg1));
            ThrowForNull(arg2, nameof(arg2));
            ThrowForNull(arg3, nameof(arg3));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Info(msg, arg1, arg2, arg3);
            }
        }

        public void Info(string msg, params object[] args)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowIfAnyIsNull(args, nameof(args));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Info(msg, args);
            }
        }

        public void Info(string msg, Exception ex)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(ex, nameof(ex));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Info(msg, ex);
            }
        }

        public void Info(string msg, object arg, Exception ex)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(arg, nameof(arg));
            ThrowForNull(ex, nameof(ex));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Info(msg, arg, ex);
            }
        }

        public void Info(string msg, object arg1, object arg2, Exception ex)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(arg1, nameof(arg1));
            ThrowForNull(arg2, nameof(arg2));
            ThrowForNull(ex, nameof(ex));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Info(msg, arg1, arg2, ex);
            }
        }

        public void Info(string msg, object arg1, object arg2, object arg3, Exception ex)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(arg1, nameof(arg1));
            ThrowForNull(arg2, nameof(arg2));
            ThrowForNull(arg3, nameof(arg3));
            ThrowForNull(ex, nameof(ex));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Info(msg, arg1, arg2, arg3, ex);
            }
        }

        public void Info(string msg, object[] args, Exception ex)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(ex, nameof(ex));
            ThrowIfAnyIsNull(args, nameof(args));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Info(msg, args, ex);
            }
        }

        #endregion

        #region Warning

        public void Warning(string msg)
        {
            ThrowForNull(msg, nameof(msg));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Warning(msg);
            }
        }

        public void Warning(string msg, object arg)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(arg, nameof(arg));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Warning(msg, arg);
            }
        }

        public void Warning(string msg, object arg1, object arg2)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(arg1, nameof(arg1));
            ThrowForNull(arg2, nameof(arg2));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Warning(msg, arg1, arg2);
            }
        }

        public void Warning(string msg, object arg1, object arg2, object arg3)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(arg1, nameof(arg1));
            ThrowForNull(arg2, nameof(arg2));
            ThrowForNull(arg3, nameof(arg3));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Warning(msg, arg1, arg2, arg3);
            }
        }

        public void Warning(string msg, params object[] args)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowIfAnyIsNull(args, nameof(args));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Warning(msg, args);
            }
        }

        public void Warning(string msg, Exception ex)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(ex, nameof(ex));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Warning(msg, ex);
            }
        }

        public void Warning(string msg, object arg, Exception ex)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(arg, nameof(arg));
            ThrowForNull(ex, nameof(ex));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Warning(msg, arg, ex);
            }
        }

        public void Warning(string msg, object arg1, object arg2, Exception ex)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(arg1, nameof(arg1));
            ThrowForNull(arg2, nameof(arg2));
            ThrowForNull(ex, nameof(ex));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Warning(msg, arg1, arg2, ex);
            }
        }

        public void Warning(string msg, object arg1, object arg2, object arg3, Exception ex)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(arg1, nameof(arg1));
            ThrowForNull(arg2, nameof(arg2));
            ThrowForNull(arg3, nameof(arg3));
            ThrowForNull(ex, nameof(ex));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Warning(msg, arg1, arg2, arg3, ex);
            }
        }

        public void Warning(string msg, object[] args, Exception ex)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(ex, nameof(ex));
            ThrowIfAnyIsNull(args, nameof(args));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Warning(msg, args, ex);
            }
        }

        #endregion

        #region Error

        public void Error(string msg)
        {
            ThrowForNull(msg, nameof(msg));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Error(msg);
            }
        }

        public void Error(string msg, object arg)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(arg, nameof(arg));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Error(msg, arg);
            }
        }

        public void Error(string msg, object arg1, object arg2)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(arg1, nameof(arg1));
            ThrowForNull(arg2, nameof(arg2));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Error(msg, arg1, arg2);
            }
        }

        public void Error(string msg, object arg1, object arg2, object arg3)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(arg1, nameof(arg1));
            ThrowForNull(arg2, nameof(arg2));
            ThrowForNull(arg3, nameof(arg3));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Error(msg, arg1, arg2, arg3);
            }
        }

        public void Error(string msg, params object[] args)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowIfAnyIsNull(args, nameof(args));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Error(msg, args);
            }
        }

        public void Error(string msg, Exception ex)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(ex, nameof(ex));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Error(msg, ex);
            }
        }

        public void Error(string msg, object arg, Exception ex)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(arg, nameof(arg));
            ThrowForNull(ex, nameof(ex));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Error(msg, arg, ex);
            }
        }

        public void Error(string msg, object arg1, object arg2, Exception ex)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(arg1, nameof(arg1));
            ThrowForNull(arg2, nameof(arg2));
            ThrowForNull(ex, nameof(ex));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Error(msg, arg1, arg2, ex);
            }
        }

        public void Error(string msg, object arg1, object arg2, object arg3, Exception ex)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(arg1, nameof(arg1));
            ThrowForNull(arg2, nameof(arg2));
            ThrowForNull(arg3, nameof(arg3));
            ThrowForNull(ex, nameof(ex));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Error(msg, arg1, arg2, arg3, ex);
            }
        }

        public void Error(string msg, object[] args, Exception ex)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(ex, nameof(ex));
            ThrowIfAnyIsNull(args, nameof(args));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Error(msg, args, ex);
            }
        }

        #endregion

        #region Fatal

        public void Fatal(string msg)
        {
            ThrowForNull(msg, nameof(msg));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Fatal(msg);
            }
        }

        public void Fatal(string msg, object arg)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(arg, nameof(arg));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Fatal(msg, arg);
            }
        }

        public void Fatal(string msg, object arg1, object arg2)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(arg1, nameof(arg1));
            ThrowForNull(arg2, nameof(arg2));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Fatal(msg, arg1, arg2);
            }
        }

        public void Fatal(string msg, object arg1, object arg2, object arg3)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(arg1, nameof(arg1));
            ThrowForNull(arg2, nameof(arg2));
            ThrowForNull(arg3, nameof(arg3));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Fatal(msg, arg1, arg2, arg3);
            }
        }

        public void Fatal(string msg, params object[] args)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowIfAnyIsNull(args, nameof(args));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Fatal(msg, args);
            }
        }

        public void Fatal(string msg, Exception ex)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(ex, nameof(ex));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Fatal(msg, ex);
            }
        }

        public void Fatal(string msg, object arg, Exception ex)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(arg, nameof(arg));
            ThrowForNull(ex, nameof(ex));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Fatal(msg, arg, ex);
            }
        }

        public void Fatal(string msg, object arg1, object arg2, Exception ex)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(arg1, nameof(arg1));
            ThrowForNull(arg2, nameof(arg2));
            ThrowForNull(ex, nameof(ex));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Fatal(msg, arg1, arg2, ex);
            }
        }

        public void Fatal(string msg, object arg1, object arg2, object arg3, Exception ex)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(arg1, nameof(arg1));
            ThrowForNull(arg2, nameof(arg2));
            ThrowForNull(arg3, nameof(arg3));
            ThrowForNull(ex, nameof(ex));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Fatal(msg, arg1, arg2, arg3, ex);
            }
        }

        public void Fatal(string msg, object[] args, Exception ex)
        {
            ThrowForNull(msg, nameof(msg));
            ThrowForNull(ex, nameof(ex));
            ThrowIfAnyIsNull(args, nameof(args));

            for (var i = 0; i < this._innerLoggers.Count; i++)
            {
                this._innerLoggers[i].Fatal(msg, args, ex);
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
    }
}
