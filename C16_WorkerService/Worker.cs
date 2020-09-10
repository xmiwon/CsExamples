using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace C16_WorkerService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        // _ innebär att variabeln är private
        private readonly string _url = "https://google.com";
        private HttpClient _client;
        private HttpResponseMessage _result;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;

        }



        public override Task StartAsync(CancellationToken cancellationToken)
        {
            _client = new HttpClient();
            _logger.LogInformation("The service has been started.");


            return base.StartAsync(cancellationToken);
        }


        public override Task StopAsync(CancellationToken cancellationToken)
        {
            //städar upp efter oss - tar bort från RAM
            _client.Dispose();
            _logger.LogInformation("The service has been stopped.");


            return base.StopAsync(cancellationToken);
        }








        //Uför programmet
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {

                try
                {
                    _result = await _client.GetAsync(_url);
                    // http status code such as 200 OK, 400 bad request. IsSuccessStatusCode betyder får man en av de 2xx status koder
                    if (_result.IsSuccessStatusCode)
                    {
                        _logger.LogInformation($"The website ({_url}) is up. Status Code = {_result.StatusCode}");
                    }
                    else
                    {
                        _logger.LogInformation($"The website ({_url}) is down. Status Code = {_result.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogInformation($"Failed. The website ({_url}) - {ex.Message}");
                }
                

                


                await Task.Delay(10*1000, stoppingToken);
            }
        }
    }
}
