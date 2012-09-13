using System;

namespace app.utility
{
  public class Log
  {
    public static GetLoggingFactory_Behaviour logging_factory_resolution = () => 
    {
      throw new NotImplementedException("Needs to be created during startup ");
    };

    public static ILog an
    {
      get { return logging_factory_resolution().create_logger_bound_to(get_the_calling_class()); }
    }

    static Type get_the_calling_class()
    {
      throw new NotImplementedException();
    }
  }
}