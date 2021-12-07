using ASC.Business.Interface;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Logger
{
    public class AzureStorageLoggerProvider : ILoggerProvider
    {
        private readonly Func<string, LogLevel, bool> _filter;
        private readonly ILogDataOperations _logOperations;
        public AzureStorageLoggerProvider(Func<string, LogLevel, bool> filter,
        ILogDataOperations logOperations)
        {
            _logOperations = logOperations;
            _filter = filter;
        }
        public ILogger CreateLogger(string categoryName)
        {
            return new AzureStorageLogger(categoryName, _filter, _logOperations);
        }
        public void Dispose()
        {
        }
    }
}
