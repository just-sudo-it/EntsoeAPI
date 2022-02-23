namespace StromPriserWidgetAPI.WebAPI.Services;

using System.Diagnostics.CodeAnalysis;

using Kritikos.StromPriserWidgetAPI.Data;

public class UpdateDbService : BackgroundService
{
  protected readonly ILogger<UpdateDbService> _logger;
  protected readonly IServiceScopeFactory _scopeFactory;

  public UpdateDbService(
    ILogger<UpdateDbService> logger,
    [NotNull] IServiceScopeFactory scopeFactory)
  {
    _logger = logger;
    _scopeFactory = scopeFactory;
  }

  public override Task StopAsync(CancellationToken cancellationToken)
  {
    _logger.LogInformation("Timed Hosted Service is stopping.");

    return Task.CompletedTask;
  }

  protected override async Task ExecuteAsync(CancellationToken stoppingToken)
  {
    _logger.LogInformation("Timed Hosted Service is running.");

    while (!stoppingToken.IsCancellationRequested)
    {
      await UpdateDatabase(stoppingToken);

      await Task.Delay(TimeSpan.FromHours(24), stoppingToken);
    }
  }

  private Task UpdateDatabase(CancellationToken cancellationToken)
  {
    using (var scope = _scopeFactory.CreateScope())
    {
      using (var dbContext = scope.ServiceProvider.GetRequiredService<DataContext>())
      {
        try
        {


        }
        catch (Exception e)
        {
          _logger.LogError(e.Message);
        }
      }
    }
    return Task.CompletedTask;
  }

  private Task GetPriceData(CancellationToken cancellationToken)
  {
    return Task.CompletedTask;
  }
}
