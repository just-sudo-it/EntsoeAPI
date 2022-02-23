namespace StromPriserWidgetAPI.WebAPI.Services;

using System.Diagnostics.CodeAnalysis;

using Microsoft.Net.Http.Headers;

using StromPriserWidgetAPI.Data;

public class UpdateDbService : BackgroundService
{
  private readonly ILogger<UpdateDbService> logger;
  private readonly IServiceScopeFactory scopeFactory;
  private readonly IHttpClientFactory httpFactory;

  public UpdateDbService(
    ILogger<UpdateDbService> logger,
    IHttpClientFactory httpFactory,
    [NotNull] IServiceScopeFactory scopeFactory)
  {
    this.logger = logger;
    this.httpFactory = httpFactory;
    this.scopeFactory = scopeFactory;
  }

  public override Task StopAsync(CancellationToken cancellationToken)
  {
    Log.ServiceStopped(logger, nameof(UpdateDbService));

    return Task.CompletedTask;
  }

  [SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Background service should not die")]
  protected override async Task ExecuteAsync(CancellationToken stoppingToken)
  {
    try
    {
      Log.ServiceStarted(logger, nameof(UpdateDbService));

      while (!stoppingToken.IsCancellationRequested)
      {
        await UpdateDatabase(stoppingToken);

        await Task.Delay(TimeSpan.FromHours(24), stoppingToken);
      }
    }
    catch (Exception ex)
    {
      Log.ServiceFailed(logger, nameof(UpdateDbService), ex);
    }
  }

  private Task UpdateDatabase(CancellationToken cancellationToken)
  {
    using (var scope = scopeFactory.CreateScope())
    {
      using (var dbContext = scope.ServiceProvider.GetRequiredService<DataContext>())
      {
      }
    }

    return Task.CompletedTask;
  }

  private async Task GetPriceData(CancellationToken cancellationToken)
  {
    using var client = httpFactory.CreateClient();
    using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, "https://api.github.com/repos/dotnet/AspNetCore.Docs/branches")
    {
      Headers = { { HeaderNames.Accept, "application/vnd.github.v3+json" }, { HeaderNames.UserAgent, "HttpRequestsSample" }, },
    };
    var httpResponseMessage = await client.SendAsync(httpRequestMessage, cancellationToken);

    if (httpResponseMessage.IsSuccessStatusCode)
    {
      using var contentStream = await httpResponseMessage.Content.ReadAsStreamAsync(cancellationToken);

      /*     GitHubBranches = await JsonSerializer.DeserializeAsync
               <IEnumerable<GitHubBranch>>(contentStream);
        */
    }

    return;
  }
}
