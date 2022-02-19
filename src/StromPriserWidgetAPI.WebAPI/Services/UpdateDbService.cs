namespace StromPriserWidgetAPI.WebAPI.Services;

public class UpdateDbService : BackgroundService
{
  private readonly ILogger<UpdateDbService>? _logger;

  public UpdateDbService(ILogger<UpdateDbService> logger)
  {
    _logger = logger;
  }

  protected override async Task ExecuteAsync(CancellationToken stoppingToken)
  {
    _logger.LogInformation("Timed Hosted Service is running.");

    while (stoppingToken.IsCancellationRequested)
    {
      await UpdateDatabase(stoppingToken);

      await Task.Delay(TimeSpan.FromHours(24), stoppingToken);
    }
  }

  public override Task StopAsync(CancellationToken cancellationToken)
  {
    _logger.LogInformation("Timed Hosted Service is stopping.");

    return Task.CompletedTask;
  }

  private Task UpdateDatabase(CancellationToken cancellationToken)
  {
    return Task.CompletedTask;
  }
}
