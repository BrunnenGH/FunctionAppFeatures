using Microsoft.Extensions.Logging;
using System;

namespace MyLibrary
{
    public class Class1
    {
        private readonly ILogger<Class1> _log;

        public Class1(ILogger log)
        {
            _log = log;
        }

        public void Log()
        {
            _log.LogTrace("Class1.Log() 1. Default configuration: LogTrace");
            _log.LogDebug("Class1.Log() 2. Default configuration. LogDebug");
            _log.LogInformation("Class1.Log() 3. Default configuration. LogInformation");
            _log.LogWarning("Class1.Log() 4. Default configuration. LogWarning");
            _log.LogError("Class1.Log() 5. Default configuration. LogError");
        }
    }
}
