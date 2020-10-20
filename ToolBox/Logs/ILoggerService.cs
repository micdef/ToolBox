using System;
using System.Collections.Generic;
using System.Text;

namespace ToolBox.Logs
{
    /// <summary>
    /// Service used to write in log files
    /// </summary>
    interface ILoggerService
    {
        /// <summary>
        /// Method used to write in log with DEBUG level
        /// </summary>
        /// <param name="currentObjectName">Object name where caller is located</param>
        /// <param name="callerName">Caller method</param>
        /// <param name="message">Message to write</param>
        /// <param name="parmeters">Parameters (variables, ...) It's a Dictionary with name and value</param>
        void WriteDebug(string currentObjectName, string callerName, string message, Dictionary<string, string> parmeters);

        /// <summary>
        /// Method used to write in log with ERROR level
        /// </summary>
        /// <param name="currentObjectName">Object name where caller is located</param>
        /// <param name="callerName">Caller method</param>
        /// <param name="message">Message to write</param>
        /// <param name="ex">Exception received by the caller (can be null)</param>
        void WriteError(string currentObjectName, string callerName, string message, Exception ex = null);

        /// <summary>
        /// Method used to write in log with FATAL level
        /// </summary>
        /// <param name="currentObjectName">Object name where caller is located</param>
        /// <param name="callerName">Caller method</param>
        /// <param name="message">Message to write</param>
        /// <param name="ex">Exception received by the caller (can be null)</param>
        void WriteFatal(string currentObjectName, string callerName, string message, Exception ex = null);

        /// <summary>
        /// Method used to write in log with INFORMATION level
        /// </summary>
        /// <param name="currentObjectName">Object name where caller is located</param>
        /// <param name="callerName">Caller method</param>
        /// <param name="message">Message to write</param>
        void WriteInformation(string currentObjectName, string callerName, string message);

        /// <summary>
        /// Method used to write in log with TRACE level
        /// </summary>
        /// <param name="currentObjectName">Object name where caller is located</param>
        /// <param name="callerName">Caller method</param>
        /// <param name="message">Message to write</param>
        void WriteTrace(string currentObjectName, string callerName, string message);

        /// <summary>
        /// Method used to write in log with WARNING level
        /// </summary>
        /// <param name="currentObjectName">Object name where caller is located</param>
        /// <param name="callerName">Caller method</param>
        /// <param name="message">Message to write</param>
        void WriteWarning(string currentObjectName, string callerName, string message);
    }
}
