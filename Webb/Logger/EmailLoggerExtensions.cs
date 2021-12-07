using ASC.Business.Interface;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Logger
{
    public static class EmailLoggerExtensions
    {
        public static ILoggerFactory AddAzureTableStorageLog(this ILoggerFactory factory,
        ILogDataOperations logOperations, Func<string, LogLevel, bool> filter = null)
        {
            factory.AddProvider(new AzureStorageLoggerProvider(filter, logOperations));
            return factory;
        }
    }
}
