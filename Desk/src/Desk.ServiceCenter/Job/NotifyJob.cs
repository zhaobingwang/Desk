using Desk.ServiceCenter.Hubs;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desk.ServiceCenter.Job
{
    [DisallowConcurrentExecution]
    public class NotifyJob : IJob
    {
        private readonly IHubContext<NotifyHub> _hubContext;
        private readonly ILogger<NotifyJob> _logger;
        public NotifyJob(ILogger<NotifyJob> logger, IHubContext<NotifyHub> hubContext)
        {
            _logger = logger;
            _hubContext = hubContext;
        }

        public async Task Execute(IJobExecutionContext context)
        {
            await _hubContext.Clients.All.SendAsync("dev", $"Quartz message from server.");
            _logger.LogInformation("Quartz message from server.");
        }
    }
}
