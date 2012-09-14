using System;
using System.Diagnostics;

namespace app.utility
{
  public interface IProvideAccessToLogging
  {
    Type type_that_wanted_logging { get; set; }
  }

  public class LoggingExtensionPoint : IProvideAccessToLogging
  {
    public Type type_that_wanted_logging { get; set; }
  }

  public static class WeirdLoggingExtensions
  {
    public static void all_the_current_calls(this IProvideAccessToLogging extension_point)
    {
      throw new NotImplementedException();
    }
  }

  public static class NormalLoggingExtensions
  {
    public static void info(this IProvideAccessToLogging extension_point, string message)
    {
      throw new NotImplementedException();
    }
  }

  public static class EventLoggingExtensions
  {
    public static void info(this IProvideAccessToLogging extension_point, EventLog log)
    {
      throw new NotImplementedException();
    }
  }
}