using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Desk.Gist.WorkerServiceDemo
{
    public class Worker : BackgroundService
    {
        private bool _isStopping = false;
        private readonly ILogger<Worker> _logger;
        private readonly IHostApplicationLifetime _hostApplicationLifetime;

        public Worker(ILogger<Worker> logger, IHostApplicationLifetime hostApplicationLifetime)
        {
            _logger = logger;
            _hostApplicationLifetime = hostApplicationLifetime;
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation($"The application is starting...");
            return base.StartAsync(cancellationToken);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            try
            {
                while (!stoppingToken.IsCancellationRequested)
                {
                    try
                    {
                        _logger.LogInformation($"Worker running at: { DateTimeOffset.Now}");

                        await BusinessWork(stoppingToken);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, "Global exception occurred. Will resume in a moment.");
                    }

                    await Task.Delay(2000, stoppingToken);
                }
            }
            finally
            {
                _logger.LogWarning("Exiting application...");
                FinishingTouches(stoppingToken);
                _hostApplicationLifetime.StopApplication();
            }
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation($"The application is stoping...");
            return base.StopAsync(cancellationToken);
        }



        private async Task BusinessWork(CancellationToken cancellationToken)
        {
            if (!_isStopping)
            {
                _logger.LogInformation($"Task in progress at {DateTimeOffset.Now}");
            }
            else
            {
                _logger.LogInformation($"Task in not underway at {DateTimeOffset.Now}");
            }

            await Task.CompletedTask;
        }

        private void FinishingTouches(CancellationToken cancellationToken)
        {
            _logger.LogInformation("The finishing touches are beginning...");
            Task.Delay(TimeSpan.FromSeconds(10)).Wait();
            _logger.LogInformation("The finishing touches are over...");

        }
    }
}
