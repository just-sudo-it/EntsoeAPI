namespace StromPriserWidgetAPI.WebAPI.Controllers;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

using StromPriserWidgetAPI.WebAPI.Logging;

public abstract class BaseController<TController> : ControllerBase
  where TController : BaseController<TController>
{
  protected BaseController(ILogger<TController> logger) => Logger = logger;

  protected ILogger<TController> Logger { get; }

  // Summary:
  //     Creates an Microsoft.AspNetCore.Mvc.BadRequestObjectResult that produces a Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest
  //     response.
  // Parameters:
  //   error:
  //     An error object to be returned to the client.
  // Returns:
  //     The created Microsoft.AspNetCore.Mvc.BadRequestObjectResult for the response.
  [NonAction]
  public override BadRequestObjectResult BadRequest([ActionResultObjectValue] object? error)
  {
    Log.LogError(Logger, error?.ToString() ?? string.Empty);
    return base.BadRequest(error);
  }
}
