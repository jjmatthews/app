using System;

namespace app.utility
{
  public class Log
  {
    public static GetCurrentLoggingBehaviour logging_behaviour = loggerType =>
    {
      throw new NotImplementedException("Needs to be created during startup ");
    };

    public static ILog an
    {
      get { return logging_behaviour(typeof(int)); }
    }
  }
}