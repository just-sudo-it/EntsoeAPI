namespace StromPriserWidgetAPI.WebAPI.Logging;

public static partial class Log
{
  [LoggerMessage(EventId = 0, Level = LogLevel.Information, Message = "Started service with hostname: `{serviceName}`)")]
  public static partial void ServiceStarted(ILogger logger, string serviceName);

  [LoggerMessage(EventId = 1, Level = LogLevel.Information, Message = "Started service with hostname: `{serviceName}`)")]
  public static partial void ServiceStopped(ILogger logger, string serviceName);

  [LoggerMessage(EventId = 3, Level = LogLevel.Critical, Message = "Background Service failed :`{error}`.Worker will retry after the normal interveral.)")]
  public static partial void ServiceFailed(ILogger logger, string serviceName, string error);

  [LoggerMessage(EventId = 4, Level = LogLevel.Debug, Message = "Error : `{error}`)")]
  public static partial void LogError(ILogger logger, string error);

  [LoggerMessage(EventId = 5, Level = LogLevel.Debug, Message = "Success : `{success}`)")]
  public static partial void LogSuccess(ILogger logger, string success);

  [LoggerMessage(EventId = 6, Level = LogLevel.Debug, Message = "`{info}`)")]
  public static partial void LogInfo(ILogger logger, string info);

}
