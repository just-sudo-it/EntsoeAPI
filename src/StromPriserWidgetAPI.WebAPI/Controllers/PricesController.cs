namespace StromPriserWidgetAPI.WebAPI.Controllers
{
  using Microsoft.AspNetCore.Mvc;

  using StromPriserWidgetAPI.Data.Entities;

  [ApiController]
  [Route("[controller]")]
  public class PricesController : ControllerBase
  {
    private readonly ILogger<PricesController> logger;

    public PricesController(ILogger<PricesController> logger)
      => this.logger = logger;

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<ZonePrice> Get()
    {
      return Enumerable.Range(1, 5).Select(index => new ZonePrice
      {
      })
      .ToArray();
    }
  }
}
