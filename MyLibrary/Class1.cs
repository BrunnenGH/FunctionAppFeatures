using Microsoft.Extensions.Logging;
using System;

namespace MyLibrary
{
    public class Class1
    {
        private readonly ILogger _log;

        public Class1(ILogger log)
        {
            _log = log;
        }
    }
}
