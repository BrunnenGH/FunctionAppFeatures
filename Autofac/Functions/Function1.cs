using FunctionApp1.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace FunctionApp1.Functions
{
    public class Function1 : IDisposable
    {
        private readonly IService1 _service1;
        private readonly ILogger _logger;
        private readonly Guid _id = Guid.NewGuid();
        private bool disposedValue;

        public Function1(IService1 service1, ILogger logger)
        {
            _service1 = service1;
            _logger = logger;
            _logger.LogWarning($"Creating {this}");
        }

        //public void Dispose()
        //{
        //    _logger.LogWarning($"Disposing {this}");
        //}

        [FunctionName(nameof(Function1))]
        public async Task Run([HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req)
        {
            await Task.Delay(2000);
            _logger.LogInformation($"Function1 processed");
        }

        public override string ToString()
        {
            return $"{_id} ({nameof(Function1)})";
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~Function1()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}