using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Logging
{
    public static class Function2
    {
        [FunctionName("Function2")]
        public static async Task<IActionResult> Run2(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogTrace("Function2 1. Default configuration: LogTrace");
            log.LogDebug("Function2 2. Default configuration. LogDebug");
            log.LogInformation("Function2 3. Default configuration. LogInformation");
            log.LogWarning("Function2 4. Default configuration. LogWarning");
            log.LogError("Function2 5. Default configuration. LogError");


            return new OkObjectResult("ok");
        }

    }
}
