namespace StromPriserWidgetAPI.WebAPI.Logging;

//
// Summary:
//     Event IDs for relational events that correspond to messages logged to an Microsoft.Extensions.Logging.ILogger
//     and events sent to a System.Diagnostics.DiagnosticSource.
//     These IDs are also used with Microsoft.EntityFrameworkCore.Diagnostics.WarningsConfigurationBuilder
//     to configure the behavior of warnings.
//
// Remarks:
//     See Logging, events, and diagnostics for more information.
public static class StromPriserEventId
{
  private enum Id
  {
    General = 20000,
    BackgroundService = 30000,
  }

  private static readonly string _generalPrefix = "[CORE]";
  private static readonly string _backgroundServicePrefix = "[BACKGROUND_SERVICE]";

  // Summary:
  //     A database connection is opening.
  //     This event is in the Microsoft.EntityFrameworkCore.DbLoggerCategory.Database.Connection
  //     category.
  //     This event uses the Microsoft.EntityFrameworkCore.Diagnostics.ConnectionEventData
  //     payload when used with a System.Diagnostics.DiagnosticSource.
  public static readonly EventId General = MakeGeneralId(Id.General);

  // Summary:
  //     A database connection has been opened.
  //     This event is in the Microsoft.EntityFrameworkCore.DbLoggerCategory.Database.Connection
  //     category.
  //     This event uses the Microsoft.EntityFrameworkCore.Diagnostics.ConnectionEndEventData
  //     payload when used with a System.Diagnostics.DiagnosticSource.
  public static readonly EventId BackgroundService = MakeBackgroundServiceId(Id.BackgroundService);

  private static EventId MakeGeneralId(Id id) => new((int)id, _generalPrefix + id);

  private static EventId MakeBackgroundServiceId(Id id) => new((int)id, _backgroundServicePrefix + id);
}
