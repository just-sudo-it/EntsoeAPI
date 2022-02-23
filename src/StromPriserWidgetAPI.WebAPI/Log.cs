namespace StromPriserWidgetAPI.WebAPI;

public static partial class Log
{
  [LoggerMessage(EventId = 0, Level = LogLevel.Information, Message = "Started service with hostname: `{hostName}`)")]
  public static partial void ServiceStarted(ILogger logger, string serviceName);

  [LoggerMessage(EventId = 1, Level = LogLevel.Information, Message = "Started service with hostname: `{hostName}`)")]
  public static partial void ServiceStopped(ILogger logger, string serviceName);

  [LoggerMessage(EventId = 2, Level = LogLevel.Critical, Message = "Service with hostname: `{hostName}` failed.Worker will retry after the normal interveral.:)")]
  public static partial void ServiceFailed(ILogger logger, string serviceName);

  [LoggerMessage(EventId = 3, Level = LogLevel.Critical, Message = "Service with hostname: `{hostName}` failed.Worker will retry after the normal interveral.)")]
  public static partial void ServiceFailed(ILogger logger, string serviceName, Exception ex);

}
