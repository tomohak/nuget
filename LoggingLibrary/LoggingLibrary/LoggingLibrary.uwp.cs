using System;
using System.Collections.Generic;
using System.Text;

namespace Plugin.LoggingLibrary
{
    /// <summary>
    /// Interface for LoggingLibrary
    /// </summary>
    public class LoggingLibraryImplementation : ILoggingLibrary
    {
        /// <summary>
        /// Log a message
        /// </summary>
        public void Log(string text)
        {
            throw new NotImplementedException("Called Log on UWP");
        }
    }
}
