namespace StromPriserWidgetAPI.WebAPI.Logging;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

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
    ConnectionOpening = 20000,
    ConnectionOpened = 20001,
  }

  private static readonly string _connectionPrefix = LoggerCategory<DbLoggerCategory.Database.Connection>.Name + ".";
  private static readonly string _modelPrefix = LoggerCategory<DbLoggerCategory.Model>.Name + ".";

  //
  // Summary:
  //     A database connection is opening.
  //     This event is in the Microsoft.EntityFrameworkCore.DbLoggerCategory.Database.Connection
  //     category.
  //     This event uses the Microsoft.EntityFrameworkCore.Diagnostics.ConnectionEventData
  //     payload when used with a System.Diagnostics.DiagnosticSource.
  public static readonly EventId ConnectionOpening = MakeConnectionId(Id.ConnectionOpening);

  //
  // Summary:
  //     A database connection has been opened.
  //     This event is in the Microsoft.EntityFrameworkCore.DbLoggerCategory.Database.Connection
  //     category.
  //     This event uses the Microsoft.EntityFrameworkCore.Diagnostics.ConnectionEndEventData
  //     payload when used with a System.Diagnostics.DiagnosticSource.
  public static readonly EventId ConnectionOpened = MakeCommandId(Id.ConnectionOpened);


  private static EventId MakeConnectionId(Id id)
  {
    return new EventId((int)id, _connectionPrefix + id);
  }

  private static EventId MakeCommandId(Id id)
  {
    return new EventId((int)id, _modelPrefix + id);
  }
}
