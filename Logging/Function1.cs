using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using MyLibrary;

namespace Logging
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogTrace("Function1 1. Default configuration: LogTrace");
            log.LogDebug("Function1 2. Default configuration. LogDebug");
            log.LogInformation("Function1 3. Default configuration. LogInformation");
            log.LogWarning("Function1 4. Default configuration. LogWarning");
            log.LogError("Function1 5. Default configuration. LogError");

            var o = new Class1(log);

            return new OkObjectResult("ok");
        }

    }
}
