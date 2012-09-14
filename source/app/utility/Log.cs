using System;
using System.Diagnostics;

namespace app.utility
{
  public class Log
  {
    public static GetLoggingFactory_Behaviour logging_factory_resolution = () => 
    {
      throw new NotImplementedException("Needs to be set during startup ");
    };

    public static GetTheCallingType_Behaviour calling_type_resolution = () =>
      new StackFrame(2).GetMethod().DeclaringType;

    public static IProvideAccessToLogging an
    {
      get { return logging_factory_resolution().create_logger_bound_to(calling_type_resolution()); }
    }

  }
}