using ASC.Business.Interface;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Logger
{
    public class AzureStorageLogger : ILogger
    {
        private readonly string _categoryName;
        private readonly Func<string, LogLevel, bool> _filter;
        private readonly ILogDataOperations _logOperations;
        public AzureStorageLogger(string categoryName, Func<string, LogLevel, bool> filter,
        ILogDataOperations logOperations)
        {
            _categoryName = categoryName;
            _filter = filter;
            _logOperations = logOperations;
        }
        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }
        public bool IsEnabled(LogLevel logLevel)
        {
            return (_filter == null || _filter(_categoryName, logLevel));
        }
        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception
        exception, Func<TState, Exception, string> formatter)
        {
            if (!IsEnabled(logLevel))
                return;
            if (exception == null)
                _logOperations.CreateLogAsync(logLevel.ToString(), formatter(state, exception));
            else
                _logOperations.CreateExceptionLogAsync(eventId.Name, exception.Message,

                exception.StackTrace);

        }
    }
}
