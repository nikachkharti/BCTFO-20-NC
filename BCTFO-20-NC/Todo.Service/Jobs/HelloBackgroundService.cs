using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Todo.Service.Jobs
{
    public class HelloBackgroundService : BackgroundService
    {
        private readonly ILogger<HelloBackgroundService> _logger;
        public HelloBackgroundService(ILogger<HelloBackgroundService> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    _logger.LogInformation("HELLO BACKGROUND JOB IS RUNNING");

                    await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken);
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "ERROR WHILE HELLO EXECUTING BACKGROUND JOB");
                }
            }
        }
    }
}
