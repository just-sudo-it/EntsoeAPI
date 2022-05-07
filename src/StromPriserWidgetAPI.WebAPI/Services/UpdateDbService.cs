namespace StromPriserWidgetAPI.WebAPI.Services;

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Xml;
using System.Xml.Serialization;

using StromPriserWidgetAPI.Models;

using Microsoft.AspNetCore.WebUtilities;

using StromPriserWidgetAPI.Data;
using StromPriserWidgetAPI.Data.Entities;
using StromPriserWidgetAPI.WebAPI.Logging;
using System.Xml.Schema;

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
    var document = await GetPriceData(new DateTime(2022, 01, 02), new DateTime(2022, 01, 03), ZoneType.NO1, cancellationToken);

    using (var scope = scopeFactory.CreateScope())
    {
      using var dbContext = scope.ServiceProvider.GetRequiredService<DataContext>();

      // persistence code
    }

    return;
  }

  private async Task<EntsoeDocument?> GetPriceData(DateTime dateFrom, DateTime dateTo, string zone, CancellationToken cancellationToken)
  {

    using var client = httpFactory.CreateClient();

  /*  var prodBaseUri = "https://transparency.entsoe.eu/api" */
    var devBaseUri = "https://iop-transparency.entsoe.eu/api";

    using var httpResponseMessage = await client.GetAsync(
      GetRequestUri(devBaseUri, new Dictionary<string, string?>()
      {
        { "securityToken", "2dac08d6-4c38-4606-8791-c78de794b47d" }, // {Environment.GetEnvironmentVariable("STROMPRISER_API_KEY")
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

    if (httpResponseMessage.IsSuccessStatusCode)
    {
      using var inStream = await httpResponseMessage.Content.ReadAsStreamAsync(cancellationToken);

      var serializer = new XmlSerializer(typeof(EntsoeDocument));
      serializer.UnknownNode += new XmlNodeEventHandler(UnknownNodeCallBack);
      serializer.UnknownAttribute += new XmlAttributeEventHandler(UnknownAttributeCallBack);

      var readerSettings = new XmlReaderSettings() { Async = true };
      readerSettings.ValidationEventHandler += new ValidationEventHandler(ValidationCallBack);
      using var xmlReader = XmlReader.Create(inStream, readerSettings);

      var data = serializer.Deserialize(xmlReader) as EntsoeDocument;

      return data;
    }

    return null;
  }

  private static Uri GetRequestUri(string baseUri, IDictionary<string, string?>? @params = null)
  => @params is null
     ? new Uri(string.Empty)
     : new Uri(QueryHelpers.AddQueryString(baseUri, @params));

  private void ValidationCallBack(object? sender, ValidationEventArgs args)
    => Log.SerializerError(logger, "Xml validation error:" + args.Message);

  private void UnknownNodeCallBack(object? sender, XmlNodeEventArgs e)
    => Log.SerializerError(logger, "Unknown Node:" + e.Name + "\t" + e.Text);

  private void UnknownAttributeCallBack(object? sender, XmlAttributeEventArgs e)
    => Log.SerializerError(logger, "Unknown attribute " + e.Attr.Name + "='" + e.Attr.Value + "'");
}
