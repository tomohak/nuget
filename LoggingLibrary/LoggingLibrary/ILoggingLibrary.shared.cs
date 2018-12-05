using System;
using System.Collections.Generic;
using System.Text;

namespace Plugin.LoggingLibrary
{
    public interface ILoggingLibrary
    {
        /// <summary>
        /// Log a message
        /// </summary>
        void Log(string text);
    }
}
