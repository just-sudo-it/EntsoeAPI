namespace StromPriserWidgetAPI.WebAPI.Services;

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Xml;
using System.Xml.Serialization;

using Microsoft.AspNetCore.WebUtilities;

using StromPriserWidgetAPI.Data;
using StromPriserWidgetAPI.Data.Entities;
using StromPriserWidgetAPI.Models;

[SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Background services should not die")]
public class UpdateDbService : BackgroundService
{
  private readonly ILogger<UpdateDbService> logger;
  private readonly IServiceScopeFactory scopeFactory;
  private readonly IHttpClientFactory httpFactory;

  public UpdateDbService(
    ILogger<UpdateDbService> logger,
    IHttpClientFactory httpFactory,
    IServiceScopeFactory scopeFactory)
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

  protected override async Task ExecuteAsync(CancellationToken stoppingToken)
  {
    Log.ServiceStarted(logger, nameof(UpdateDbService));

    // Force asynchronous execution due to blocking Hosted Service Pipeline
    await Task.Yield();

    while (!stoppingToken.IsCancellationRequested)
    {
      try
      {
        await UpdateDatabase(stoppingToken);
      }
      catch (Exception ex)
      {
        Log.ServiceFailed(logger, nameof(UpdateDbService), ex.ToString());
        await Task.Delay(TimeSpan.FromSeconds(25), stoppingToken);
      }
    }
  }

  private async Task UpdateDatabase(CancellationToken cancellationToken)
  {
    var data = await GetPriceData(new DateTime(2022, 01, 02), new DateTime(2022, 01, 03), ZoneType.NO1, cancellationToken);
    using (var scope = scopeFactory.CreateScope())
    {
      using (var dbContext = scope.ServiceProvider.GetRequiredService<DataContext>())
      {
        //persistence code
      }
    }

    return;
  }

  private async Task<EntsoeDocument?> GetPriceData(DateTime dateFrom, DateTime dateTo, string zone, CancellationToken cancellationToken)
  {
    #region
    // entso api key  "2dac08d6-4c38-4606-8791-c78de794b47d"
    // entso root api path prod ->"https://transparency.entsoe.eu/api?periodStart=201601010000&periodEnd=201601020000 " dev->"https://iop-transparency.entsoe.eu/api?"
    using var client = httpFactory.CreateClient();

    var uri = $"https://power.ffail.win/?zone=NO2&date={DateTime.Now:yyyy-MM-dd}&key={Environment.GetEnvironmentVariable("STROMPRISER_API_KEY")}";
    var uri2 = $"https://power.ffail.win/?zone=NO2&date={DateTime.Now:yyyy-MM-dd}&key={Environment.GetEnvironmentVariable("STROMPRISER_API_KEY")}";
#endregion
    using var httpResponseMessage = await client.GetAsync(
      GetRequestUri(
        "https://transparency.entsoe.eu/api",
        new Dictionary<string, string?>()
        {
          { "securityToken", "2dac08d6-4c38-4606-8791-c78de794b47d" },
          { "periodStart", dateFrom.ToString("yyyyMMddHHmm", CultureInfo.InvariantCulture) },
          { "periodEnd", dateTo.ToString("yyyyMMddHHmm", CultureInfo.InvariantCulture) },
          { "documentType", "A44" },
          { "in_Domain", zone },
          { "out_Domain", zone },
          { "processType", "A16" },
          { "outBiddingZone_Domain", "10YCZ-CEPS-----N" },
        }),
      cancellationToken);

    Log.LogInfo(logger, $"{httpResponseMessage.StatusCode} /n {httpResponseMessage.ReasonPhrase}");

    EntsoeDocument? data = null;
    if (httpResponseMessage.IsSuccessStatusCode)
    {
      using var inStream = await httpResponseMessage.Content.ReadAsStreamAsync(cancellationToken);
      using var xmlReader = XmlReader.Create(inStream);
      data = new XmlSerializer(typeof(EntsoeDocument))
        .Deserialize(xmlReader) as EntsoeDocument;
    }

    return data;
  }

  private Uri GetRequestUri(string baseUri, IDictionary<string, string?>? @params = null)
  => @params is null
     ? new Uri(string.Empty)
     : new Uri(QueryHelpers.AddQueryString(baseUri, @params));
}
